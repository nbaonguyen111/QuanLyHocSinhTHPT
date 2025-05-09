namespace FormQuanLyHocSinh
{
    partial class DAfrmDiemDanh
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
            this.dgvdiemdanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbHocSinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntimkiemlop = new System.Windows.Forms.Button();
            this.txttimkiemlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttonglop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemdanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdiemdanh
            // 
            this.dgvdiemdanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdiemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemdanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvdiemdanh.Location = new System.Drawing.Point(363, 0);
            this.dgvdiemdanh.Name = "dgvdiemdanh";
            this.dgvdiemdanh.RowHeadersWidth = 62;
            this.dgvdiemdanh.RowTemplate.Height = 28;
            this.dgvdiemdanh.Size = new System.Drawing.Size(858, 274);
            this.dgvdiemdanh.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Red;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(315, 208);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(175, 39);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(134, 208);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(175, 39);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(134, 154);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(175, 39);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(315, 154);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(175, 39);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpDiemDanh);
            this.panel1.Controls.Add(this.cbtrangthai);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.cbHocSinh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 627);
            this.panel1.TabIndex = 16;
            // 
            // dtpDiemDanh
            // 
            this.dtpDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiemDanh.Location = new System.Drawing.Point(192, 197);
            this.dtpDiemDanh.Name = "dtpDiemDanh";
            this.dtpDiemDanh.Size = new System.Drawing.Size(165, 26);
            this.dtpDiemDanh.TabIndex = 25;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Có Mặt",
            "Vắng Mặt",
            "Muộn"});
            this.cbtrangthai.Location = new System.Drawing.Point(136, 246);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(185, 28);
            this.cbtrangthai.TabIndex = 24;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(116, 155);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(165, 28);
            this.cbLop.TabIndex = 24;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbHocSinh
            // 
            this.cbHocSinh.FormattingEnabled = true;
            this.cbHocSinh.Location = new System.Drawing.Point(116, 105);
            this.cbHocSinh.Name = "cbHocSinh";
            this.cbHocSinh.Size = new System.Drawing.Size(199, 28);
            this.cbHocSinh.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(21, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 32);
            this.label10.TabIndex = 23;
            this.label10.Text = "@NineGroup - 2024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Điểm Danh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btntimkiemlop);
            this.panel2.Controls.Add(this.txttimkiemlop);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.txttonglop);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(363, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 348);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // DAfrmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvdiemdanh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DAfrmDiemDanh";
            this.Text = "DAfrmDiemDanh";
            this.Load += new System.EventHandler(this.DAfrmDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemdanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiemdanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntimkiemlop;
        private System.Windows.Forms.TextBox txttimkiemlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttonglop;
        private System.Windows.Forms.DateTimePicker dtpDiemDanh;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbHocSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}