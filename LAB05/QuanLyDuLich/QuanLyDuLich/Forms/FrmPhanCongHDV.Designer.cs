namespace QuanLyDuLich.Forms
{
    partial class FrmPhanCongHDV
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPhanCong = new System.Windows.Forms.TabPage();
            this.btnHuyPhanCong = new System.Windows.Forms.Button();
            this.cboLocHDV = new System.Windows.Forms.ComboBox();
            this.lblLocHDV = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.grpNhapPhanCong = new System.Windows.Forms.GroupBox();
            this.lblKetQuaKiemTra = new System.Windows.Forms.Label();
            this.btnKiemTraLich = new System.Windows.Forms.Button();
            this.btnLamMoiPhanCong = new System.Windows.Forms.Button();
            this.btnLuuPhanCong = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblChiTietDoiTuong = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.rdoDoan = new System.Windows.Forms.RadioButton();
            this.rdoChuyen = new System.Windows.Forms.RadioButton();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblHDV = new System.Windows.Forms.Label();
            this.txtMaPhanCong = new System.Windows.Forms.TextBox();
            this.lblMaPhanCong = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.grpDanhSachNV = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grpThongTinNV = new System.Windows.Forms.GroupBox();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.numThuLaoTour = new System.Windows.Forms.NumericUpDown();
            this.lblThuLaoTour = new System.Windows.Forms.Label();
            this.numLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.lblDienThoaiNV = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.grpNhapPhanCong.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.grpDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grpThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThuLaoTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1018, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSubTitle.Location = new System.Drawing.Point(16, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(647, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Phân công HDV theo đoàn hoặc theo chuyến lẻ - Kiểm tra tự động chống chồng chéo lịch phân công hướng dẫn viên";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(567, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ VÀ PHÂN CÔNG HƯỚNG DẪN VIÊN DU LỊCH (HDV)";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPhanCong);
            this.tabMain.Controls.Add(this.tabNhanVien);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabMain.Location = new System.Drawing.Point(12, 70);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(994, 560);
            this.tabMain.TabIndex = 1;
            // 
            // tabPhanCong
            // 
            this.tabPhanCong.BackColor = System.Drawing.Color.White;
            this.tabPhanCong.Controls.Add(this.btnHuyPhanCong);
            this.tabPhanCong.Controls.Add(this.cboLocHDV);
            this.tabPhanCong.Controls.Add(this.lblLocHDV);
            this.tabPhanCong.Controls.Add(this.dgvPhanCong);
            this.tabPhanCong.Controls.Add(this.grpNhapPhanCong);
            this.tabPhanCong.Location = new System.Drawing.Point(4, 25);
            this.tabPhanCong.Name = "tabPhanCong";
            this.tabPhanCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCong.Size = new System.Drawing.Size(986, 531);
            this.tabPhanCong.TabIndex = 0;
            this.tabPhanCong.Text = "Điều hành & Phân công Lịch dẫn Tour";
            // 
            // btnHuyPhanCong
            // 
            this.btnHuyPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnHuyPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyPhanCong.FlatAppearance.BorderSize = 0;
            this.btnHuyPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhanCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhanCong.Location = new System.Drawing.Point(830, 248);
            this.btnHuyPhanCong.Name = "btnHuyPhanCong";
            this.btnHuyPhanCong.Size = new System.Drawing.Size(145, 28);
            this.btnHuyPhanCong.TabIndex = 4;
            this.btnHuyPhanCong.Text = "Hủy phân công";
            this.btnHuyPhanCong.UseVisualStyleBackColor = false;
            this.btnHuyPhanCong.Click += new System.EventHandler(this.btnHuyPhanCong_Click);
            // 
            // cboLocHDV
            // 
            this.cboLocHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocHDV.FormattingEnabled = true;
            this.cboLocHDV.Location = new System.Drawing.Point(145, 250);
            this.cboLocHDV.Name = "cboLocHDV";
            this.cboLocHDV.Size = new System.Drawing.Size(260, 24);
            this.cboLocHDV.TabIndex = 3;
            this.cboLocHDV.SelectedIndexChanged += new System.EventHandler(this.cboLocHDV_SelectedIndexChanged);
            // 
            // lblLocHDV
            // 
            this.lblLocHDV.AutoSize = true;
            this.lblLocHDV.Location = new System.Drawing.Point(10, 253);
            this.lblLocHDV.Name = "lblLocHDV";
            this.lblLocHDV.Size = new System.Drawing.Size(126, 17);
            this.lblLocHDV.TabIndex = 2;
            this.lblLocHDV.Text = "Lọc theo HDV cụ thể:";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Location = new System.Drawing.Point(6, 282);
            this.dgvPhanCong.MultiSelect = false;
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersWidth = 30;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(974, 243);
            this.dgvPhanCong.TabIndex = 1;
            // 
            // grpNhapPhanCong
            // 
            this.grpNhapPhanCong.Controls.Add(this.lblKetQuaKiemTra);
            this.grpNhapPhanCong.Controls.Add(this.btnKiemTraLich);
            this.grpNhapPhanCong.Controls.Add(this.btnLamMoiPhanCong);
            this.grpNhapPhanCong.Controls.Add(this.btnLuuPhanCong);
            this.grpNhapPhanCong.Controls.Add(this.dtpNgayKetThuc);
            this.grpNhapPhanCong.Controls.Add(this.lblNgayKetThuc);
            this.grpNhapPhanCong.Controls.Add(this.dtpNgayBatDau);
            this.grpNhapPhanCong.Controls.Add(this.lblNgayBatDau);
            this.grpNhapPhanCong.Controls.Add(this.lblChiTietDoiTuong);
            this.grpNhapPhanCong.Controls.Add(this.cboDoiTuong);
            this.grpNhapPhanCong.Controls.Add(this.lblDoiTuong);
            this.grpNhapPhanCong.Controls.Add(this.rdoDoan);
            this.grpNhapPhanCong.Controls.Add(this.rdoChuyen);
            this.grpNhapPhanCong.Controls.Add(this.lblLoai);
            this.grpNhapPhanCong.Controls.Add(this.cboHDV);
            this.grpNhapPhanCong.Controls.Add(this.lblHDV);
            this.grpNhapPhanCong.Controls.Add(this.txtMaPhanCong);
            this.grpNhapPhanCong.Controls.Add(this.lblMaPhanCong);
            this.grpNhapPhanCong.Location = new System.Drawing.Point(6, 6);
            this.grpNhapPhanCong.Name = "grpNhapPhanCong";
            this.grpNhapPhanCong.Size = new System.Drawing.Size(974, 235);
            this.grpNhapPhanCong.TabIndex = 0;
            this.grpNhapPhanCong.TabStop = false;
            this.grpNhapPhanCong.Text = "Lập phiếu Phân công HDV dẫn Tour";
            // 
            // lblKetQuaKiemTra
            // 
            this.lblKetQuaKiemTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaKiemTra.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKetQuaKiemTra.Location = new System.Drawing.Point(120, 195);
            this.lblKetQuaKiemTra.Name = "lblKetQuaKiemTra";
            this.lblKetQuaKiemTra.Size = new System.Drawing.Size(530, 32);
            this.lblKetQuaKiemTra.TabIndex = 17;
            this.lblKetQuaKiemTra.Text = "Sẵn sàng kiểm tra xung đột lịch trình...";
            // 
            // btnKiemTraLich
            // 
            this.btnKiemTraLich.BackColor = System.Drawing.Color.White;
            this.btnKiemTraLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiemTraLich.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnKiemTraLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraLich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKiemTraLich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnKiemTraLich.Location = new System.Drawing.Point(540, 155);
            this.btnKiemTraLich.Name = "btnKiemTraLich";
            this.btnKiemTraLich.Size = new System.Drawing.Size(160, 30);
            this.btnKiemTraLich.TabIndex = 16;
            this.btnKiemTraLich.Text = "Kiểm tra trùng lịch";
            this.btnKiemTraLich.UseVisualStyleBackColor = false;
            this.btnKiemTraLich.Click += new System.EventHandler(this.btnKiemTraLich_Click);
            // 
            // btnLamMoiPhanCong
            // 
            this.btnLamMoiPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoiPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiPhanCong.FlatAppearance.BorderSize = 0;
            this.btnLamMoiPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiPhanCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiPhanCong.Location = new System.Drawing.Point(850, 192);
            this.btnLamMoiPhanCong.Name = "btnLamMoiPhanCong";
            this.btnLamMoiPhanCong.Size = new System.Drawing.Size(105, 34);
            this.btnLamMoiPhanCong.TabIndex = 15;
            this.btnLamMoiPhanCong.Text = "Làm mới";
            this.btnLamMoiPhanCong.UseVisualStyleBackColor = false;
            this.btnLamMoiPhanCong.Click += new System.EventHandler(this.btnLamMoiPhanCong_Click);
            // 
            // btnLuuPhanCong
            // 
            this.btnLuuPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnLuuPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuPhanCong.FlatAppearance.BorderSize = 0;
            this.btnLuuPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhanCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhanCong.Location = new System.Drawing.Point(670, 192);
            this.btnLuuPhanCong.Name = "btnLuuPhanCong";
            this.btnLuuPhanCong.Size = new System.Drawing.Size(165, 34);
            this.btnLuuPhanCong.TabIndex = 14;
            this.btnLuuPhanCong.Text = "LƯU PHÂN CÔNG";
            this.btnLuuPhanCong.UseVisualStyleBackColor = false;
            this.btnLuuPhanCong.Click += new System.EventHandler(this.btnLuuPhanCong_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(375, 158);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayKetThuc.TabIndex = 13;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(280, 161);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(89, 17);
            this.lblNgayKetThuc.TabIndex = 12;
            this.lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(120, 158);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayBatDau.TabIndex = 11;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(15, 161);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(89, 17);
            this.lblNgayBatDau.TabIndex = 10;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblChiTietDoiTuong
            // 
            this.lblChiTietDoiTuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblChiTietDoiTuong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChiTietDoiTuong.Location = new System.Drawing.Point(120, 126);
            this.lblChiTietDoiTuong.Name = "lblChiTietDoiTuong";
            this.lblChiTietDoiTuong.Size = new System.Drawing.Size(830, 25);
            this.lblChiTietDoiTuong.TabIndex = 9;
            this.lblChiTietDoiTuong.Text = "Chi tiết chuyến/đoàn...";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(120, 95);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(830, 24);
            this.cboDoiTuong.TabIndex = 8;
            this.cboDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboDoiTuong_SelectedIndexChanged);
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.AutoSize = true;
            this.lblDoiTuong.Location = new System.Drawing.Point(15, 98);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(100, 17);
            this.lblDoiTuong.TabIndex = 7;
            this.lblDoiTuong.Text = "Chuyến / Đoàn:";
            // 
            // rdoDoan
            // 
            this.rdoDoan.AutoSize = true;
            this.rdoDoan.Location = new System.Drawing.Point(340, 62);
            this.rdoDoan.Name = "rdoDoan";
            this.rdoDoan.Size = new System.Drawing.Size(209, 21);
            this.rdoDoan.TabIndex = 6;
            this.rdoDoan.Text = "Theo Tour Đoàn (>= 12 người)";
            this.rdoDoan.UseVisualStyleBackColor = true;
            this.rdoDoan.CheckedChanged += new System.EventHandler(this.rdoLoai_CheckedChanged);
            // 
            // rdoChuyen
            // 
            this.rdoChuyen.AutoSize = true;
            this.rdoChuyen.Checked = true;
            this.rdoChuyen.Location = new System.Drawing.Point(120, 62);
            this.rdoChuyen.Name = "rdoChuyen";
            this.rdoChuyen.Size = new System.Drawing.Size(201, 21);
            this.rdoChuyen.TabIndex = 5;
            this.rdoChuyen.TabStop = true;
            this.rdoChuyen.Text = "Theo Chuyến Lẻ (< 12 người)";
            this.rdoChuyen.UseVisualStyleBackColor = true;
            this.rdoChuyen.CheckedChanged += new System.EventHandler(this.rdoLoai_CheckedChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(15, 64);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(99, 17);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loại phân công:";
            // 
            // cboHDV
            // 
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.FormattingEnabled = true;
            this.cboHDV.Location = new System.Drawing.Point(520, 25);
            this.cboHDV.Name = "cboHDV";
            this.cboHDV.Size = new System.Drawing.Size(430, 24);
            this.cboHDV.TabIndex = 3;
            this.cboHDV.SelectedIndexChanged += new System.EventHandler(this.cboHDV_SelectedIndexChanged);
            // 
            // lblHDV
            // 
            this.lblHDV.AutoSize = true;
            this.lblHDV.Location = new System.Drawing.Point(435, 28);
            this.lblHDV.Name = "lblHDV";
            this.lblHDV.Size = new System.Drawing.Size(73, 17);
            this.lblHDV.TabIndex = 2;
            this.lblHDV.Text = "Chọn HDV:";
            // 
            // txtMaPhanCong
            // 
            this.txtMaPhanCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtMaPhanCong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMaPhanCong.Location = new System.Drawing.Point(120, 25);
            this.txtMaPhanCong.Name = "txtMaPhanCong";
            this.txtMaPhanCong.ReadOnly = true;
            this.txtMaPhanCong.Size = new System.Drawing.Size(250, 24);
            this.txtMaPhanCong.TabIndex = 1;
            // 
            // lblMaPhanCong
            // 
            this.lblMaPhanCong.AutoSize = true;
            this.lblMaPhanCong.Location = new System.Drawing.Point(15, 28);
            this.lblMaPhanCong.Name = "lblMaPhanCong";
            this.lblMaPhanCong.Size = new System.Drawing.Size(95, 17);
            this.lblMaPhanCong.TabIndex = 0;
            this.lblMaPhanCong.Text = "Mã phân công:";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.White;
            this.tabNhanVien.Controls.Add(this.grpDanhSachNV);
            this.tabNhanVien.Controls.Add(this.grpThongTinNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(986, 531);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Danh mục Nhân viên Hướng Dẫn Viên";
            // 
            // grpDanhSachNV
            // 
            this.grpDanhSachNV.Controls.Add(this.dgvNhanVien);
            this.grpDanhSachNV.Location = new System.Drawing.Point(6, 170);
            this.grpDanhSachNV.Name = "grpDanhSachNV";
            this.grpDanhSachNV.Size = new System.Drawing.Size(974, 355);
            this.grpDanhSachNV.TabIndex = 1;
            this.grpDanhSachNV.TabStop = false;
            this.grpDanhSachNV.Text = "Danh sách Nhân viên HDV hiện có";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 24);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 30;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(962, 325);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // grpThongTinNV
            // 
            this.grpThongTinNV.Controls.Add(this.btnLamMoiNV);
            this.grpThongTinNV.Controls.Add(this.btnXoaNV);
            this.grpThongTinNV.Controls.Add(this.btnCapNhatNV);
            this.grpThongTinNV.Controls.Add(this.btnThemNV);
            this.grpThongTinNV.Controls.Add(this.numThuLaoTour);
            this.grpThongTinNV.Controls.Add(this.lblThuLaoTour);
            this.grpThongTinNV.Controls.Add(this.numLuongCoBan);
            this.grpThongTinNV.Controls.Add(this.lblLuongCoBan);
            this.grpThongTinNV.Controls.Add(this.txtDienThoaiNV);
            this.grpThongTinNV.Controls.Add(this.lblDienThoaiNV);
            this.grpThongTinNV.Controls.Add(this.txtHoTenNV);
            this.grpThongTinNV.Controls.Add(this.lblHoTenNV);
            this.grpThongTinNV.Controls.Add(this.txtMaNV);
            this.grpThongTinNV.Controls.Add(this.lblMaNV);
            this.grpThongTinNV.Location = new System.Drawing.Point(6, 6);
            this.grpThongTinNV.Name = "grpThongTinNV";
            this.grpThongTinNV.Size = new System.Drawing.Size(974, 158);
            this.grpThongTinNV.TabIndex = 0;
            this.grpThongTinNV.TabStop = false;
            this.grpThongTinNV.Text = "Thông tin chi tiết Hướng dẫn viên";
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoiNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiNV.FlatAppearance.BorderSize = 0;
            this.btnLamMoiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiNV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiNV.Location = new System.Drawing.Point(795, 110);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(95, 32);
            this.btnLamMoiNV.TabIndex = 13;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.UseVisualStyleBackColor = false;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(685, 110);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(95, 32);
            this.btnXoaNV.TabIndex = 12;
            this.btnXoaNV.Text = "Xóa HDV";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCapNhatNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatNV.FlatAppearance.BorderSize = 0;
            this.btnCapNhatNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatNV.Location = new System.Drawing.Point(575, 110);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(95, 32);
            this.btnCapNhatNV.TabIndex = 11;
            this.btnCapNhatNV.Text = "Cập nhật";
            this.btnCapNhatNV.UseVisualStyleBackColor = false;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(465, 110);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(95, 32);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm HDV";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // numThuLaoTour
            // 
            this.numThuLaoTour.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numThuLaoTour.Location = new System.Drawing.Point(585, 68);
            this.numThuLaoTour.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            this.numThuLaoTour.Name = "numThuLaoTour";
            this.numThuLaoTour.Size = new System.Drawing.Size(200, 24);
            this.numThuLaoTour.TabIndex = 9;
            this.numThuLaoTour.ThousandsSeparator = true;
            this.numThuLaoTour.Value = new decimal(new int[] { 1500000, 0, 0, 0 });
            // 
            // lblThuLaoTour
            // 
            this.lblThuLaoTour.AutoSize = true;
            this.lblThuLaoTour.Location = new System.Drawing.Point(460, 71);
            this.lblThuLaoTour.Name = "lblThuLaoTour";
            this.lblThuLaoTour.Size = new System.Drawing.Size(117, 17);
            this.lblThuLaoTour.TabIndex = 8;
            this.lblThuLaoTour.Text = "Thù lao/tour (VNĐ):";
            // 
            // numLuongCoBan
            // 
            this.numLuongCoBan.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.numLuongCoBan.Location = new System.Drawing.Point(585, 28);
            this.numLuongCoBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numLuongCoBan.Name = "numLuongCoBan";
            this.numLuongCoBan.Size = new System.Drawing.Size(200, 24);
            this.numLuongCoBan.TabIndex = 7;
            this.numLuongCoBan.ThousandsSeparator = true;
            this.numLuongCoBan.Value = new decimal(new int[] { 8000000, 0, 0, 0 });
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(460, 31);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(121, 17);
            this.lblLuongCoBan.TabIndex = 6;
            this.lblLuongCoBan.Text = "Lương cơ bản (VNĐ):";
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.Location = new System.Drawing.Point(120, 108);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(250, 24);
            this.txtDienThoaiNV.TabIndex = 5;
            // 
            // lblDienThoaiNV
            // 
            this.lblDienThoaiNV.AutoSize = true;
            this.lblDienThoaiNV.Location = new System.Drawing.Point(20, 111);
            this.lblDienThoaiNV.Name = "lblDienThoaiNV";
            this.lblDienThoaiNV.Size = new System.Drawing.Size(70, 17);
            this.lblDienThoaiNV.TabIndex = 4;
            this.lblDienThoaiNV.Text = "Điện thoại:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(120, 68);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(250, 24);
            this.txtHoTenNV.TabIndex = 3;
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(20, 71);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(75, 17);
            this.lblHoTenNV.TabIndex = 2;
            this.lblHoTenNV.Text = "Họ tên HDV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(120, 28);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(150, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(20, 31);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(58, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã HDV:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(906, 638);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhanCongHDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1018, 680);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhanCongHDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý & Phân công Hướng Dẫn Viên - Văn Hóa Việt TP.HCM";
            this.Load += new System.EventHandler(this.FrmPhanCongHDV_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPhanCong.ResumeLayout(false);
            this.tabPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.grpNhapPhanCong.ResumeLayout(false);
            this.grpNhapPhanCong.PerformLayout();
            this.tabNhanVien.ResumeLayout(false);
            this.grpDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grpThongTinNV.ResumeLayout(false);
            this.grpThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThuLaoTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhanCong;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.GroupBox grpNhapPhanCong;
        private System.Windows.Forms.Label lblMaPhanCong;
        private System.Windows.Forms.TextBox txtMaPhanCong;
        private System.Windows.Forms.Label lblHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.RadioButton rdoDoan;
        private System.Windows.Forms.RadioButton rdoChuyen;
        private System.Windows.Forms.Label lblDoiTuong;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label lblChiTietDoiTuong;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnKiemTraLich;
        private System.Windows.Forms.Label lblKetQuaKiemTra;
        private System.Windows.Forms.Button btnLuuPhanCong;
        private System.Windows.Forms.Button btnLamMoiPhanCong;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Label lblLocHDV;
        private System.Windows.Forms.ComboBox cboLocHDV;
        private System.Windows.Forms.Button btnHuyPhanCong;
        private System.Windows.Forms.GroupBox grpThongTinNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Label lblDienThoaiNV;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.NumericUpDown numLuongCoBan;
        private System.Windows.Forms.Label lblThuLaoTour;
        private System.Windows.Forms.NumericUpDown numThuLaoTour;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.GroupBox grpDanhSachNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnDong;
    }
}
