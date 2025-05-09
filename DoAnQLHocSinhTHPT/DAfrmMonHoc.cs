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
    public partial class DAfrmMonHoc : Form
    {
        public DAfrmMonHoc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
        private void DAfrmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = laydsmonhoc();
        }
        public DataTable laydsmonhoc()
        {
            DataTable dtmonhoc = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdmh = new SqlCommand("LayDanhSachMon", conn);
                cmdmh.CommandType = CommandType.StoredProcedure;
                cmdmh.Connection = conn;
                SqlDataAdapter datagv = new SqlDataAdapter(cmdmh);
                datagv.Fill(dtmonhoc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtmonhoc;
        }

        private void btnthoat_Click(object sender, EventArgs e)
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

        private void btnsua_Click(object sender, EventArgs e)
        {


            try
            {
                conn.Open();
                SqlCommand cmdmh = new SqlCommand("sp_SuaMonHoc", conn);
                cmdmh.CommandType = CommandType.StoredProcedure;
                cmdmh.Connection = conn;
                SqlParameter parmamh = new SqlParameter("@mamonhoc", txtmamon.Text);
                SqlParameter partenmon = new SqlParameter("@tenmonhoc", txttenmon.Text);
                cmdmh.Parameters.Add(parmamh);
                cmdmh.Parameters.Add(partenmon);
                if (cmdmh.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa không  Thành Công", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = laydsmonhoc();
               
            }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdmh = new SqlCommand("sp_ThemMonHoc", conn);
                cmdmh.CommandType = CommandType.StoredProcedure;
                cmdmh.Connection = conn;
                SqlParameter parmamh = new SqlParameter("@mamonhoc", txtmamon.Text);
                SqlParameter partenmon = new SqlParameter("@tenmonhoc", txttenmon.Text);
                cmdmh.Parameters.Add(parmamh);
                cmdmh.Parameters.Add(partenmon);
                if (cmdmh.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không  Thành Công", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = laydsmonhoc();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdmh = new SqlCommand("sp_XoaMonHoc", conn);
                cmdmh.CommandType = CommandType.StoredProcedure;
                cmdmh.Connection = conn;
                SqlParameter parmamh = new SqlParameter("@mamonhoc", txtmamon.Text);
                cmdmh.Parameters.Add(parmamh);
                if (cmdmh.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không  Thành Công", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = laydsmonhoc();


        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = dgvMonHoc.CurrentCell.RowIndex;
            txtmamon.Text = dgvMonHoc.Rows[rows].Cells[0].Value.ToString();
            txttenmon.Text = dgvMonHoc.Rows[rows].Cells[1].Value.ToString();
        }
    }
    }

