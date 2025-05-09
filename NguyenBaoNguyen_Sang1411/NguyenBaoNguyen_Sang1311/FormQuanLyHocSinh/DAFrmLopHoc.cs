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
    public partial class DAFrmLopHoc : Form
    {
        public DAFrmLopHoc()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=SHRIMP\\NGANH;Initial Catalog=DOANQLHSTHPT;Integrated Security=True");

        private void DAFrmLopHoc_Load(object sender, EventArgs e)
        {
            dgvDSlophoc.DataSource = layDSLop();
            cbGVCN.DataSource = LoadDanhSachGiaoVien();
            cbGVCN.DisplayMember = "hoten";
            cbGVCN.ValueMember = "magiaovien";

        }



        public DataTable layDSLop()
        {
            DataTable dtlop = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdgv = new SqlCommand("LayDanhSachLop", conn);
                cmdgv.CommandType = CommandType.StoredProcedure;
                cmdgv.Connection = conn;
                SqlDataAdapter datagv = new SqlDataAdapter(cmdgv);
                datagv.Fill(dtlop);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtlop;
        }

        private void dgvDSlophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = dgvDSlophoc.CurrentCell.RowIndex;
            txtmalop.Text = dgvDSlophoc.Rows[rows].Cells[0].Value.ToString();
            txttenlop.Text = dgvDSlophoc.Rows[rows].Cells[1].Value.ToString();
            cbKhoi.Text = dgvDSlophoc.Rows[rows].Cells[2].Value.ToString();
            cbGVCN.SelectedValue = dgvDSlophoc.Rows[rows].Cells[3].Value.ToString();
        }

        private void btnaddlop_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdthem = new SqlCommand("sp_ThemLop", conn);
                cmdthem.CommandType = CommandType.StoredProcedure;

                SqlParameter parmalop = new SqlParameter("@malop", txtmalop.Text);
                SqlParameter partenlop = new SqlParameter("@tenlop", txttenlop.Text);
                SqlParameter parkhoi = new SqlParameter("@Khoi", cbKhoi.Text);

                // Truyền MaGiaoVien từ ComboBox (cbGVCN chỉ chứa mã giáo viên)
                SqlParameter pargvcn = new SqlParameter("@magiaovien", cbGVCN.SelectedValue);

                cmdthem.Parameters.Add(parmalop);
                cmdthem.Parameters.Add(partenlop);
                cmdthem.Parameters.Add(parkhoi);
                cmdthem.Parameters.Add(pargvcn);

                int rowsAffected = cmdthem.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có lớp nào được thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            dgvDSlophoc.DataSource = layDSLop();
        }

        private DataTable LoadDanhSachGiaoVien()
        {
            DataTable dtgv = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdgv = new SqlCommand("LayDanhSachGiaoVien", conn);
                cmdgv.CommandType = CommandType.StoredProcedure;
                cmdgv.Connection = conn;
                SqlDataAdapter datagv = new SqlDataAdapter(cmdgv);
                datagv.Fill(dtgv);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtgv;
        }

        private void btnthoatlop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?",
                "Xác nhận thoát?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdXoa = new SqlCommand("sp_XoaLop", conn);
                cmdXoa.CommandType = CommandType.StoredProcedure;
                SqlParameter parmalop = new SqlParameter("@malop", txtmalop.Text);
                cmdXoa.Parameters.Add(parmalop);

                int rowsAffected = cmdXoa.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoá lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có lớp nào được xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            dgvDSlophoc.DataSource = layDSLop();
        }

        private void btnsualop_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdSua = new SqlCommand("sp_SuaLop", conn);
                cmdSua.CommandType = CommandType.StoredProcedure;

                SqlParameter parmalop = new SqlParameter("@malop", txtmalop.Text);
                SqlParameter partenlop = new SqlParameter("@tenlop", txttenlop.Text);
                SqlParameter parkhoi = new SqlParameter("@Khoi", cbKhoi.Text);
                SqlParameter pargvcn = new SqlParameter("@magiaovien", cbGVCN.SelectedItem.ToString());

                cmdSua.Parameters.Add(parmalop);
                cmdSua.Parameters.Add(partenlop);
                cmdSua.Parameters.Add(parkhoi);
                cmdSua.Parameters.Add(pargvcn);

                int rowsAffected = cmdSua.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có lớp nào được sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            dgvDSlophoc.DataSource = layDSLop();
        }
    }
}
