using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class DAfrmNhapdiem : Form
    {


        public DAfrmNhapdiem()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");


        //private DataTable LayDanhSachDiem()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("LayDanhSachDiem", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return dt;
        //}
        private DataTable LayDanhSachDiem()
        {
            DataTable dt = new DataTable();
            bool kiemtraketnoi = conn.State == ConnectionState.Open; 

            try
            {
                if (!kiemtraketnoi) conn.Open(); // Chỉ mở nếu chưa mở
                SqlCommand cmd = new SqlCommand("LayDanhSachDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!kiemtraketnoi && conn.State == ConnectionState.Open)
                    conn.Close(); // Chỉ đóng nếu nó được mở trong hàm này
            }

            return dt;
        }




        private void dgvNhapDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = dgvNhapDiem.CurrentCell.RowIndex;
            cbHocSinh.SelectedValue = dgvNhapDiem.Rows[rows].Cells[0].Value.ToString();
            cbLop.SelectedValue = dgvNhapDiem.Rows[rows].Cells[1].Value.ToString();
            cbMonHoc.SelectedValue = dgvNhapDiem.Rows[rows].Cells[2].Value.ToString();
            cbHK.Text = dgvNhapDiem.Rows[rows].Cells[3].Value.ToString();
            txtDiemmieng.Text = dgvNhapDiem.Rows[rows].Cells[4].Value.ToString();
            txtDiem15P.Text = dgvNhapDiem.Rows[rows].Cells[5].Value.ToString();
            txtDiem1tiet.Text = dgvNhapDiem.Rows[rows].Cells[6].Value.ToString();
            txtDiemThi.Text = dgvNhapDiem.Rows[rows].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(cbHocSinh.Text) || string.IsNullOrWhiteSpace(cbMonHoc.Text) ||
                    string.IsNullOrWhiteSpace(cbHK.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                decimal diemMieng, diem15P, diem1Tiet, diemThi;
                if (!decimal.TryParse(txtDiemmieng.Text, out diemMieng) || diemMieng < 0 || diemMieng > 10)
                {
                    MessageBox.Show("Điểm miệng phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtDiem15P.Text, out diem15P) || diem15P < 0 || diem15P > 10)
                {
                    MessageBox.Show("Điểm 15 phút phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtDiem1tiet.Text, out diem1Tiet) || diem1Tiet < 0 || diem1Tiet > 10)
                {
                    MessageBox.Show("Điểm 1 tiết phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtDiemThi.Text, out diemThi) || diemThi < 0 || diemThi > 10)
                {
                    MessageBox.Show("Điểm thi phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var (diemtk, xepLoai) = TinhDiemTongKet();
                conn.Open();
                SqlCommand cmdThem = new SqlCommand("sp_ThemDiem", conn);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.Parameters.AddWithValue("@mahocsinh", cbHocSinh.SelectedValue);
                cmdThem.Parameters.AddWithValue("@malop", cbLop.SelectedValue);
                cmdThem.Parameters.AddWithValue("@mamonhoc", cbMonHoc.SelectedValue);
                cmdThem.Parameters.AddWithValue("@hocky", cbHK.SelectedItem);
                cmdThem.Parameters.AddWithValue("@diemmieng", diemMieng);
                cmdThem.Parameters.AddWithValue("@Diem15phut", diem15P);
                cmdThem.Parameters.AddWithValue("@diem1tiet", diem1Tiet);
                cmdThem.Parameters.AddWithValue("@diemtongket", diemtk);
                cmdThem.Parameters.AddWithValue("@diemhocky", diemThi);
                cmdThem.Parameters.AddWithValue("@xeploai", xepLoai);
                if (cmdThem.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm điểm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dgvNhapDiem.DataSource = LayDanhSachDiem();
        }



        private (decimal diemTongKet, string xepLoai) TinhDiemTongKet()
        {
            try
            {
                decimal diemMieng = decimal.Parse(txtDiemmieng.Text);
                decimal diem15Phut = decimal.Parse(txtDiem15P.Text);
                decimal diem1Tiet = decimal.Parse(txtDiem1tiet.Text);
                decimal diemHocKy = decimal.Parse(txtDiemThi.Text);

                decimal diemTongKet = (diemMieng + diem15Phut + diem1Tiet + diemHocKy) / 4;

                diemTongKet = (decimal)Math.Round(diemTongKet, 2);
                txttongdiem.Text = diemTongKet.ToString("F2"); 


                string xepLoai = "";
                if (diemTongKet >= 8)
                    xepLoai = "Giỏi";
                else if (diemTongKet >= 6.5m)
                    xepLoai = "Khá";
                else if (diemTongKet >= 5)
                    xepLoai = "Trung bình";
                else
                    xepLoai = "Yếu";

                txtxeploai.Text = xepLoai;
                return (diemTongKet, xepLoai);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đủ điểm!");
                return (0, "");
            }
        }



        private void DAfrmNhapdiem_Load(object sender, EventArgs e)
        {
            cbHocSinh.DataSource = LayDSHocSinh();
            cbHocSinh.DisplayMember = "HoTen";
            cbHocSinh.ValueMember = "MaHocSinh";


            cbLop.DataSource = LayDSLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";


            cbMonHoc.DataSource = laydsmonhoc();
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "MaMonHoc";


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



            dgvNhapDiem.DataSource = LayDanhSachDiem();
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

        private void button1_Click(object sender, EventArgs e)
        {
            TinhDiemTongKet();
        }

        private void cbHK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parxoa = new SqlParameter("@mahocsinh", cbHocSinh.SelectedValue);
                SqlParameter parmamonhoc = new SqlParameter("@mamonhoc",cbMonHoc.SelectedValue);
                cmd.Parameters.Add(parxoa);
                cmd.Parameters.Add(parmamonhoc);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không  thành công!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvNhapDiem.DataSource = LayDanhSachDiem();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(cbHocSinh.Text) || string.IsNullOrWhiteSpace(cbMonHoc.Text) ||
                    string.IsNullOrWhiteSpace(cbHK.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                float diemMieng, diem15P, diem1Tiet, diemThi;
                if (!float.TryParse(txtDiemmieng.Text, out diemMieng) || diemMieng < 0 || diemMieng > 10)
                {
                    MessageBox.Show("Điểm miệng phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtDiem15P.Text, out diem15P) || diem15P < 0 || diem15P > 10)
                {
                    MessageBox.Show("Điểm 15 phút phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtDiem1tiet.Text, out diem1Tiet) || diem1Tiet < 0 || diem1Tiet > 10)
                {
                    MessageBox.Show("Điểm 1 tiết phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtDiemThi.Text, out diemThi) || diemThi < 0 || diemThi > 10)
                {
                    MessageBox.Show("Điểm thi phải là số trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var (diemtk, xepLoai) = TinhDiemTongKet();
                conn.Open();
                SqlCommand cmdThem = new SqlCommand("sp_SuaDiem", conn);
                cmdThem.CommandType = CommandType.StoredProcedure;

                cmdThem.Parameters.AddWithValue("@mahocsinh", cbHocSinh.SelectedValue);
                cmdThem.Parameters.AddWithValue("@malop", cbLop.SelectedValue);
                cmdThem.Parameters.AddWithValue("@mamonhoc", cbMonHoc.SelectedValue);
                cmdThem.Parameters.AddWithValue("@hocky", cbHK.SelectedItem);
                cmdThem.Parameters.AddWithValue("@diemmieng", diemMieng);
                cmdThem.Parameters.AddWithValue("@Diem15phut", diem15P);
                cmdThem.Parameters.AddWithValue("@diem1tiet", diem1Tiet);
                cmdThem.Parameters.AddWithValue("@diemtongket", diemtk);
                cmdThem.Parameters.AddWithValue("@diemhocky", diemThi);
                cmdThem.Parameters.AddWithValue("@xeploai", xepLoai);
                if (cmdThem.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa điểm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dgvNhapDiem.DataSource = LayDanhSachDiem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void btntimkiemlop_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkiemhocsinhtheoma", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parhoten = new SqlParameter("@mahocsinh", txttimkiemlop.Text);

                cmd.Parameters.Add(parhoten);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
              
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    dgvNhapDiem.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh!: " + txttimkiemlop.Text , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhapDiem.DataSource = LayDanhSachDiem();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}






