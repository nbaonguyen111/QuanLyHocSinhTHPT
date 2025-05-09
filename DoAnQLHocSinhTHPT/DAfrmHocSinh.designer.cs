namespace FormQuanLyHocSinh
{
    partial class DAfrmHocSinh
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
            this.btntimkiemhs = new System.Windows.Forms.Button();
            this.txttimkiemhs = new System.Windows.Forms.TextBox();
            this.txttonghs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthotenhocsinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.rdonuhs = new System.Windows.Forms.RadioButton();
            this.rdonamhs = new System.Windows.Forms.RadioButton();
            this.dtpngaysinhhs = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsodths = new System.Windows.Forms.TextBox();
            this.txtdiachihs = new System.Windows.Forms.TextBox();
            this.txtmahocsinh = new System.Windows.Forms.TextBox();
            this.btnthoaths = new System.Windows.Forms.Button();
            this.btnaddhs = new System.Windows.Forms.Button();
            this.btnxoahs = new System.Windows.Forms.Button();
            this.btnsuahs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnanh = new System.Windows.Forms.Button();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiemhs
            // 
            this.btntimkiemhs.Location = new System.Drawing.Point(685, 44);
            this.btntimkiemhs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiemhs.Name = "btntimkiemhs";
            this.btntimkiemhs.Size = new System.Drawing.Size(84, 28);
            this.btntimkiemhs.TabIndex = 3;
            this.btntimkiemhs.Text = "Tìm Kiếm";
            this.btntimkiemhs.UseVisualStyleBackColor = true;
            this.btntimkiemhs.Click += new System.EventHandler(this.btntimkiemhs_Click);
            // 
            // txttimkiemhs
            // 
            this.txttimkiemhs.Location = new System.Drawing.Point(370, 45);
            this.txttimkiemhs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiemhs.Name = "txttimkiemhs";
            this.txttimkiemhs.Size = new System.Drawing.Size(299, 26);
            this.txttimkiemhs.TabIndex = 2;
            // 
            // txttonghs
            // 
            this.txttonghs.Location = new System.Drawing.Point(73, 46);
            this.txttonghs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttonghs.Name = "txttonghs";
            this.txttonghs.Size = new System.Drawing.Size(100, 26);
            this.txttonghs.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnthoaths);
            this.panel2.Controls.Add(this.btnanh);
            this.panel2.Controls.Add(this.btntimkiemhs);
            this.panel2.Controls.Add(this.btnaddhs);
            this.panel2.Controls.Add(this.txttimkiemhs);
            this.panel2.Controls.Add(this.btnxoahs);
            this.panel2.Controls.Add(this.btnsuahs);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txttonghs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(363, 330);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 297);
            this.panel2.TabIndex = 17;
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
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 21);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 62;
            this.dgvHocSinh.RowTemplate.Height = 28;
            this.dgvHocSinh.Size = new System.Drawing.Size(852, 309);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHocSinh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(363, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(858, 334);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày Sinh";
            // 
            // txthotenhocsinh
            // 
            this.txthotenhocsinh.Location = new System.Drawing.Point(110, 62);
            this.txthotenhocsinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthotenhocsinh.Name = "txthotenhocsinh";
            this.txthotenhocsinh.Size = new System.Drawing.Size(217, 26);
            this.txthotenhocsinh.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cblop);
            this.groupBox1.Controls.Add(this.rdonuhs);
            this.groupBox1.Controls.Add(this.rdonamhs);
            this.groupBox1.Controls.Add(this.dtpngaysinhhs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsodths);
            this.groupBox1.Controls.Add(this.txtdiachihs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmahocsinh);
            this.groupBox1.Controls.Add(this.txthotenhocsinh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(345, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(122, 274);
            this.cblop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 28);
            this.cblop.TabIndex = 0;
            // 
            // rdonuhs
            // 
            this.rdonuhs.AutoSize = true;
            this.rdonuhs.ForeColor = System.Drawing.Color.Teal;
            this.rdonuhs.Location = new System.Drawing.Point(186, 144);
            this.rdonuhs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdonuhs.Name = "rdonuhs";
            this.rdonuhs.Size = new System.Drawing.Size(56, 24);
            this.rdonuhs.TabIndex = 14;
            this.rdonuhs.TabStop = true;
            this.rdonuhs.Text = "Nữ";
            this.rdonuhs.UseVisualStyleBackColor = true;
            // 
            // rdonamhs
            // 
            this.rdonamhs.AutoSize = true;
            this.rdonamhs.ForeColor = System.Drawing.Color.Teal;
            this.rdonamhs.Location = new System.Drawing.Point(110, 144);
            this.rdonamhs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdonamhs.Name = "rdonamhs";
            this.rdonamhs.Size = new System.Drawing.Size(70, 24);
            this.rdonamhs.TabIndex = 14;
            this.rdonamhs.TabStop = true;
            this.rdonamhs.Text = "Nam";
            this.rdonamhs.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinhhs
            // 
            this.dtpngaysinhhs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinhhs.Location = new System.Drawing.Point(114, 100);
            this.dtpngaysinhhs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngaysinhhs.Name = "dtpngaysinhhs";
            this.dtpngaysinhhs.Size = new System.Drawing.Size(218, 26);
            this.dtpngaysinhhs.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(6, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(6, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = " Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã Học Sinh";
            // 
            // txtsodths
            // 
            this.txtsodths.Location = new System.Drawing.Point(122, 234);
            this.txtsodths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsodths.Name = "txtsodths";
            this.txtsodths.Size = new System.Drawing.Size(217, 26);
            this.txtsodths.TabIndex = 12;
            // 
            // txtdiachihs
            // 
            this.txtdiachihs.Location = new System.Drawing.Point(122, 192);
            this.txtdiachihs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdiachihs.Name = "txtdiachihs";
            this.txtdiachihs.Size = new System.Drawing.Size(217, 26);
            this.txtdiachihs.TabIndex = 12;
            // 
            // txtmahocsinh
            // 
            this.txtmahocsinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtmahocsinh.ForeColor = System.Drawing.Color.Teal;
            this.txtmahocsinh.Location = new System.Drawing.Point(135, 26);
            this.txtmahocsinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmahocsinh.Name = "txtmahocsinh";
            this.txtmahocsinh.Size = new System.Drawing.Size(192, 26);
            this.txtmahocsinh.TabIndex = 12;
            this.txtmahocsinh.UseWaitCursor = true;
            // 
            // btnthoaths
            // 
            this.btnthoaths.BackColor = System.Drawing.Color.Red;
            this.btnthoaths.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoaths.ForeColor = System.Drawing.Color.White;
            this.btnthoaths.Location = new System.Drawing.Point(280, 120);
            this.btnthoaths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoaths.Name = "btnthoaths";
            this.btnthoaths.Size = new System.Drawing.Size(201, 43);
            this.btnthoaths.TabIndex = 13;
            this.btnthoaths.Text = "Thoát";
            this.btnthoaths.UseVisualStyleBackColor = false;
            this.btnthoaths.Click += new System.EventHandler(this.btnthoaths_Click);
            // 
            // btnaddhs
            // 
            this.btnaddhs.BackColor = System.Drawing.Color.Teal;
            this.btnaddhs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddhs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddhs.ForeColor = System.Drawing.Color.White;
            this.btnaddhs.Location = new System.Drawing.Point(72, 120);
            this.btnaddhs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddhs.Name = "btnaddhs";
            this.btnaddhs.Size = new System.Drawing.Size(202, 42);
            this.btnaddhs.TabIndex = 16;
            this.btnaddhs.Text = "Thêm học sinh";
            this.btnaddhs.UseVisualStyleBackColor = false;
            this.btnaddhs.Click += new System.EventHandler(this.btnaddhs_Click);
            // 
            // btnxoahs
            // 
            this.btnxoahs.BackColor = System.Drawing.Color.Teal;
            this.btnxoahs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoahs.ForeColor = System.Drawing.Color.White;
            this.btnxoahs.Location = new System.Drawing.Point(73, 170);
            this.btnxoahs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoahs.Name = "btnxoahs";
            this.btnxoahs.Size = new System.Drawing.Size(201, 44);
            this.btnxoahs.TabIndex = 15;
            this.btnxoahs.Text = "Xoá học sinh";
            this.btnxoahs.UseVisualStyleBackColor = false;
            this.btnxoahs.Click += new System.EventHandler(this.btnxoahs_Click);
            // 
            // btnsuahs
            // 
            this.btnsuahs.BackColor = System.Drawing.Color.Teal;
            this.btnsuahs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuahs.ForeColor = System.Drawing.Color.White;
            this.btnsuahs.Location = new System.Drawing.Point(280, 171);
            this.btnsuahs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuahs.Name = "btnsuahs";
            this.btnsuahs.Size = new System.Drawing.Size(201, 43);
            this.btnsuahs.TabIndex = 14;
            this.btnsuahs.Text = "Sửa học sinh";
            this.btnsuahs.UseVisualStyleBackColor = false;
            this.btnsuahs.Click += new System.EventHandler(this.btnsuahs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBoxHinhAnh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 627);
            this.panel1.TabIndex = 14;
            // 
            // btnanh
            // 
            this.btnanh.Location = new System.Drawing.Point(497, 117);
            this.btnanh.Name = "btnanh";
            this.btnanh.Size = new System.Drawing.Size(115, 48);
            this.btnanh.TabIndex = 19;
            this.btnanh.Text = "Chọn Ảnh";
            this.btnanh.UseVisualStyleBackColor = true;
            this.btnanh.Click += new System.EventHandler(this.btnanh_Click);
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHinhAnh.Image = global::FormQuanLyHocSinh.Properties.Resources.images;
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(112, 8);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(116, 136);
            this.pictureBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhAnh.TabIndex = 18;
            this.pictureBoxHinhAnh.TabStop = false;
            this.pictureBoxHinhAnh.Click += new System.EventHandler(this.pictureBoxHinhAnh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(26, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "@NineGroup - 2024";
            // 
            // DAfrmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DAfrmHocSinh";
            this.Text = "DAfrmHocSinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DAfrmHocSinh_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntimkiemhs;
        private System.Windows.Forms.TextBox txttimkiemhs;
        private System.Windows.Forms.TextBox txttonghs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthotenhocsinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoaths;
        private System.Windows.Forms.Button btnaddhs;
        private System.Windows.Forms.Button btnxoahs;
        private System.Windows.Forms.Button btnsuahs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdonuhs;
        private System.Windows.Forms.RadioButton rdonamhs;
        private System.Windows.Forms.DateTimePicker dtpngaysinhhs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsodths;
        private System.Windows.Forms.TextBox txtdiachihs;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmahocsinh;
        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private System.Windows.Forms.Button btnanh;
        private System.Windows.Forms.Label label8;
    }
}