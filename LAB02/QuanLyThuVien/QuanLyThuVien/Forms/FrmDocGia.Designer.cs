namespace QuanLyThuVien.Forms
{
    partial class FrmDocGia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.chkLePhi = new System.Windows.Forms.CheckBox();
            this.dtHan = new System.Windows.Forms.DateTimePicker();
            this.lblHan = new System.Windows.Forms.Label();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.lblPhai = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnDong);
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnGiaHan);
            this.pnlTop.Controls.Add(this.btnCapThe);
            this.pnlTop.Controls.Add(this.btnCapNhat);
            this.pnlTop.Controls.Add(this.btnThem);
            this.pnlTop.Controls.Add(this.chkLePhi);
            this.pnlTop.Controls.Add(this.dtHan);
            this.pnlTop.Controls.Add(this.lblHan);
            this.pnlTop.Controls.Add(this.dtNgayCap);
            this.pnlTop.Controls.Add(this.lblNgayCap);
            this.pnlTop.Controls.Add(this.txtAnh);
            this.pnlTop.Controls.Add(this.lblAnh);
            this.pnlTop.Controls.Add(this.txtEmail);
            this.pnlTop.Controls.Add(this.lblEmail);
            this.pnlTop.Controls.Add(this.txtDiaChi);
            this.pnlTop.Controls.Add(this.lblDiaChi);
            this.pnlTop.Controls.Add(this.txtSDT);
            this.pnlTop.Controls.Add(this.lblSDT);
            this.pnlTop.Controls.Add(this.cboPhai);
            this.pnlTop.Controls.Add(this.lblPhai);
            this.pnlTop.Controls.Add(this.dtNgaySinh);
            this.pnlTop.Controls.Add(this.lblNgaySinh);
            this.pnlTop.Controls.Add(this.txtTen);
            this.pnlTop.Controls.Add(this.lblTen);
            this.pnlTop.Controls.Add(this.txtHo);
            this.pnlTop.Controls.Add(this.lblHo);
            this.pnlTop.Controls.Add(this.txtMa);
            this.pnlTop.Controls.Add(this.lblMa);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1190, 250);
            this.pnlTop.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(850, 195);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 38);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(710, 195);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 38);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(570, 195);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(120, 38);
            this.btnGiaHan.TabIndex = 26;
            this.btnGiaHan.Text = "Gia hạn thẻ";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnCapThe
            // 
            this.btnCapThe.Location = new System.Drawing.Point(430, 195);
            this.btnCapThe.Name = "btnCapThe";
            this.btnCapThe.Size = new System.Drawing.Size(120, 38);
            this.btnCapThe.TabIndex = 25;
            this.btnCapThe.Text = "Cấp thẻ mới";
            this.btnCapThe.UseVisualStyleBackColor = true;
            this.btnCapThe.Click += new System.EventHandler(this.btnCapThe_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(260, 195);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(150, 38);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật độc giả";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 38);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm độc giả";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkLePhi
            // 
            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Location = new System.Drawing.Point(820, 150);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(193, 25);
            this.chkLePhi.TabIndex = 22;
            this.chkLePhi.Text = "Đã đóng lệ phí thường niên";
            this.chkLePhi.UseVisualStyleBackColor = true;
            // 
            // dtHan
            // 
            this.dtHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHan.Location = new System.Drawing.Point(540, 148);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(200, 29);
            this.dtHan.TabIndex = 21;
            // 
            // lblHan
            // 
            this.lblHan.AutoSize = true;
            this.lblHan.Location = new System.Drawing.Point(420, 151);
            this.lblHan.Name = "lblHan";
            this.lblHan.Size = new System.Drawing.Size(102, 21);
            this.lblHan.TabIndex = 20;
            this.lblHan.Text = "Hạn sử dụng:";
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayCap.Location = new System.Drawing.Point(130, 148);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(220, 29);
            this.dtNgayCap.TabIndex = 19;
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(20, 151);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(106, 21);
            this.lblNgayCap.TabIndex = 18;
            this.lblNgayCap.Text = "Ngày cấp thẻ:";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(820, 105);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(320, 29);
            this.txtAnh.TabIndex = 17;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(740, 108);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(69, 21);
            this.lblAnh.TabIndex = 16;
            this.lblAnh.Text = "Ảnh 3x4:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(500, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 29);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(420, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 105);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 29);
            this.txtDiaChi.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 108);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 21);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(820, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 29);
            this.txtSDT.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(740, 63);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 21);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "SĐT:";
            // 
            // cboPhai
            // 
            this.cboPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Location = new System.Drawing.Point(500, 60);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(150, 29);
            this.cboPhai.TabIndex = 9;
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(420, 63);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(43, 21);
            this.lblPhai.TabIndex = 8;
            this.lblPhai.Text = "Phái:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(100, 60);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(180, 29);
            this.dtNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 63);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 21);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(820, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 29);
            this.txtTen.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(740, 18);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 21);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(500, 15);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(200, 29);
            this.txtHo.TabIndex = 3;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(420, 18);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(33, 21);
            this.lblHo.TabIndex = 2;
            this.lblHo.Text = "Họ:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(100, 15);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(180, 29);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 18);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(61, 21);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã ĐG:";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(0, 250);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(1190, 540);
            this.dgvDocGia.TabIndex = 1;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            // 
            // FrmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 790);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Độc giả và thẻ";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.Label lblHan;
        private System.Windows.Forms.DateTimePicker dtHan;
        private System.Windows.Forms.CheckBox chkLePhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvDocGia;
    }
}
