using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLyHocSinh
{
    public partial class mainf : Form
    {
        public mainf()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile("D:\\DoAnQuanlyHocSinhTHPT\\DoAnQuanlyHocSinhTHPT\background.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

       

        private void btnmonhoc_Click(object sender, EventArgs e)
        {
           
        }

      

      

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thôngTinMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           

        }

        private void thôngTinKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timkiemsv tk = new timkiemsv();
            tk.MdiParent = this;
            tk.Show();
        }

        private void lblxinchao_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmHocSinh hs = new DAfrmHocSinh();
            hs.MdiParent = this;
            hs.Show();
        }

        private void mainf_Load(object sender, EventArgs e)
        {

        }

        private void quảnLíGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmGVCN gv = new DAfrmGVCN();
            gv.MdiParent = this;
            gv.Show();
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAFrmLopHoc lh = new DAFrmLopHoc();
            lh.MdiParent= this;
            lh.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmMonHoc mh = new DAfrmMonHoc();
            mh.MdiParent = this;
            mh.Show();
        }

        private void điểmSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmNhapdiem diem = new DAfrmNhapdiem();
            diem.MdiParent = this;
            diem.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hl = new HelpForm();
            hl.MdiParent = this;
            hl.Show();
        }
    }
    }

