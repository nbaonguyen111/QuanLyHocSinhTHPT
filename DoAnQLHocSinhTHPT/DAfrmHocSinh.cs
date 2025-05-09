using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLyHocSinh
{
    public partial class DAfrmHocSinh : Form
    {
        public DAfrmHocSinh()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=SHRIMP\\NGANH;Initial Catalog=DOANQLHSTHPT;Integrated Security=True");

        private void DAfrmHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = LayDSHocSinh();
            //Lấy lớp
            cblop.DataSource = LayDSLop();
            cblop.DisplayMember = "TenLop";
            cblop.ValueMember = "MaLop";
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

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            int rows = dgvHocSinh.CurrentCell.RowIndex;
            txtmahocsinh.Text = dgvHocSinh.Rows[rows].Cells[0].Value.ToString();
            txthotenhocsinh.Text = dgvHocSinh.Rows[rows].Cells[1].Value.ToString();
            dtpngaysinhhs.Text = dgvHocSinh.Rows[rows].Cells[2].Value.ToString();
            if (rdonamhs.Checked = dgvHocSinh.Rows[rows].Cells[3].Value.ToString() == "Nam")
            {
                rdonamhs.Checked = true;
            }
            else
            {
                rdonuhs.Checked = true;
            }
            txtdiachihs.Text = dgvHocSinh.Rows[rows].Cells[4].Value.ToString();
            txtsodths.Text = dgvHocSinh.Rows[rows].Cells[5].Value.ToString();
            cblop.SelectedValue = dgvHocSinh.Rows[rows].Cells[6].Value.ToString();
                if (dgvHocSinh.Rows[rows].Cells[7].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])dgvHocSinh.Rows[rows].Cells[7].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pictureBoxHinhAnh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxHinhAnh.Image = null; // Nếu không có hình ảnh, bỏ trống PictureBox
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnthoaths_Click(object sender, EventArgs e)
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

        private void btnaddhs_Click(object sender, EventArgs e)
        {
            //DateTime ngaysinh = DateTime.ParseExact(dtpngaysinhhs.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            try
            {
                
                    conn.Open();
                    SqlCommand cmdthem = new SqlCommand("sp_ThemHocSinh", conn);
                    cmdthem.CommandType = CommandType.StoredProcedure;
                    cmdthem.Connection = conn;
                    SqlParameter parmagv = new SqlParameter("@mahocsinh", txtmahocsinh.Text);
                    SqlParameter parhoten = new SqlParameter("@hoten", txthotenhocsinh.Text);
                    SqlParameter parngaysinh = new SqlParameter("@ngaysinh", dtpngaysinhhs.Value);
                    SqlParameter pargioitinh = new SqlParameter("@gioitinh", SqlDbType.NVarChar, 10);
                    pargioitinh.Value = rdonamhs.Checked ? "Nam" : "Nữ";
                    SqlParameter pardiachi = new SqlParameter("@diachi", txtdiachihs.Text);
                    SqlParameter pardienthoai = new SqlParameter("@dienthoai", txtsodths.Text);
                    SqlParameter parlop = new SqlParameter("@malop", cblop.SelectedValue);
                SqlParameter parhinhanh = new SqlParameter("@hinhanh", getImage());
                cmdthem.Parameters.Add(parmagv);
                    cmdthem.Parameters.Add(parhoten);
                    cmdthem.Parameters.Add(parngaysinh);
                    cmdthem.Parameters.Add(pargioitinh);
                    cmdthem.Parameters.Add(pardiachi);
                    cmdthem.Parameters.Add(pardienthoai);
                    cmdthem.Parameters.Add(parlop);
                cmdthem.Parameters.Add(parhinhanh);

                    int dong = cmdthem.ExecuteNonQuery();


                    if (dong > 0)
                    {
                        MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có học sinh nào được thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvHocSinh.DataSource = LayDSHocSinh();
        }
        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxHinhAnh.Image.Save(stream, pictureBoxHinhAnh.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void btnxoahs_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdthem = new SqlCommand("sp_XoaHocSinh", conn);
                cmdthem.CommandType = CommandType.StoredProcedure;
                cmdthem.Connection = conn;
                SqlParameter parmagv = new SqlParameter("@mahocsinh", txtmahocsinh.Text);
                cmdthem.Parameters.Add(parmagv);

                int dong = cmdthem.ExecuteNonQuery();


                if (dong > 0)
                {
                    MessageBox.Show("Xoá học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có học sinh nào được xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvHocSinh.DataSource = LayDSHocSinh();
        }

        private void btnsuahs_Click(object sender, EventArgs e)
        {
            //DateTime ngaysinh = DateTime.ParseExact(dtpngaysinhhs.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            try
            {
                conn.Open();
                SqlCommand cmdthem = new SqlCommand("sp_SuaHocSinh", conn);
                cmdthem.CommandType = CommandType.StoredProcedure;
                cmdthem.Connection = conn;
                SqlParameter parmagv = new SqlParameter("@mahocsinh", txtmahocsinh.Text);
                SqlParameter parhoten = new SqlParameter("@hoten", txthotenhocsinh.Text);
                SqlParameter parngaysinh = new SqlParameter("@ngaysinh", dtpngaysinhhs.Value);
                SqlParameter pargioitinh = new SqlParameter("@gioitinh", SqlDbType.NVarChar, 10);
                pargioitinh.Value = rdonamhs.Checked ? "Nam" : "Nữ";
                SqlParameter pardiachi = new SqlParameter("@diachi", txtdiachihs.Text);
                SqlParameter pardienthoai = new SqlParameter("@dienthoai", txtsodths.Text);
                SqlParameter parlop = new SqlParameter("@malop", cblop.SelectedValue);
                SqlParameter parhinhanh = new SqlParameter("@hinhanh", getImage());
                cmdthem.Parameters.Add(parmagv);
                cmdthem.Parameters.Add(parhoten);
                cmdthem.Parameters.Add(parngaysinh);
                cmdthem.Parameters.Add(pargioitinh);
                cmdthem.Parameters.Add(pardiachi);
                cmdthem.Parameters.Add(pardienthoai);
                cmdthem.Parameters.Add(parlop);
                cmdthem.Parameters.Add(parhinhanh);

                int dong = cmdthem.ExecuteNonQuery();


                if (dong > 0)
                {
                    MessageBox.Show("Sửa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có học sinh nào được sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvHocSinh.DataSource = LayDSHocSinh();
        }

        //private void btntimkiemhs_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("timkiemhocsinh", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter parhoten = new SqlParameter("@hoten", txthotenhocsinh.Text);
        //        SqlParameter parmahs = new SqlParameter("@mahocsinh", txtmahocsinh.Text);
        //        cmd.Parameters.Add(parhoten);
        //        cmd.Parameters.Add(parmahs);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            dgvHocSinh.DataSource = dt; 
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không tìm thấy học sinh nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            dgvHocSinh.DataSource = null; 
        //        }
        //    }
        //    catch(Exception ex) 
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    dgvHocSinh.datas
        //}
        private void btntimkiemhs_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkiemhocsinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

               
                SqlParameter parhoten = new SqlParameter("@hoten", txttimkiemhs.Text);
           
                cmd.Parameters.Add(parhoten);
             
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

             
                if (dt.Rows.Count > 0)
                {
                    dgvHocSinh.DataSource = dt; 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHocSinh.DataSource = LayDSHocSinh(); 
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
        }

        private void pictureBoxHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog  = new OpenFileDialog();
            if(openfiledialog.ShowDialog()==DialogResult.OK)
            {
                pictureBoxHinhAnh.Image= new Bitmap(openfiledialog.FileName);
            }
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
