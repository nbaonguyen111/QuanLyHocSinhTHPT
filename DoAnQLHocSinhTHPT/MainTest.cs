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
    public partial class MainTest : Form
    {
        public MainTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DAfrmHocSinh hs = new DAfrmHocSinh();
            hs.MdiParent = this;
            hs.Show();
        }

        private void giáoVieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmGVCN gv = new DAfrmGVCN();
            gv.MdiParent = this;
            gv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmHocSinh hs = new DAfrmHocSinh();
            hs.MdiParent = this;
            hs.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAFrmLopHoc lop = new DAFrmLopHoc();
            lop.MdiParent = this;
            lop.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmMonHoc mh = new DAfrmMonHoc();
            mh.MdiParent = this;
            mh.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmNhapdiem nd = new DAfrmNhapdiem();
            nd.MdiParent = this;
            nd.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAfrmDiemDanh dd = new DAfrmDiemDanh();
            dd.MdiParent= this;
            dd.Show();
        }

        private void MainTest_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void xuấtPhiếuĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAFrmReport rp = new DAFrmReport();
            rp.MdiParent = this;
            rp.Show();
        }
    }
}
