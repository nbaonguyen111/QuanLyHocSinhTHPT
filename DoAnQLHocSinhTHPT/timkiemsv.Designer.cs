namespace FormQuanLyHocSinh
{
    partial class timkiemsv
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
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtimkiemma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvtimkiem.Location = new System.Drawing.Point(0, 0);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.RowHeadersWidth = 62;
            this.dgvtimkiem.RowTemplate.Height = 28;
            this.dgvtimkiem.Size = new System.Drawing.Size(800, 303);
            this.dgvtimkiem.TabIndex = 0;
            this.dgvtimkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtimkiem_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm Sinh Viên";
            // 
            // cbtimkiemma
            // 
            this.cbtimkiemma.FormattingEnabled = true;
            this.cbtimkiemma.Location = new System.Drawing.Point(27, 340);
            this.cbtimkiemma.Name = "cbtimkiemma";
            this.cbtimkiemma.Size = new System.Drawing.Size(140, 28);
            this.cbtimkiemma.TabIndex = 4;
            // 
            // timkiemsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 812);
            this.Controls.Add(this.cbtimkiemma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtimkiem);
            this.Name = "timkiemsv";
            this.Text = "timkiemsv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.timkiemsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtimkiemma;
    }
}