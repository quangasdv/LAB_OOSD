namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLichHen
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpThongTinHen = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDanDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioHen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.btnLamMoiBoLoc = new System.Windows.Forms.Button();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXacNhanDenKham = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTinHen.SuspendLayout();
            this.grpLoc.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1034, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ LỊCH HẸN TÁI KHÁM & KHÁM ĐỊNH KỲ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinHen
            // 
            this.grpThongTinHen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinHen.Controls.Add(this.cboTrangThai);
            this.grpThongTinHen.Controls.Add(this.label7);
            this.grpThongTinHen.Controls.Add(this.txtDanDo);
            this.grpThongTinHen.Controls.Add(this.label6);
            this.grpThongTinHen.Controls.Add(this.txtNoiDung);
            this.grpThongTinHen.Controls.Add(this.label5);
            this.grpThongTinHen.Controls.Add(this.cboGioHen);
            this.grpThongTinHen.Controls.Add(this.label4);
            this.grpThongTinHen.Controls.Add(this.dtpNgayHen);
            this.grpThongTinHen.Controls.Add(this.label3);
            this.grpThongTinHen.Controls.Add(this.cboBacSi);
            this.grpThongTinHen.Controls.Add(this.label2);
            this.grpThongTinHen.Controls.Add(this.cboHoSo);
            this.grpThongTinHen.Controls.Add(this.label1);
            this.grpThongTinHen.Controls.Add(this.txtMaLichHen);
            this.grpThongTinHen.Controls.Add(this.label8);
            this.grpThongTinHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinHen.Location = new System.Drawing.Point(12, 53);
            this.grpThongTinHen.Name = "grpThongTinHen";
            this.grpThongTinHen.Size = new System.Drawing.Size(1010, 150);
            this.grpThongTinHen.TabIndex = 1;
            this.grpThongTinHen.TabStop = false;
            this.grpThongTinHen.Text = "Chi tiết lịch hẹn khám";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chưa đến hẹn",
            "Đã đến khám",
            "Quá hạn/Hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(825, 60);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(170, 24);
            this.cboTrangThai.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trạng thái:";
            // 
            // txtDanDo
            // 
            this.txtDanDo.Location = new System.Drawing.Point(115, 105);
            this.txtDanDo.Name = "txtDanDo";
            this.txtDanDo.Size = new System.Drawing.Size(880, 24);
            this.txtDanDo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dặn dò chuẩn bị:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(115, 60);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(610, 24);
            this.txtNoiDung.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nội dung khám:";
            // 
            // cboGioHen
            // 
            this.cboGioHen.FormattingEnabled = true;
            this.cboGioHen.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00"});
            this.cboGioHen.Location = new System.Drawing.Point(905, 23);
            this.cboGioHen.Name = "cboGioHen";
            this.cboGioHen.Size = new System.Drawing.Size(90, 24);
            this.cboGioHen.TabIndex = 9;
            this.cboGioHen.Text = "08:30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ hẹn:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHen.Location = new System.Drawing.Point(715, 23);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(120, 24);
            this.dtpNgayHen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày hẹn:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(455, 23);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(180, 24);
            this.cboBacSi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bác sĩ hẹn:";
            // 
            // cboHoSo
            // 
            this.cboHoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSo.FormattingEnabled = true;
            this.cboHoSo.Location = new System.Drawing.Point(195, 23);
            this.cboHoSo.Name = "cboHoSo";
            this.cboHoSo.Size = new System.Drawing.Size(170, 24);
            this.cboHoSo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hồ sơ:";
            // 
            // txtMaLichHen
            // 
            this.txtMaLichHen.Location = new System.Drawing.Point(62, 23);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.ReadOnly = true;
            this.txtMaLichHen.Size = new System.Drawing.Size(75, 24);
            this.txtMaLichHen.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã LH:";
            // 
            // grpLoc
            // 
            this.grpLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoc.Controls.Add(this.btnLamMoiBoLoc);
            this.grpLoc.Controls.Add(this.cboLocTrangThai);
            this.grpLoc.Controls.Add(this.label9);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoc.Location = new System.Drawing.Point(12, 209);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(1010, 58);
            this.grpLoc.TabIndex = 2;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "Bộ lọc tìm kiếm";
            // 
            // btnLamMoiBoLoc
            // 
            this.btnLamMoiBoLoc.Location = new System.Drawing.Point(340, 20);
            this.btnLamMoiBoLoc.Name = "btnLamMoiBoLoc";
            this.btnLamMoiBoLoc.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoiBoLoc.TabIndex = 2;
            this.btnLamMoiBoLoc.Text = "Làm mới lọc";
            this.btnLamMoiBoLoc.UseVisualStyleBackColor = true;
            this.btnLamMoiBoLoc.Click += new System.EventHandler(this.btnLamMoiBoLoc_Click);
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa đến hẹn",
            "Đã đến khám",
            "Quá hạn/Hủy"});
            this.cboLocTrangThai.Location = new System.Drawing.Point(135, 22);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(185, 24);
            this.cboLocTrangThai.TabIndex = 1;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lọc theo trạng thái:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvLichHen);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.Location = new System.Drawing.Point(12, 273);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1010, 355);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách lịch hẹn tái khám & khám định kỳ";
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AllowUserToAddRows = false;
            this.dgvLichHen.AllowUserToDeleteRows = false;
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(3, 20);
            this.dgvLichHen.MultiSelect = false;
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.RowHeadersVisible = false;
            this.dgvLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHen.Size = new System.Drawing.Size(1004, 332);
            this.dgvLichHen.TabIndex = 0;
            this.dgvLichHen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHen_CellClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.Location = new System.Drawing.Point(12, 638);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 32);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Hẹn mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(123, 638);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu lịch hẹn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXacNhanDenKham
            // 
            this.btnXacNhanDenKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXacNhanDenKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDenKham.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnXacNhanDenKham.Location = new System.Drawing.Point(249, 638);
            this.btnXacNhanDenKham.Name = "btnXacNhanDenKham";
            this.btnXacNhanDenKham.Size = new System.Drawing.Size(160, 32);
            this.btnXacNhanDenKham.TabIndex = 6;
            this.btnXacNhanDenKham.Text = "✓ Đã đến khám";
            this.btnXacNhanDenKham.UseVisualStyleBackColor = true;
            this.btnXacNhanDenKham.Click += new System.EventHandler(this.btnXacNhanDenKham_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(415, 638);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Hủy lịch hẹn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(922, 638);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 682);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXacNhanDenKham);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpThongTinHen);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch hẹn tái khám & khám định kỳ";
            this.Load += new System.EventHandler(this.FrmLichHen_Load);
            this.grpThongTinHen.ResumeLayout(false);
            this.grpThongTinHen.PerformLayout();
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpThongTinHen;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboHoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGioHen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDanDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLamMoiBoLoc;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXacNhanDenKham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
    }
}
