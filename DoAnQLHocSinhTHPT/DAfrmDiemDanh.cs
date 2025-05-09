using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLyHocSinh
{
    public partial class DAfrmDiemDanh : Form
    {
        public DAfrmDiemDanh()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DAfrmDiemDanh_Load(object sender, EventArgs e)
        {
            dgvdiemdanh.DataSource = LayDsDiemDanh();
            cbHocSinh.DataSource = LayDSHocSinh();
            cbHocSinh.DisplayMember = "HoTen";
            cbHocSinh.ValueMember = "MaHocSinh";

            cbLop.DataSource = LayDSLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";

            cbLop.SelectedIndexChanged += cbLop_SelectedIndexChanged;


            if (cbLop.SelectedValue != null)
            {
                int maLop = Convert.ToInt32(cbLop.SelectedValue);
                cbHocSinh.DataSource = LayDanhSachHocSinhTheoLop(maLop);
                cbHocSinh.DisplayMember = "HoTen";
                cbHocSinh.ValueMember = "MaHocSinh";
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable LayDSLop()
        {
            DataTable dtLop = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdlop = new SqlCommand("LayDanhSachLop", conn);
                cmdlop.CommandType = CommandType.StoredProcedure;
                cmdlop.Connection = conn;

                SqlDataAdapter daLop = new SqlDataAdapter(cmdlop);
                daLop.Fill(dtLop);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtLop;

        }

        public DataTable LayDsDiemDanh()
        {
            DataTable dtdiemdanh = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdd = new SqlCommand("LayDanhSachDiemDanh", conn);
                cmdd.CommandType = CommandType.StoredProcedure;
                cmdd.Connection = conn;

                SqlDataAdapter daLop = new SqlDataAdapter(cmdd);
                daLop.Fill(dtdiemdanh);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtdiemdanh;

        }
        public DataTable LayDSHocSinh()
        {
            DataTable dths = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdgv = new SqlCommand("LayDanhSachHocSinh", conn);
                cmdgv.CommandType = CommandType.StoredProcedure;
                cmdgv.Connection = conn;
                SqlDataAdapter datagv = new SqlDataAdapter(cmdgv);
                datagv.Fill(dths);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dths;
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedItem != null)
            {

                var selectedItem = cbLop.SelectedItem as DataRowView;
                if (selectedItem != null)
                {
                    int maLop = Convert.ToInt32(selectedItem["MaLop"]);
                    cbHocSinh.DataSource = LayDanhSachHocSinhTheoLop(maLop);
                    cbHocSinh.DisplayMember = "TenHocSinh";
                    cbHocSinh.ValueMember = "MaHocSinh";
                }
            }
        }
        public DataTable LayDanhSachHocSinhTheoLop(int maLop)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LayDanhSachHocSinhTheoLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

              
                conn.Open();
                SqlCommand cmdThem = new SqlCommand("sp_ThemDiemDanh", conn);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.Parameters.AddWithValue("@mahocsinh", cbHocSinh.SelectedValue);
                cmdThem.Parameters.AddWithValue("@malop", cbLop.SelectedValue);
                cmdThem.Parameters.AddWithValue("@ngaydiemdanh", dtpDiemDanh.Value);
                cmdThem.Parameters.AddWithValue("@trangthai", cbtrangthai.SelectedItem);
              
               
                if (cmdThem.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã Điểm Danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            dgvdiemdanh.DataSource = LayDsDiemDanh();
        }
    }
}
