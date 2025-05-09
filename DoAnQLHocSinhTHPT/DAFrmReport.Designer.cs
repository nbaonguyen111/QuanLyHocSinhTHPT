namespace FormQuanLyHocSinh
{
    partial class DAFrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crys = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 71);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập Mã Học Sinh";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(576, 21);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(93, 31);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "In";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(355, 21);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(181, 26);
            this.txttimkiem.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crys);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 551);
            this.panel2.TabIndex = 4;
            // 
            // crys
            // 
            this.crys.ActiveViewIndex = -1;
            this.crys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crys.Cursor = System.Windows.Forms.Cursors.Default;
            this.crys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crys.Location = new System.Drawing.Point(0, 0);
            this.crys.Name = "crys";
            this.crys.Size = new System.Drawing.Size(1196, 551);
            this.crys.TabIndex = 0;
            // 
            // DAFrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DAFrmReport";
            this.Text = "DAFrmReport";
            this.Load += new System.EventHandler(this.DAFrmReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crys;
    }
}