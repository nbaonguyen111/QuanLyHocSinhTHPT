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
    public partial class timkiemsv : Form
    {
        public timkiemsv()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        private void timkiemsv_Load(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = LoadDuLieuSinhVien();
            cbtimkiemma.DataSource = LoadDuLieuSinhVien();
            cbtimkiemma.DisplayMember = "MaSV";
            cbtimkiemma.ValueMember = "MaSV";
        }
        private DataTable TimKiem()
        {
            DataTable dtfind = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdtimkiem = new SqlCommand();
                cmdtimkiem.CommandText = "sp_timkiemsinhvien";
                cmdtimkiem.CommandType = CommandType.StoredProcedure;
                cmdtimkiem.Connection = conn;
                SqlParameter parmasv = new SqlParameter("@masv", SqlDbType.NVarChar);
                parmasv.Value = cbtimkiemma.SelectedValue.ToString(); 
                cmdtimkiem.Parameters.Add(parmasv);
                SqlDataAdapter datatimkiem = new SqlDataAdapter(cmdtimkiem);
                datatimkiem.Fill(dtfind);
                return dtfind;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtfind;
        }

        private DataTable LoadDuLieuSinhVien()
        {
            DataTable dtSinhvien = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdsinhvien = new SqlCommand();
                cmdsinhvien.CommandText = "sp_danhsachsinhvien";
                cmdsinhvien.CommandType = CommandType.StoredProcedure;
                cmdsinhvien.Connection = conn;
                SqlDataAdapter datasinhvien = new SqlDataAdapter(cmdsinhvien);
                datasinhvien.Fill(dtSinhvien);
                return dtSinhvien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhvien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = TimKiem();
        }

        private void dgvtimkiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
