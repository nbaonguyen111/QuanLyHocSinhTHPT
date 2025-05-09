using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace FormQuanLyHocSinh
{
    public partial class DAFrmReport : Form
    {
        public DAFrmReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void DAFrmReport_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CrystalReport1 rp = new CrystalReport1();
            ParameterValues parameterValues = new ParameterValues();
            ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
            paravalue.Value = txttimkiem.Text;
            parameterValues.Add(paravalue);
            rp.SetParameterValue("Author", "Nhóm 9");
            rp.DataDefinition.ParameterFields["@mahocsinh"].ApplyCurrentValues(parameterValues);
            crys.ReportSource = rp;
            crys.Refresh();
        }
    }
}
