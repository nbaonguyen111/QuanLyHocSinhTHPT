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
using WindowsFormsApp1;

namespace FormQuanLyHocSinh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        public void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtmatkhau.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                Processingbar mn = new Processingbar();
                mn.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        public string getuesername()
        {
            return txtusername.Text;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
