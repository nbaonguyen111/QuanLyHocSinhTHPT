using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace FormQuanLyHocSinh
{
    public partial class DAfrmGVCN : Form
    {

        public DAfrmGVCN()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=SHRIMP\\NGANH;Initial Catalog=DOANQLHSTHPT;Integrated Security=True");
        private void DAfrmGVCN_Load(object sender, EventArgs e)
        {
            dgvGVCN.DataSource = LoadDanhSachGiaoVien();
            cbMonHoc.DataSource = LayDuLieuMH();
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "MaMonHoc";
        }

        public DataTable LayDuLieuMH()
        {
            DataTable dtgv = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdgv = new SqlCommand("LayDanhSachMon", conn);
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
        private void dgvGVCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            int rows = dgvGVCN.CurrentCell.RowIndex;
            txtmagv.Text = dgvGVCN.Rows[rows].Cells[0].Value.ToString();
            txthotengv.Text = dgvGVCN.Rows[rows].Cells[1].Value.ToString();
            dtpngaysinhgv.Text = dgvGVCN.Rows[rows].Cells[2].Value.ToString();
            if (rdonamgv.Checked = dgvGVCN.Rows[rows].Cells[3].Value.ToString()=="Nam")
            {
                rdonamgv.Checked = true;
            }
            else
            {
                rdonugv.Checked = true;
            }
            txtdiachigv.Text = dgvGVCN.Rows[rows].Cells[4].Value.ToString();
            txtsodtgv.Text = dgvGVCN.Rows[rows].Cells[5].Value.ToString();
            txtemail.Text = dgvGVCN.Rows[rows].Cells[6].Value.ToString();
            cbMonHoc.SelectedValue = dgvGVCN.Rows[rows].Cells[7].Value.ToString();

            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            
        }

        private void btnaddgv_Click(object sender, EventArgs e)
        {
            //DateTime ngaysinh = DateTime.ParseExact(dtpngaysinhgv.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            try
            {
                conn.Open();
                SqlCommand cmdthem = new SqlCommand("themGV", conn);
                cmdthem.CommandType = CommandType.StoredProcedure;
                cmdthem.Connection = conn;
                SqlParameter parmagv = new SqlParameter("@magiaovien", txtmagv.Text);
                SqlParameter parhoten = new SqlParameter("@hoten", txthotengv.Text);
                SqlParameter parngaysinh = new SqlParameter("@ngaysinh", dtpngaysinhgv.Value);
                SqlParameter pargioitinh = new SqlParameter("@gioitinh",SqlDbType.NVarChar,10);
                pargioitinh.Value = rdonamgv.Checked ? "Nam" : "Nữ";
                SqlParameter pardiachi = new SqlParameter("@diachi", txtdiachigv.Text);
                SqlParameter pardienthoai = new SqlParameter("@dienthoai", txtsodtgv.Text);
                SqlParameter paremail = new SqlParameter("@email", txtemail.Text);
                SqlParameter parmonhoc = new SqlParameter("@mongiangday", cbMonHoc.Text);
                cmdthem.Parameters.Add(parmagv);
                cmdthem.Parameters.Add(parhoten);
                cmdthem.Parameters.Add(parngaysinh);
                cmdthem.Parameters.Add(pargioitinh);
                cmdthem.Parameters.Add(pardiachi);
                cmdthem.Parameters.Add(pardienthoai);
                cmdthem.Parameters.Add(paremail);
                cmdthem.Parameters.Add(parmonhoc);
      
                int rowsAffected = cmdthem.ExecuteNonQuery();

          
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có giáo viên nào được thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvGVCN.DataSource = LoadDanhSachGiaoVien();
        }

        private void btnxoagv_Click(object sender, EventArgs e)
        {         
            try
            {
                conn.Open();
                SqlCommand cmdthem = new SqlCommand("sp_XoaGiaoVien", conn);
                cmdthem.CommandType = CommandType.StoredProcedure;
                cmdthem.Connection = conn;
                SqlParameter parmagv = new SqlParameter("@magiaovien", txtmagv.Text);
                cmdthem.Parameters.Add(parmagv);

                int rowsAffected = cmdthem.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoá giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có giáo viên nào được xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvGVCN.DataSource = LoadDanhSachGiaoVien();
        }

        private void btnsuagv_Click(object sender, EventArgs e)
        {
            //DateTime ngaysinh = DateTime.ParseExact(dtpngaysinhgv.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            try
            {
                conn.Open();
                SqlCommand cmdSua = new SqlCommand("sp_SuaGVCN", conn);
                cmdSua.CommandType = CommandType.StoredProcedure;
                cmdSua.Connection = conn;
                SqlParameter parmagv = new SqlParameter("@magiaovien", txtmagv.Text);
                SqlParameter parhoten = new SqlParameter("@hoten", txthotengv.Text);
                SqlParameter parngaysinh = new SqlParameter("@ngaysinh", dtpngaysinhgv.Value);
                SqlParameter pargioitinh = new SqlParameter("@gioitinh", SqlDbType.NVarChar, 10);
                pargioitinh.Value = rdonamgv.Checked ? "Nam" : "Nữ";
                SqlParameter pardiachi = new SqlParameter("@diachi", txtdiachigv.Text);
                SqlParameter pardienthoai = new SqlParameter("@dienthoai", txtsodtgv.Text);
                SqlParameter paremail = new SqlParameter("@email", txtemail.Text);
                SqlParameter parmonhoc = new SqlParameter("@mongiangday", cbMonHoc.SelectedValue);
                cmdSua.Parameters.Add(parmagv);
                cmdSua.Parameters.Add(parhoten);
                cmdSua.Parameters.Add(parngaysinh);
                cmdSua.Parameters.Add(pargioitinh);
                cmdSua.Parameters.Add(pardiachi);
                cmdSua.Parameters.Add(pardienthoai);
                cmdSua.Parameters.Add(paremail);
                cmdSua.Parameters.Add(parmonhoc);

                int rowsAffected = cmdSua.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có giáo viên nào được sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvGVCN.DataSource = LoadDanhSachGiaoVien();
        }

        private void btnthoatgv_Click(object sender, EventArgs e)
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

        private void btntimkiemhs_Click(object sender, EventArgs e)
        {

        }
    }
}
