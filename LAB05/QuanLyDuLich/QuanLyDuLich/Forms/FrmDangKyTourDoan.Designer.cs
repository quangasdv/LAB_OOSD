namespace QuanLyDuLich.Forms
{
    partial class FrmDangKyTourDoan
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
            this.lblSub = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpPhieu = new System.Windows.Forms.GroupBox();
            this.lblCanhBaoSoNguoi = new System.Windows.Forms.Label();
            this.lblThongTinTour = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.txtDiemDon = new System.Windows.Forms.TextBox();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.grpDoan = new System.Windows.Forms.GroupBox();
            this.txtDiaChiDoan = new System.Windows.Forms.TextBox();
            this.lblDiaChiDoan = new System.Windows.Forms.Label();
            this.txtDienThoaiDoan = new System.Windows.Forms.TextBox();
            this.lblDienThoaiDoan = new System.Windows.Forms.Label();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.lblNguoiDaiDien = new System.Windows.Forms.Label();
            this.cboDoan = new System.Windows.Forms.ComboBox();
            this.lblDoan = new System.Windows.Forms.Label();
            this.grpThemDoan = new System.Windows.Forms.GroupBox();
            this.txtEmailMoi = new System.Windows.Forms.TextBox();
            this.lblEmailMoi = new System.Windows.Forms.Label();
            this.txtSDTMoi = new System.Windows.Forms.TextBox();
            this.lblSDTMoi = new System.Windows.Forms.Label();
            this.txtDiaChiMoi = new System.Windows.Forms.TextBox();
            this.lblDiaChiMoi = new System.Windows.Forms.Label();
            this.btnThemDoanMoi = new System.Windows.Forms.Button();
            this.txtNguoiDDMoi = new System.Windows.Forms.TextBox();
            this.lblNguoiDDMoi = new System.Windows.Forms.Label();
            this.txtTenDoanMoi = new System.Windows.Forms.TextBox();
            this.lblTenDoanMoi = new System.Windows.Forms.Label();
            this.grpBaoHiem = new System.Windows.Forms.GroupBox();
            this.chkCoBaoHiem = new System.Windows.Forms.CheckBox();
            this.pnlBaoHiem = new System.Windows.Forms.Panel();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnXoaTV = new System.Windows.Forms.Button();
            this.btnThemTV = new System.Windows.Forms.Button();
            this.txtCCCDTV = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.dtpNgaySinhTV = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTenTV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoiForm = new System.Windows.Forms.Button();
            this.btnXacNhanLapPhieu = new System.Windows.Forms.Button();
            this.lblCamKet = new System.Windows.Forms.Label();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.lblHTTT = new System.Windows.Forms.Label();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.lblTitleCoc = new System.Windows.Forms.Label();
            this.lblTongKinhPhi = new System.Windows.Forms.Label();
            this.lblTitleTong = new System.Windows.Forms.Label();
            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.lblSoThanhVienDaLuu = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.grpPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            this.grpDoan.SuspendLayout();
            this.grpThemDoan.SuspendLayout();
            this.grpBaoHiem.SuspendLayout();
            this.pnlBaoHiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            this.grpLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlTop.Controls.Add(this.lblSub);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1104, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSub.Location = new System.Drawing.Point(15, 34);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(730, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Quy định: Khách đoàn >= 12 người | Chọn ngày đi tùy ý | Điểm đón riêng | Đặt cọc 30% (mất cọc nếu hủy) | Danh sách bảo hiểm";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(13, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(465, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "LẬP PHIẾU ĐĂNG KÝ TOUR THEO ĐOÀN - VĂN HÓA VIỆT";
            // 
            // grpPhieu
            // 
            this.grpPhieu.Controls.Add(this.lblCanhBaoSoNguoi);
            this.grpPhieu.Controls.Add(this.lblThongTinTour);
            this.grpPhieu.Controls.Add(this.numSoNguoi);
            this.grpPhieu.Controls.Add(this.lblSoNguoi);
            this.grpPhieu.Controls.Add(this.txtDiemDon);
            this.grpPhieu.Controls.Add(this.lblDiemDon);
            this.grpPhieu.Controls.Add(this.dtpNgayDi);
            this.grpPhieu.Controls.Add(this.lblNgayDi);
            this.grpPhieu.Controls.Add(this.cboTour);
            this.grpPhieu.Controls.Add(this.lblTour);
            this.grpPhieu.Controls.Add(this.txtSoPhieu);
            this.grpPhieu.Controls.Add(this.lblSoPhieu);
            this.grpPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPhieu.Location = new System.Drawing.Point(12, 68);
            this.grpPhieu.Name = "grpPhieu";
            this.grpPhieu.Size = new System.Drawing.Size(530, 205);
            this.grpPhieu.TabIndex = 1;
            this.grpPhieu.TabStop = false;
            this.grpPhieu.Text = "1. Thông tin Phiếu & Hành trình Tour";
            // 
            // lblCanhBaoSoNguoi
            // 
            this.lblCanhBaoSoNguoi.AutoSize = true;
            this.lblCanhBaoSoNguoi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblCanhBaoSoNguoi.ForeColor = System.Drawing.Color.Green;
            this.lblCanhBaoSoNguoi.Location = new System.Drawing.Point(205, 175);
            this.lblCanhBaoSoNguoi.Name = "lblCanhBaoSoNguoi";
            this.lblCanhBaoSoNguoi.Size = new System.Drawing.Size(306, 15);
            this.lblCanhBaoSoNguoi.TabIndex = 11;
            this.lblCanhBaoSoNguoi.Text = "Hợp lệ: Đủ điều kiện đăng ký theo đoàn (>= 12 người).";
            // 
            // lblThongTinTour
            // 
            this.lblThongTinTour.AutoSize = true;
            this.lblThongTinTour.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblThongTinTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblThongTinTour.Location = new System.Drawing.Point(100, 83);
            this.lblThongTinTour.Name = "lblThongTinTour";
            this.lblThongTinTour.Size = new System.Drawing.Size(316, 15);
            this.lblThongTinTour.TabIndex = 4;
            this.lblThongTinTour.Text = "Thời lượng: ...  |  Đơn giá: ... đ/người  |  Xuất phát: TP.HCM";
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.numSoNguoi.Location = new System.Drawing.Point(100, 171);
            this.numSoNguoi.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(95, 24);
            this.numSoNguoi.TabIndex = 10;
            this.numSoNguoi.Value = new decimal(new int[] { 15, 0, 0, 0 });
            this.numSoNguoi.ValueChanged += new System.EventHandler(this.numSoNguoi_ValueChanged);
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(12, 174);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(57, 15);
            this.lblSoNguoi.TabIndex = 9;
            this.lblSoNguoi.Text = "Số người:";
            // 
            // txtDiemDon
            // 
            this.txtDiemDon.Location = new System.Drawing.Point(100, 139);
            this.txtDiemDon.Name = "txtDiemDon";
            this.txtDiemDon.Size = new System.Drawing.Size(415, 23);
            this.txtDiemDon.TabIndex = 8;
            this.txtDiemDon.Text = "Trụ sở cơ quan / Điểm hẹn riêng của đoàn";
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Location = new System.Drawing.Point(12, 142);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(61, 15);
            this.lblDiemDon.TabIndex = 7;
            this.lblDiemDon.Text = "Điểm đón:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(100, 106);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(180, 23);
            this.dtpNgayDi.TabIndex = 6;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(12, 110);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(51, 15);
            this.lblNgayDi.TabIndex = 5;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(100, 54);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(415, 23);
            this.cboTour.TabIndex = 3;
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.cboTour_SelectedIndexChanged);
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(12, 57);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(65, 15);
            this.lblTour.TabIndex = 2;
            this.lblTour.Text = "Chọn Tour:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoPhieu.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 22);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(200, 23);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(12, 25);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(56, 15);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // grpDoan
            // 
            this.grpDoan.Controls.Add(this.txtDiaChiDoan);
            this.grpDoan.Controls.Add(this.lblDiaChiDoan);
            this.grpDoan.Controls.Add(this.txtDienThoaiDoan);
            this.grpDoan.Controls.Add(this.lblDienThoaiDoan);
            this.grpDoan.Controls.Add(this.txtNguoiDaiDien);
            this.grpDoan.Controls.Add(this.lblNguoiDaiDien);
            this.grpDoan.Controls.Add(this.cboDoan);
            this.grpDoan.Controls.Add(this.lblDoan);
            this.grpDoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDoan.Location = new System.Drawing.Point(555, 68);
            this.grpDoan.Name = "grpDoan";
            this.grpDoan.Size = new System.Drawing.Size(535, 115);
            this.grpDoan.TabIndex = 2;
            this.grpDoan.TabStop = false;
            this.grpDoan.Text = "2. Thông tin Khách Đoàn (Cơ quan / Đại diện gia đình)";
            // 
            // txtDiaChiDoan
            // 
            this.txtDiaChiDoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiaChiDoan.Location = new System.Drawing.Point(100, 83);
            this.txtDiaChiDoan.Name = "txtDiaChiDoan";
            this.txtDiaChiDoan.ReadOnly = true;
            this.txtDiaChiDoan.Size = new System.Drawing.Size(420, 23);
            this.txtDiaChiDoan.TabIndex = 7;
            // 
            // lblDiaChiDoan
            // 
            this.lblDiaChiDoan.AutoSize = true;
            this.lblDiaChiDoan.Location = new System.Drawing.Point(12, 86);
            this.lblDiaChiDoan.Name = "lblDiaChiDoan";
            this.lblDiaChiDoan.Size = new System.Drawing.Size(46, 15);
            this.lblDiaChiDoan.TabIndex = 6;
            this.lblDiaChiDoan.Text = "Địa chỉ:";
            // 
            // txtDienThoaiDoan
            // 
            this.txtDienThoaiDoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDienThoaiDoan.Location = new System.Drawing.Point(365, 52);
            this.txtDienThoaiDoan.Name = "txtDienThoaiDoan";
            this.txtDienThoaiDoan.ReadOnly = true;
            this.txtDienThoaiDoan.Size = new System.Drawing.Size(155, 23);
            this.txtDienThoaiDoan.TabIndex = 5;
            // 
            // lblDienThoaiDoan
            // 
            this.lblDienThoaiDoan.AutoSize = true;
            this.lblDienThoaiDoan.Location = new System.Drawing.Point(298, 55);
            this.lblDienThoaiDoan.Name = "lblDienThoaiDoan";
            this.lblDienThoaiDoan.Size = new System.Drawing.Size(64, 15);
            this.lblDienThoaiDoan.TabIndex = 4;
            this.lblDienThoaiDoan.Text = "Điện thoại:";
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(100, 52);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.ReadOnly = true;
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(190, 23);
            this.txtNguoiDaiDien.TabIndex = 3;
            // 
            // lblNguoiDaiDien
            // 
            this.lblNguoiDaiDien.AutoSize = true;
            this.lblNguoiDaiDien.Location = new System.Drawing.Point(12, 55);
            this.lblNguoiDaiDien.Name = "lblNguoiDaiDien";
            this.lblNguoiDaiDien.Size = new System.Drawing.Size(86, 15);
            this.lblNguoiDaiDien.TabIndex = 2;
            this.lblNguoiDaiDien.Text = "Người đại diện:";
            // 
            // cboDoan
            // 
            this.cboDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoan.FormattingEnabled = true;
            this.cboDoan.Location = new System.Drawing.Point(100, 21);
            this.cboDoan.Name = "cboDoan";
            this.cboDoan.Size = new System.Drawing.Size(420, 23);
            this.cboDoan.TabIndex = 1;
            this.cboDoan.SelectedIndexChanged += new System.EventHandler(this.cboDoan_SelectedIndexChanged);
            // 
            // lblDoan
            // 
            this.lblDoan.AutoSize = true;
            this.lblDoan.Location = new System.Drawing.Point(12, 24);
            this.lblDoan.Name = "lblDoan";
            this.lblDoan.Size = new System.Drawing.Size(71, 15);
            this.lblDoan.TabIndex = 0;
            this.lblDoan.Text = "Chọn Đoàn:";
            // 
            // grpThemDoan
            // 
            this.grpThemDoan.Controls.Add(this.txtEmailMoi);
            this.grpThemDoan.Controls.Add(this.lblEmailMoi);
            this.grpThemDoan.Controls.Add(this.txtSDTMoi);
            this.grpThemDoan.Controls.Add(this.lblSDTMoi);
            this.grpThemDoan.Controls.Add(this.txtDiaChiMoi);
            this.grpThemDoan.Controls.Add(this.lblDiaChiMoi);
            this.grpThemDoan.Controls.Add(this.btnThemDoanMoi);
            this.grpThemDoan.Controls.Add(this.txtNguoiDDMoi);
            this.grpThemDoan.Controls.Add(this.lblNguoiDDMoi);
            this.grpThemDoan.Controls.Add(this.txtTenDoanMoi);
            this.grpThemDoan.Controls.Add(this.lblTenDoanMoi);
            this.grpThemDoan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.grpThemDoan.Location = new System.Drawing.Point(555, 189);
            this.grpThemDoan.Name = "grpThemDoan";
            this.grpThemDoan.Size = new System.Drawing.Size(535, 84);
            this.grpThemDoan.TabIndex = 3;
            this.grpThemDoan.TabStop = false;
            this.grpThemDoan.Text = "Tạo nhanh đoàn mới (nếu chưa có trong danh sách)";
            // 
            // txtEmailMoi
            // 
            this.txtEmailMoi.Location = new System.Drawing.Point(230, 52);
            this.txtEmailMoi.Name = "txtEmailMoi";
            this.txtEmailMoi.Size = new System.Drawing.Size(100, 23);
            this.txtEmailMoi.TabIndex = 7;
            // 
            // lblEmailMoi
            // 
            this.lblEmailMoi.AutoSize = true;
            this.lblEmailMoi.Location = new System.Drawing.Point(185, 55);
            this.lblEmailMoi.Name = "lblEmailMoi";
            this.lblEmailMoi.Size = new System.Drawing.Size(39, 15);
            this.lblEmailMoi.TabIndex = 6;
            this.lblEmailMoi.Text = "Email:";
            // 
            // txtSDTMoi
            // 
            this.txtSDTMoi.Location = new System.Drawing.Point(75, 52);
            this.txtSDTMoi.Name = "txtSDTMoi";
            this.txtSDTMoi.Size = new System.Drawing.Size(100, 23);
            this.txtSDTMoi.TabIndex = 5;
            // 
            // lblSDTMoi
            // 
            this.lblSDTMoi.AutoSize = true;
            this.lblSDTMoi.Location = new System.Drawing.Point(10, 55);
            this.lblSDTMoi.Name = "lblSDTMoi";
            this.lblSDTMoi.Size = new System.Drawing.Size(31, 15);
            this.lblSDTMoi.TabIndex = 4;
            this.lblSDTMoi.Text = "SĐT:";
            // 
            // txtDiaChiMoi
            // 
            this.txtDiaChiMoi.Location = new System.Drawing.Point(340, 23);
            this.txtDiaChiMoi.Name = "txtDiaChiMoi";
            this.txtDiaChiMoi.Size = new System.Drawing.Size(95, 23);
            this.txtDiaChiMoi.TabIndex = 3;
            // 
            // lblDiaChiMoi
            // 
            this.lblDiaChiMoi.AutoSize = true;
            this.lblDiaChiMoi.Location = new System.Drawing.Point(290, 26);
            this.lblDiaChiMoi.Name = "lblDiaChiMoi";
            this.lblDiaChiMoi.Size = new System.Drawing.Size(46, 15);
            this.lblDiaChiMoi.TabIndex = 2;
            this.lblDiaChiMoi.Text = "Địa chỉ:";
            // 
            // btnThemDoanMoi
            // 
            this.btnThemDoanMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemDoanMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDoanMoi.FlatAppearance.BorderSize = 0;
            this.btnThemDoanMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDoanMoi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThemDoanMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemDoanMoi.Location = new System.Drawing.Point(445, 23);
            this.btnThemDoanMoi.Name = "btnThemDoanMoi";
            this.btnThemDoanMoi.Size = new System.Drawing.Size(75, 52);
            this.btnThemDoanMoi.TabIndex = 10;
            this.btnThemDoanMoi.Text = "Lưu\r\nĐoàn";
            this.btnThemDoanMoi.UseVisualStyleBackColor = false;
            this.btnThemDoanMoi.Click += new System.EventHandler(this.btnThemDoanMoi_Click);
            // 
            // txtNguoiDDMoi
            // 
            this.txtNguoiDDMoi.Location = new System.Drawing.Point(340, 52);
            this.txtNguoiDDMoi.Name = "txtNguoiDDMoi";
            this.txtNguoiDDMoi.Size = new System.Drawing.Size(95, 23);
            this.txtNguoiDDMoi.TabIndex = 9;
            // 
            // lblNguoiDDMoi
            // 
            this.lblNguoiDDMoi.AutoSize = true;
            this.lblNguoiDDMoi.Location = new System.Drawing.Point(335, 55);
            this.lblNguoiDDMoi.Name = "lblNguoiDDMoi";
            this.lblNguoiDDMoi.Size = new System.Drawing.Size(0, 15);
            this.lblNguoiDDMoi.TabIndex = 8;
            // 
            // txtTenDoanMoi
            // 
            this.txtTenDoanMoi.Location = new System.Drawing.Point(75, 23);
            this.txtTenDoanMoi.Name = "txtTenDoanMoi";
            this.txtTenDoanMoi.Size = new System.Drawing.Size(200, 23);
            this.txtTenDoanMoi.TabIndex = 1;
            // 
            // lblTenDoanMoi
            // 
            this.lblTenDoanMoi.AutoSize = true;
            this.lblTenDoanMoi.Location = new System.Drawing.Point(10, 26);
            this.lblTenDoanMoi.Name = "lblTenDoanMoi";
            this.lblTenDoanMoi.Size = new System.Drawing.Size(59, 15);
            this.lblTenDoanMoi.TabIndex = 0;
            this.lblTenDoanMoi.Text = "Tên đoàn:";
            // 
            // grpBaoHiem
            // 
            this.grpBaoHiem.Controls.Add(this.chkCoBaoHiem);
            this.grpBaoHiem.Controls.Add(this.pnlBaoHiem);
            this.grpBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBaoHiem.Location = new System.Drawing.Point(12, 279);
            this.grpBaoHiem.Name = "grpBaoHiem";
            this.grpBaoHiem.Size = new System.Drawing.Size(650, 240);
            this.grpBaoHiem.TabIndex = 4;
            this.grpBaoHiem.TabStop = false;
            this.grpBaoHiem.Text = "3. Bảo hiểm du lịch & Danh sách thành viên cùng đi";
            // 
            // chkCoBaoHiem
            // 
            this.chkCoBaoHiem.AutoSize = true;
            this.chkCoBaoHiem.Checked = true;
            this.chkCoBaoHiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkCoBaoHiem.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkCoBaoHiem.Location = new System.Drawing.Point(15, 22);
            this.chkCoBaoHiem.Name = "chkCoBaoHiem";
            this.chkCoBaoHiem.Size = new System.Drawing.Size(434, 19);
            this.chkCoBaoHiem.TabIndex = 0;
            this.chkCoBaoHiem.Text = "Đoàn có mua bảo hiểm du lịch (Bắt buộc kèm danh sách thành viên cùng đi)";
            this.chkCoBaoHiem.UseVisualStyleBackColor = true;
            this.chkCoBaoHiem.CheckedChanged += new System.EventHandler(this.chkCoBaoHiem_CheckedChanged);
            // 
            // pnlBaoHiem
            // 
            this.pnlBaoHiem.Controls.Add(this.dgvThanhVien);
            this.pnlBaoHiem.Controls.Add(this.btnXoaTV);
            this.pnlBaoHiem.Controls.Add(this.btnThemTV);
            this.pnlBaoHiem.Controls.Add(this.txtCCCDTV);
            this.pnlBaoHiem.Controls.Add(this.lblCCCD);
            this.pnlBaoHiem.Controls.Add(this.dtpNgaySinhTV);
            this.pnlBaoHiem.Controls.Add(this.lblNgaySinh);
            this.pnlBaoHiem.Controls.Add(this.txtHoTenTV);
            this.pnlBaoHiem.Controls.Add(this.lblHoTen);
            this.pnlBaoHiem.Location = new System.Drawing.Point(10, 47);
            this.pnlBaoHiem.Name = "pnlBaoHiem";
            this.pnlBaoHiem.Size = new System.Drawing.Size(630, 185);
            this.pnlBaoHiem.TabIndex = 1;
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AllowUserToDeleteRows = false;
            this.dgvThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(5, 40);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.RowHeadersWidth = 25;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(620, 140);
            this.dgvThanhVien.TabIndex = 8;
            // 
            // btnXoaTV
            // 
            this.btnXoaTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTV.FlatAppearance.BorderSize = 0;
            this.btnXoaTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnXoaTV.ForeColor = System.Drawing.Color.White;
            this.btnXoaTV.Location = new System.Drawing.Point(565, 8);
            this.btnXoaTV.Name = "btnXoaTV";
            this.btnXoaTV.Size = new System.Drawing.Size(60, 26);
            this.btnXoaTV.TabIndex = 7;
            this.btnXoaTV.Text = "Xóa";
            this.btnXoaTV.UseVisualStyleBackColor = false;
            this.btnXoaTV.Click += new System.EventHandler(this.btnXoaTV_Click);
            // 
            // btnThemTV
            // 
            this.btnThemTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThemTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTV.FlatAppearance.BorderSize = 0;
            this.btnThemTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThemTV.ForeColor = System.Drawing.Color.White;
            this.btnThemTV.Location = new System.Drawing.Point(500, 8);
            this.btnThemTV.Name = "btnThemTV";
            this.btnThemTV.Size = new System.Drawing.Size(60, 26);
            this.btnThemTV.TabIndex = 6;
            this.btnThemTV.Text = "+ Thêm";
            this.btnThemTV.UseVisualStyleBackColor = false;
            this.btnThemTV.Click += new System.EventHandler(this.btnThemTV_Click);
            // 
            // txtCCCDTV
            // 
            this.txtCCCDTV.Location = new System.Drawing.Point(395, 10);
            this.txtCCCDTV.Name = "txtCCCDTV";
            this.txtCCCDTV.Size = new System.Drawing.Size(100, 23);
            this.txtCCCDTV.TabIndex = 5;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(350, 14);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(41, 15);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "CCCD:";
            // 
            // dtpNgaySinhTV
            // 
            this.dtpNgaySinhTV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhTV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhTV.Location = new System.Drawing.Point(245, 10);
            this.dtpNgaySinhTV.Name = "dtpNgaySinhTV";
            this.dtpNgaySinhTV.Size = new System.Drawing.Size(100, 23);
            this.dtpNgaySinhTV.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(180, 14);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTenTV
            // 
            this.txtHoTenTV.Location = new System.Drawing.Point(50, 10);
            this.txtHoTenTV.Name = "txtHoTenTV";
            this.txtHoTenTV.Size = new System.Drawing.Size(125, 23);
            this.txtHoTenTV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(2, 14);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.btnDong);
            this.grpThanhToan.Controls.Add(this.btnLamMoiForm);
            this.grpThanhToan.Controls.Add(this.btnXacNhanLapPhieu);
            this.grpThanhToan.Controls.Add(this.lblCamKet);
            this.grpThanhToan.Controls.Add(this.cboHinhThucTT);
            this.grpThanhToan.Controls.Add(this.lblHTTT);
            this.grpThanhToan.Controls.Add(this.lblTienCoc);
            this.grpThanhToan.Controls.Add(this.lblTitleCoc);
            this.grpThanhToan.Controls.Add(this.lblTongKinhPhi);
            this.grpThanhToan.Controls.Add(this.lblTitleTong);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpThanhToan.Location = new System.Drawing.Point(670, 279);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(420, 240);
            this.grpThanhToan.TabIndex = 5;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "4. Thông tin thanh toán đặt cọc (30%)";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(295, 195);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 35);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoiForm
            // 
            this.btnLamMoiForm.Location = new System.Drawing.Point(175, 195);
            this.btnLamMoiForm.Name = "btnLamMoiForm";
            this.btnLamMoiForm.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoiForm.TabIndex = 8;
            this.btnLamMoiForm.Text = "Làm mới";
            this.btnLamMoiForm.UseVisualStyleBackColor = true;
            this.btnLamMoiForm.Click += new System.EventHandler(this.btnLamMoiForm_Click);
            // 
            // btnXacNhanLapPhieu
            // 
            this.btnXacNhanLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnXacNhanLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanLapPhieu.FlatAppearance.BorderSize = 0;
            this.btnXacNhanLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanLapPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanLapPhieu.Location = new System.Drawing.Point(15, 145);
            this.btnXacNhanLapPhieu.Name = "btnXacNhanLapPhieu";
            this.btnXacNhanLapPhieu.Size = new System.Drawing.Size(395, 42);
            this.btnXacNhanLapPhieu.TabIndex = 7;
            this.btnXacNhanLapPhieu.Text = "XÁC NHẬN LẬP PHIẾU & THU TIỀN CỌC";
            this.btnXacNhanLapPhieu.UseVisualStyleBackColor = false;
            this.btnXacNhanLapPhieu.Click += new System.EventHandler(this.btnXacNhanLapPhieu_Click);
            // 
            // lblCamKet
            // 
            this.lblCamKet.AutoSize = true;
            this.lblCamKet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblCamKet.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCamKet.Location = new System.Drawing.Point(15, 120);
            this.lblCamKet.Name = "lblCamKet";
            this.lblCamKet.Size = new System.Drawing.Size(359, 13);
            this.lblCamKet.TabIndex = 6;
            this.lblCamKet.Text = "* Quy định cam kết: Khách đoàn hủy tour sẽ mất toàn bộ số tiền đã đặt cọc.";
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucTT.FormattingEnabled = true;
            this.cboHinhThucTT.Location = new System.Drawing.Point(150, 88);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(260, 23);
            this.cboHinhThucTT.TabIndex = 5;
            // 
            // lblHTTT
            // 
            this.lblHTTT.AutoSize = true;
            this.lblHTTT.Location = new System.Drawing.Point(15, 91);
            this.lblHTTT.Name = "lblHTTT";
            this.lblHTTT.Size = new System.Drawing.Size(125, 15);
            this.lblHTTT.TabIndex = 4;
            this.lblHTTT.Text = "Hình thức nộp cọc:";
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienCoc.ForeColor = System.Drawing.Color.Red;
            this.lblTienCoc.Location = new System.Drawing.Point(145, 55);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(61, 21);
            this.lblTienCoc.TabIndex = 3;
            this.lblTienCoc.Text = "0 VNĐ";
            // 
            // lblTitleCoc
            // 
            this.lblTitleCoc.AutoSize = true;
            this.lblTitleCoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleCoc.Location = new System.Drawing.Point(15, 58);
            this.lblTitleCoc.Name = "lblTitleCoc";
            this.lblTitleCoc.Size = new System.Drawing.Size(126, 17);
            this.lblTitleCoc.TabIndex = 2;
            this.lblTitleCoc.Text = "Tiền cọc 30% (BR):";
            // 
            // lblTongKinhPhi
            // 
            this.lblTongKinhPhi.AutoSize = true;
            this.lblTongKinhPhi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongKinhPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTongKinhPhi.Location = new System.Drawing.Point(145, 26);
            this.lblTongKinhPhi.Name = "lblTongKinhPhi";
            this.lblTongKinhPhi.Size = new System.Drawing.Size(56, 20);
            this.lblTongKinhPhi.TabIndex = 1;
            this.lblTongKinhPhi.Text = "0 VNĐ";
            // 
            // lblTitleTong
            // 
            this.lblTitleTong.AutoSize = true;
            this.lblTitleTong.Location = new System.Drawing.Point(15, 29);
            this.lblTitleTong.Name = "lblTitleTong";
            this.lblTitleTong.Size = new System.Drawing.Size(107, 15);
            this.lblTitleTong.TabIndex = 0;
            this.lblTitleTong.Text = "Tổng kinh phí tour:";
            // 
            // grpLichSu
            // 
            this.grpLichSu.Controls.Add(this.lblSoThanhVienDaLuu);
            this.grpLichSu.Controls.Add(this.dgvLichSu);
            this.grpLichSu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLichSu.Location = new System.Drawing.Point(12, 525);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(1080, 215);
            this.grpLichSu.TabIndex = 6;
            this.grpLichSu.TabStop = false;
            this.grpLichSu.Text = "5. Danh sách phiếu đăng ký tour theo đoàn đã lập";
            // 
            // lblSoThanhVienDaLuu
            // 
            this.lblSoThanhVienDaLuu.AutoSize = true;
            this.lblSoThanhVienDaLuu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSoThanhVienDaLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblSoThanhVienDaLuu.Location = new System.Drawing.Point(15, 192);
            this.lblSoThanhVienDaLuu.Name = "lblSoThanhVienDaLuu";
            this.lblSoThanhVienDaLuu.Size = new System.Drawing.Size(262, 15);
            this.lblSoThanhVienDaLuu.TabIndex = 1;
            this.lblSoThanhVienDaLuu.Text = "Bấm vào phiếu để xem thông tin chi tiết.";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(10, 22);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 25;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(1060, 165);
            this.dgvLichSu.TabIndex = 0;
            this.dgvLichSu.SelectionChanged += new System.EventHandler(this.dgvLichSu_SelectionChanged);
            // 
            // FrmDangKyTourDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1104, 750);
            this.Controls.Add(this.grpLichSu);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.grpBaoHiem);
            this.Controls.Add(this.grpThemDoan);
            this.Controls.Add(this.grpDoan);
            this.Controls.Add(this.grpPhieu);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDangKyTourDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tour Theo Đoàn - Công Ty Du Lịch Văn Hóa Việt";
            this.Load += new System.EventHandler(this.FrmDangKyTourDoan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpPhieu.ResumeLayout(false);
            this.grpPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            this.grpDoan.ResumeLayout(false);
            this.grpDoan.PerformLayout();
            this.grpThemDoan.ResumeLayout(false);
            this.grpThemDoan.PerformLayout();
            this.grpBaoHiem.ResumeLayout(false);
            this.grpBaoHiem.PerformLayout();
            this.pnlBaoHiem.ResumeLayout(false);
            this.pnlBaoHiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.grpLichSu.ResumeLayout(false);
            this.grpLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.TextBox txtDiemDon;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lblThongTinTour;
        private System.Windows.Forms.Label lblCanhBaoSoNguoi;
        private System.Windows.Forms.GroupBox grpDoan;
        private System.Windows.Forms.Label lblDoan;
        private System.Windows.Forms.ComboBox cboDoan;
        private System.Windows.Forms.Label lblNguoiDaiDien;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.Label lblDienThoaiDoan;
        private System.Windows.Forms.TextBox txtDienThoaiDoan;
        private System.Windows.Forms.Label lblDiaChiDoan;
        private System.Windows.Forms.TextBox txtDiaChiDoan;
        private System.Windows.Forms.GroupBox grpThemDoan;
        private System.Windows.Forms.Label lblTenDoanMoi;
        private System.Windows.Forms.TextBox txtTenDoanMoi;
        private System.Windows.Forms.Label lblNguoiDDMoi;
        private System.Windows.Forms.TextBox txtNguoiDDMoi;
        private System.Windows.Forms.Label lblDiaChiMoi;
        private System.Windows.Forms.TextBox txtDiaChiMoi;
        private System.Windows.Forms.Label lblSDTMoi;
        private System.Windows.Forms.TextBox txtSDTMoi;
        private System.Windows.Forms.Label lblEmailMoi;
        private System.Windows.Forms.TextBox txtEmailMoi;
        private System.Windows.Forms.Button btnThemDoanMoi;
        private System.Windows.Forms.GroupBox grpBaoHiem;
        private System.Windows.Forms.CheckBox chkCoBaoHiem;
        private System.Windows.Forms.Panel pnlBaoHiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTenTV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhTV;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCDTV;
        private System.Windows.Forms.Button btnThemTV;
        private System.Windows.Forms.Button btnXoaTV;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblTitleTong;
        private System.Windows.Forms.Label lblTongKinhPhi;
        private System.Windows.Forms.Label lblTitleCoc;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.Label lblHTTT;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.Label lblCamKet;
        private System.Windows.Forms.Button btnXacNhanLapPhieu;
        private System.Windows.Forms.Button btnLamMoiForm;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label lblSoThanhVienDaLuu;
    }
}
