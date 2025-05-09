namespace FormQuanLyHocSinh
{
    partial class DAFrmLopHoc
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
            this.btnthoatlop = new System.Windows.Forms.Button();
            this.btnaddlop = new System.Windows.Forms.Button();
            this.btnxoalop = new System.Windows.Forms.Button();
            this.btnsualop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGVCN = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSlophoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntimkiemlop = new System.Windows.Forms.Button();
            this.txttimkiemlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttonglop = new System.Windows.Forms.TextBox();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSlophoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 627);
            this.panel1.TabIndex = 0;
            // 
            // btnthoatlop
            // 
            this.btnthoatlop.BackColor = System.Drawing.Color.Red;
            this.btnthoatlop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoatlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatlop.ForeColor = System.Drawing.Color.White;
            this.btnthoatlop.Location = new System.Drawing.Point(158, 136);
            this.btnthoatlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatlop.Name = "btnthoatlop";
            this.btnthoatlop.Size = new System.Drawing.Size(175, 39);
            this.btnthoatlop.TabIndex = 13;
            this.btnthoatlop.Text = "Thoát";
            this.btnthoatlop.UseVisualStyleBackColor = false;
            this.btnthoatlop.Click += new System.EventHandler(this.btnthoatlop_Click);
            // 
            // btnaddlop
            // 
            this.btnaddlop.BackColor = System.Drawing.Color.Teal;
            this.btnaddlop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddlop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddlop.ForeColor = System.Drawing.Color.White;
            this.btnaddlop.Location = new System.Drawing.Point(158, 89);
            this.btnaddlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddlop.Name = "btnaddlop";
            this.btnaddlop.Size = new System.Drawing.Size(175, 39);
            this.btnaddlop.TabIndex = 16;
            this.btnaddlop.Text = " Thêm Lớp";
            this.btnaddlop.UseVisualStyleBackColor = false;
            this.btnaddlop.Click += new System.EventHandler(this.btnaddlop_Click);
            // 
            // btnxoalop
            // 
            this.btnxoalop.BackColor = System.Drawing.Color.Teal;
            this.btnxoalop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoalop.ForeColor = System.Drawing.Color.White;
            this.btnxoalop.Location = new System.Drawing.Point(339, 136);
            this.btnxoalop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoalop.Name = "btnxoalop";
            this.btnxoalop.Size = new System.Drawing.Size(175, 39);
            this.btnxoalop.TabIndex = 15;
            this.btnxoalop.Text = "Xoá Lớp";
            this.btnxoalop.UseVisualStyleBackColor = false;
            this.btnxoalop.Click += new System.EventHandler(this.btnxoalop_Click);
            // 
            // btnsualop
            // 
            this.btnsualop.BackColor = System.Drawing.Color.Teal;
            this.btnsualop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsualop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsualop.ForeColor = System.Drawing.Color.White;
            this.btnsualop.Location = new System.Drawing.Point(339, 89);
            this.btnsualop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsualop.Name = "btnsualop";
            this.btnsualop.Size = new System.Drawing.Size(175, 39);
            this.btnsualop.TabIndex = 14;
            this.btnsualop.Text = "Sửa lớp";
            this.btnsualop.UseVisualStyleBackColor = false;
            this.btnsualop.Click += new System.EventHandler(this.btnsualop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGVCN);
            this.groupBox1.Controls.Add(this.cbKhoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttenlop);
            this.groupBox1.Controls.Add(this.txtmalop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(345, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // cbGVCN
            // 
            this.cbGVCN.FormattingEnabled = true;
            this.cbGVCN.Location = new System.Drawing.Point(110, 212);
            this.cbGVCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGVCN.Name = "cbGVCN";
            this.cbGVCN.Size = new System.Drawing.Size(217, 28);
            this.cbGVCN.TabIndex = 14;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(110, 164);
            this.cbKhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 28);
            this.cbKhoi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "GVCN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khối Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(110, 109);
            this.txttenlop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(217, 26);
            this.txttenlop.TabIndex = 11;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(110, 56);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(217, 26);
            this.txtmalop.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSlophoc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(363, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(858, 330);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Lớp Học";
            // 
            // dgvDSlophoc
            // 
            this.dgvDSlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSlophoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDSlophoc.Location = new System.Drawing.Point(3, 21);
            this.dgvDSlophoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSlophoc.Name = "dgvDSlophoc";
            this.dgvDSlophoc.RowHeadersWidth = 62;
            this.dgvDSlophoc.RowTemplate.Height = 28;
            this.dgvDSlophoc.Size = new System.Drawing.Size(852, 309);
            this.dgvDSlophoc.TabIndex = 0;
            this.dgvDSlophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSlophoc_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnthoatlop);
            this.panel2.Controls.Add(this.btnaddlop);
            this.panel2.Controls.Add(this.btntimkiemlop);
            this.panel2.Controls.Add(this.btnxoalop);
            this.panel2.Controls.Add(this.txttimkiemlop);
            this.panel2.Controls.Add(this.btnsualop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txttonglop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(363, 334);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 293);
            this.panel2.TabIndex = 13;
            // 
            // btntimkiemlop
            // 
            this.btntimkiemlop.Location = new System.Drawing.Point(685, 44);
            this.btntimkiemlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiemlop.Name = "btntimkiemlop";
            this.btntimkiemlop.Size = new System.Drawing.Size(84, 28);
            this.btntimkiemlop.TabIndex = 3;
            this.btntimkiemlop.Text = "Tìm Kiếm";
            this.btntimkiemlop.UseVisualStyleBackColor = true;
            // 
            // txttimkiemlop
            // 
            this.txttimkiemlop.Location = new System.Drawing.Point(370, 45);
            this.txttimkiemlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiemlop.Name = "txttimkiemlop";
            this.txttimkiemlop.Size = new System.Drawing.Size(299, 26);
            this.txttimkiemlop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng";
            // 
            // txttonglop
            // 
            this.txttonglop.Location = new System.Drawing.Point(73, 46);
            this.txttonglop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttonglop.Name = "txttonglop";
            this.txttonglop.Size = new System.Drawing.Size(100, 26);
            this.txttonglop.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "@NineGroup - 2024";
            // 
            // DAFrmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1221, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DAFrmLopHoc";
            this.Text = "DAFrmLopHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DAFrmLopHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSlophoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Button btnthoatlop;
        private System.Windows.Forms.Button btnsualop;
        private System.Windows.Forms.Button btnxoalop;
        private System.Windows.Forms.Button btnaddlop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSlophoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntimkiemlop;
        private System.Windows.Forms.TextBox txttimkiemlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttonglop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGVCN;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label5;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private System.Windows.Forms.Label label10;
    }
}