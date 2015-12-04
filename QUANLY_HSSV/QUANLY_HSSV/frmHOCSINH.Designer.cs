namespace QUANLY_HSSV
{
    partial class frmHOCSINH
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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu_HS = new System.Windows.Forms.Button();
            this.btnXoa_HS = new System.Windows.Forms.Button();
            this.btnSua_HS = new System.Windows.Forms.Button();
            this.btnThem_HS = new System.Windows.Forms.Button();
            this.cbTK_HS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTK_HS = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh_HS = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbGT_HS = new System.Windows.Forms.ComboBox();
            this.txtHoTen_HS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMa_HS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Tìm kiếm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnThoat);
            this.groupBox4.Controls.Add(this.btnLuu_HS);
            this.groupBox4.Controls.Add(this.btnXoa_HS);
            this.groupBox4.Controls.Add(this.btnSua_HS);
            this.groupBox4.Controls.Add(this.btnThem_HS);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(647, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 164);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(118, 116);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 34);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu_HS
            // 
            this.btnLuu_HS.Location = new System.Drawing.Point(24, 116);
            this.btnLuu_HS.Name = "btnLuu_HS";
            this.btnLuu_HS.Size = new System.Drawing.Size(82, 34);
            this.btnLuu_HS.TabIndex = 69;
            this.btnLuu_HS.Text = "Lưu";
            this.btnLuu_HS.UseVisualStyleBackColor = true;
            this.btnLuu_HS.Click += new System.EventHandler(this.btnLuu_HS_Click);
            // 
            // btnXoa_HS
            // 
            this.btnXoa_HS.Location = new System.Drawing.Point(118, 16);
            this.btnXoa_HS.Name = "btnXoa_HS";
            this.btnXoa_HS.Size = new System.Drawing.Size(82, 34);
            this.btnXoa_HS.TabIndex = 68;
            this.btnXoa_HS.Text = "Xóa";
            this.btnXoa_HS.UseVisualStyleBackColor = true;
            this.btnXoa_HS.Click += new System.EventHandler(this.btnXoa_HS_Click);
            // 
            // btnSua_HS
            // 
            this.btnSua_HS.Location = new System.Drawing.Point(24, 64);
            this.btnSua_HS.Name = "btnSua_HS";
            this.btnSua_HS.Size = new System.Drawing.Size(82, 34);
            this.btnSua_HS.TabIndex = 67;
            this.btnSua_HS.Text = "Sửa";
            this.btnSua_HS.UseVisualStyleBackColor = true;
            this.btnSua_HS.Click += new System.EventHandler(this.btnSua_HS_Click);
            // 
            // btnThem_HS
            // 
            this.btnThem_HS.Location = new System.Drawing.Point(24, 16);
            this.btnThem_HS.Name = "btnThem_HS";
            this.btnThem_HS.Size = new System.Drawing.Size(82, 34);
            this.btnThem_HS.TabIndex = 66;
            this.btnThem_HS.Text = "Thêm";
            this.btnThem_HS.UseVisualStyleBackColor = true;
            this.btnThem_HS.Click += new System.EventHandler(this.btnThem_HS_Click);
            // 
            // cbTK_HS
            // 
            this.cbTK_HS.FormattingEnabled = true;
            this.cbTK_HS.Items.AddRange(new object[] {
            "Mã",
            "Họ Tên"});
            this.cbTK_HS.Location = new System.Drawing.Point(107, 19);
            this.cbTK_HS.Name = "cbTK_HS";
            this.cbTK_HS.Size = new System.Drawing.Size(177, 21);
            this.cbTK_HS.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dgvHocSinh);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 249);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column7});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 16);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.ReadOnly = true;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(904, 230);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MAHS";
            this.Column1.FillWeight = 396.9072F;
            this.Column1.HeaderText = "Mã HS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TENHS";
            this.Column2.FillWeight = 25.77319F;
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "NS";
            this.Column4.FillWeight = 25.77319F;
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "GT";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "DIACHI";
            this.Column5.FillWeight = 25.77319F;
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "MALOP";
            this.Column7.FillWeight = 25.77319F;
            this.Column7.HeaderText = "Mã Lớp";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtTK_HS
            // 
            this.txtTK_HS.Location = new System.Drawing.Point(340, 20);
            this.txtTK_HS.Name = "txtTK_HS";
            this.txtTK_HS.Size = new System.Drawing.Size(238, 20);
            this.txtTK_HS.TabIndex = 64;
            this.txtTK_HS.TextChanged += new System.EventHandler(this.txtTK_HS_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(401, 27);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(177, 20);
            this.txtDiaChi.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Địa Chỉ";
            // 
            // dtpNgaySinh_HS
            // 
            this.dtpNgaySinh_HS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh_HS.Location = new System.Drawing.Point(107, 128);
            this.dtpNgaySinh_HS.Name = "dtpNgaySinh_HS";
            this.dtpNgaySinh_HS.Size = new System.Drawing.Size(177, 20);
            this.dtpNgaySinh_HS.TabIndex = 54;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(401, 74);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(177, 21);
            this.cbLop.TabIndex = 53;
            // 
            // cbGT_HS
            // 
            this.cbGT_HS.FormattingEnabled = true;
            this.cbGT_HS.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbGT_HS.Location = new System.Drawing.Point(401, 127);
            this.cbGT_HS.Name = "cbGT_HS";
            this.cbGT_HS.Size = new System.Drawing.Size(177, 21);
            this.cbGT_HS.TabIndex = 52;
            // 
            // txtHoTen_HS
            // 
            this.txtHoTen_HS.Location = new System.Drawing.Point(107, 75);
            this.txtHoTen_HS.Name = "txtHoTen_HS";
            this.txtHoTen_HS.Size = new System.Drawing.Size(177, 20);
            this.txtHoTen_HS.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Ngày Sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Giới Tính";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Họ Tên";
            // 
            // txtMa_HS
            // 
            this.txtMa_HS.Enabled = false;
            this.txtMa_HS.Location = new System.Drawing.Point(107, 27);
            this.txtMa_HS.Name = "txtMa_HS";
            this.txtMa_HS.Size = new System.Drawing.Size(177, 20);
            this.txtMa_HS.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Mã HS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTK_HS);
            this.groupBox3.Controls.Add(this.cbTK_HS);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(910, 60);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgaySinh_HS);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.cbGT_HS);
            this.groupBox1.Controls.Add(this.txtHoTen_HS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMa_HS);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 183);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(118, 64);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 34);
            this.btnHuy.TabIndex = 71;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmHOCSINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHOCSINH";
            this.Text = "HỌC SINH";
            this.Load += new System.EventHandler(this.frmHOCSINH_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu_HS;
        private System.Windows.Forms.Button btnXoa_HS;
        private System.Windows.Forms.Button btnSua_HS;
        private System.Windows.Forms.Button btnThem_HS;
        private System.Windows.Forms.ComboBox cbTK_HS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.TextBox txtTK_HS;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh_HS;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbGT_HS;
        private System.Windows.Forms.TextBox txtHoTen_HS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMa_HS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnHuy;
    }
}