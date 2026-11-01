namespace QuanLyDuLich.Forms
{
    partial class FrmDangKyTourChuyen
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
            this.grpChuyen = new System.Windows.Forms.GroupBox();
            this.lblSoChoTrong = new System.Windows.Forms.Label();
            this.lblThongTinChuyen = new System.Windows.Forms.Label();
            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblGhiChuDiemDon = new System.Windows.Forms.Label();
            this.cboDiemDon = new System.Windows.Forms.ComboBox();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.lblCanhBaoSoVe = new System.Windows.Forms.Label();
            this.numSoLuongVe = new System.Windows.Forms.NumericUpDown();
            this.lblSoVe = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXacNhanDatVe = new System.Windows.Forms.Button();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.lblHTTT = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.tabChuyen = new System.Windows.Forms.TabPage();
            this.grpTaoChuyen = new System.Windows.Forms.GroupBox();
            this.btnTaoChuyen = new System.Windows.Forms.Button();
            this.numSoVeToiDa = new System.Windows.Forms.NumericUpDown();
            this.lblSoVeToiDa = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.txtMaChuyenMoi = new System.Windows.Forms.TextBox();
            this.lblMaChuyenMoi = new System.Windows.Forms.Label();
            this.dgvChuyen = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpChuyen.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongVe)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.tabChuyen.SuspendLayout();
            this.grpTaoChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoVeToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyen)).BeginInit();
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
            this.lblSubTitle.Size = new System.Drawing.Size(698, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Khách lẻ đăng ký theo các chuyến định sẵn của công ty - Điểm đón theo quy định - Thanh toán 100% tiền vé";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(535, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ TOUR THEO CHUYẾN (KHÁCH LẺ DƯỚI 12 NGƯỜI)";
            // 
            // grpChuyen
            // 
            this.grpChuyen.Controls.Add(this.lblSoChoTrong);
            this.grpChuyen.Controls.Add(this.lblThongTinChuyen);
            this.grpChuyen.Controls.Add(this.cboChuyen);
            this.grpChuyen.Controls.Add(this.lblChuyen);
            this.grpChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpChuyen.Location = new System.Drawing.Point(12, 70);
            this.grpChuyen.Name = "grpChuyen";
            this.grpChuyen.Size = new System.Drawing.Size(475, 155);
            this.grpChuyen.TabIndex = 1;
            this.grpChuyen.TabStop = false;
            this.grpChuyen.Text = "1. Chọn Chuyến du lịch định sẵn";
            // 
            // lblSoChoTrong
            // 
            this.lblSoChoTrong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoChoTrong.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoChoTrong.Location = new System.Drawing.Point(15, 110);
            this.lblSoChoTrong.Name = "lblSoChoTrong";
            this.lblSoChoTrong.Size = new System.Drawing.Size(445, 35);
            this.lblSoChoTrong.TabIndex = 3;
            this.lblSoChoTrong.Text = "Số vé tối đa: 0  |  Đã bán: 0  |  Còn trống: 0 vé";
            // 
            // lblThongTinChuyen
            // 
            this.lblThongTinChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThongTinChuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.lblThongTinChuyen.Location = new System.Drawing.Point(15, 60);
            this.lblThongTinChuyen.Name = "lblThongTinChuyen";
            this.lblThongTinChuyen.Size = new System.Drawing.Size(445, 45);
            this.lblThongTinChuyen.TabIndex = 2;
            this.lblThongTinChuyen.Text = "Lịch trình: Đang tải thông tin chuyến...";
            // 
            // cboChuyen
            // 
            this.cboChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboChuyen.FormattingEnabled = true;
            this.cboChuyen.Location = new System.Drawing.Point(115, 25);
            this.cboChuyen.Name = "cboChuyen";
            this.cboChuyen.Size = new System.Drawing.Size(345, 24);
            this.cboChuyen.TabIndex = 1;
            this.cboChuyen.SelectedIndexChanged += new System.EventHandler(this.cboChuyen_SelectedIndexChanged);
            // 
            // lblChuyen
            // 
            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(15, 28);
            this.lblChuyen.Name = "lblChuyen";
            this.lblChuyen.Size = new System.Drawing.Size(84, 17);
            this.lblChuyen.TabIndex = 0;
            this.lblChuyen.Text = "Chọn chuyến:";
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.lblGhiChuDiemDon);
            this.grpKhachHang.Controls.Add(this.cboDiemDon);
            this.grpKhachHang.Controls.Add(this.lblDiemDon);
            this.grpKhachHang.Controls.Add(this.lblCanhBaoSoVe);
            this.grpKhachHang.Controls.Add(this.numSoLuongVe);
            this.grpKhachHang.Controls.Add(this.lblSoVe);
            this.grpKhachHang.Controls.Add(this.txtDiaChi);
            this.grpKhachHang.Controls.Add(this.lblDiaChi);
            this.grpKhachHang.Controls.Add(this.txtDienThoai);
            this.grpKhachHang.Controls.Add(this.lblDienThoai);
            this.grpKhachHang.Controls.Add(this.txtCMND);
            this.grpKhachHang.Controls.Add(this.lblCMND);
            this.grpKhachHang.Controls.Add(this.txtHoTen);
            this.grpKhachHang.Controls.Add(this.lblHoTen);
            this.grpKhachHang.Controls.Add(this.txtSoPhieu);
            this.grpKhachHang.Controls.Add(this.lblSoPhieu);
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpKhachHang.Location = new System.Drawing.Point(495, 70);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(511, 260);
            this.grpKhachHang.TabIndex = 2;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "2. Thông tin Khách lẻ đặt vé";
            // 
            // lblGhiChuDiemDon
            // 
            this.lblGhiChuDiemDon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblGhiChuDiemDon.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChuDiemDon.Location = new System.Drawing.Point(115, 230);
            this.lblGhiChuDiemDon.Name = "lblGhiChuDiemDon";
            this.lblGhiChuDiemDon.Size = new System.Drawing.Size(380, 20);
            this.lblGhiChuDiemDon.TabIndex = 15;
            this.lblGhiChuDiemDon.Text = "* Quy định: Khách lẻ chỉ được đón tại các điểm hẹn cố định của công ty.";
            // 
            // cboDiemDon
            // 
            this.cboDiemDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDon.FormattingEnabled = true;
            this.cboDiemDon.Location = new System.Drawing.Point(115, 198);
            this.cboDiemDon.Name = "cboDiemDon";
            this.cboDiemDon.Size = new System.Drawing.Size(380, 24);
            this.cboDiemDon.TabIndex = 14;
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Location = new System.Drawing.Point(15, 201);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(95, 17);
            this.lblDiemDon.TabIndex = 13;
            this.lblDiemDon.Text = "Điểm đón C.Ty:";
            // 
            // lblCanhBaoSoVe
            // 
            this.lblCanhBaoSoVe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCanhBaoSoVe.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCanhBaoSoVe.Location = new System.Drawing.Point(215, 166);
            this.lblCanhBaoSoVe.Name = "lblCanhBaoSoVe";
            this.lblCanhBaoSoVe.Size = new System.Drawing.Size(280, 22);
            this.lblCanhBaoSoVe.TabIndex = 12;
            this.lblCanhBaoSoVe.Text = "Hợp lệ: Khách lẻ (< 12 vé)";
            // 
            // numSoLuongVe
            // 
            this.numSoLuongVe.Location = new System.Drawing.Point(115, 164);
            this.numSoLuongVe.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numSoLuongVe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongVe.Name = "numSoLuongVe";
            this.numSoLuongVe.Size = new System.Drawing.Size(90, 24);
            this.numSoLuongVe.TabIndex = 11;
            this.numSoLuongVe.Value = new decimal(new int[] { 2, 0, 0, 0 });
            this.numSoLuongVe.ValueChanged += new System.EventHandler(this.numSoLuongVe_ValueChanged);
            // 
            // lblSoVe
            // 
            this.lblSoVe.AutoSize = true;
            this.lblSoVe.Location = new System.Drawing.Point(15, 166);
            this.lblSoVe.Name = "lblSoVe";
            this.lblSoVe.Size = new System.Drawing.Size(97, 17);
            this.lblSoVe.TabIndex = 10;
            this.lblSoVe.Text = "Số vé cần mua:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(380, 24);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 131);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 17);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(345, 93);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 24);
            this.txtDienThoai.TabIndex = 7;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(270, 96);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(70, 17);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(115, 93);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(140, 24);
            this.txtCMND.TabIndex = 5;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(15, 96);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(89, 17);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CCCD/CMND:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(380, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 61);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(87, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên khách:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtSoPhieu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSoPhieu.Location = new System.Drawing.Point(115, 23);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(200, 24);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(15, 26);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(63, 17);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.btnLamMoi);
            this.grpThanhToan.Controls.Add(this.btnXacNhanDatVe);
            this.grpThanhToan.Controls.Add(this.cboHinhThucTT);
            this.grpThanhToan.Controls.Add(this.lblHTTT);
            this.grpThanhToan.Controls.Add(this.lblTongTien);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThanhToan.Location = new System.Drawing.Point(12, 232);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(475, 98);
            this.grpThanhToan.TabIndex = 3;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "3. Thanh toán 100% tiền vé & Đặt chỗ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(375, 54);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 32);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXacNhanDatVe
            // 
            this.btnXacNhanDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnXacNhanDatVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanDatVe.FlatAppearance.BorderSize = 0;
            this.btnXacNhanDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanDatVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDatVe.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDatVe.Location = new System.Drawing.Point(215, 54);
            this.btnXacNhanDatVe.Name = "btnXacNhanDatVe";
            this.btnXacNhanDatVe.Size = new System.Drawing.Size(150, 32);
            this.btnXacNhanDatVe.TabIndex = 3;
            this.btnXacNhanDatVe.Text = "ĐẶT VÉ & THU TIỀN";
            this.btnXacNhanDatVe.UseVisualStyleBackColor = false;
            this.btnXacNhanDatVe.Click += new System.EventHandler(this.btnXacNhanDatVe_Click);
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucTT.FormattingEnabled = true;
            this.cboHinhThucTT.Location = new System.Drawing.Point(65, 58);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(140, 24);
            this.cboHinhThucTT.TabIndex = 2;
            // 
            // lblHTTT
            // 
            this.lblHTTT.AutoSize = true;
            this.lblHTTT.Location = new System.Drawing.Point(15, 61);
            this.lblHTTT.Name = "lblHTTT";
            this.lblHTTT.Size = new System.Drawing.Size(44, 17);
            this.lblHTTT.TabIndex = 1;
            this.lblHTTT.Text = "HTTT:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTongTien.Location = new System.Drawing.Point(15, 23);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(445, 25);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền vé (100%): 0 VNĐ";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabLichSu);
            this.tabMain.Controls.Add(this.tabChuyen);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabMain.Location = new System.Drawing.Point(12, 338);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(994, 290);
            this.tabMain.TabIndex = 4;
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.White;
            this.tabLichSu.Controls.Add(this.btnHuyVe);
            this.tabLichSu.Controls.Add(this.btnTimKiem);
            this.tabLichSu.Controls.Add(this.txtTimKiem);
            this.tabLichSu.Controls.Add(this.lblTim);
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Location = new System.Drawing.Point(4, 25);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(986, 261);
            this.tabLichSu.TabIndex = 0;
            this.tabLichSu.Text = "Lịch sử Đăng ký & Bán vé lẻ";
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnHuyVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyVe.FlatAppearance.BorderSize = 0;
            this.btnHuyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyVe.ForeColor = System.Drawing.Color.White;
            this.btnHuyVe.Location = new System.Drawing.Point(850, 10);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(125, 28);
            this.btnHuyVe.TabIndex = 4;
            this.btnHuyVe.Text = "Hủy vé đã chọn";
            this.btnHuyVe.UseVisualStyleBackColor = false;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(445, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 28);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(145, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(290, 24);
            this.txtTimKiem.TabIndex = 2;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(10, 15);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(128, 17);
            this.lblTim.TabIndex = 1;
            this.lblTim.Text = "Tìm theo Phiếu/Tên:";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(6, 44);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 30;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(974, 211);
            this.dgvLichSu.TabIndex = 0;
            // 
            // tabChuyen
            // 
            this.tabChuyen.BackColor = System.Drawing.Color.White;
            this.tabChuyen.Controls.Add(this.grpTaoChuyen);
            this.tabChuyen.Controls.Add(this.dgvChuyen);
            this.tabChuyen.Location = new System.Drawing.Point(4, 25);
            this.tabChuyen.Name = "tabChuyen";
            this.tabChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuyen.Size = new System.Drawing.Size(986, 261);
            this.tabChuyen.TabIndex = 1;
            this.tabChuyen.Text = "Danh mục Chuyến du lịch định sẵn";
            // 
            // grpTaoChuyen
            // 
            this.grpTaoChuyen.Controls.Add(this.btnTaoChuyen);
            this.grpTaoChuyen.Controls.Add(this.numSoVeToiDa);
            this.grpTaoChuyen.Controls.Add(this.lblSoVeToiDa);
            this.grpTaoChuyen.Controls.Add(this.dtpNgayVe);
            this.grpTaoChuyen.Controls.Add(this.lblNgayVe);
            this.grpTaoChuyen.Controls.Add(this.dtpNgayDi);
            this.grpTaoChuyen.Controls.Add(this.lblNgayDi);
            this.grpTaoChuyen.Controls.Add(this.cboTour);
            this.grpTaoChuyen.Controls.Add(this.lblTour);
            this.grpTaoChuyen.Controls.Add(this.txtMaChuyenMoi);
            this.grpTaoChuyen.Controls.Add(this.lblMaChuyenMoi);
            this.grpTaoChuyen.Location = new System.Drawing.Point(6, 6);
            this.grpTaoChuyen.Name = "grpTaoChuyen";
            this.grpTaoChuyen.Size = new System.Drawing.Size(974, 60);
            this.grpTaoChuyen.TabIndex = 1;
            this.grpTaoChuyen.TabStop = false;
            this.grpTaoChuyen.Text = "Tạo chuyến du lịch cố định mới";
            // 
            // btnTaoChuyen
            // 
            this.btnTaoChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnTaoChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoChuyen.FlatAppearance.BorderSize = 0;
            this.btnTaoChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoChuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoChuyen.ForeColor = System.Drawing.Color.White;
            this.btnTaoChuyen.Location = new System.Drawing.Point(860, 20);
            this.btnTaoChuyen.Name = "btnTaoChuyen";
            this.btnTaoChuyen.Size = new System.Drawing.Size(105, 28);
            this.btnTaoChuyen.TabIndex = 10;
            this.btnTaoChuyen.Text = "+ Mở chuyến";
            this.btnTaoChuyen.UseVisualStyleBackColor = false;
            this.btnTaoChuyen.Click += new System.EventHandler(this.btnTaoChuyen_Click);
            // 
            // numSoVeToiDa
            // 
            this.numSoVeToiDa.Location = new System.Drawing.Point(785, 23);
            this.numSoVeToiDa.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numSoVeToiDa.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numSoVeToiDa.Name = "numSoVeToiDa";
            this.numSoVeToiDa.Size = new System.Drawing.Size(65, 24);
            this.numSoVeToiDa.TabIndex = 9;
            this.numSoVeToiDa.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // lblSoVeToiDa
            // 
            this.lblSoVeToiDa.AutoSize = true;
            this.lblSoVeToiDa.Location = new System.Drawing.Point(735, 26);
            this.lblSoVeToiDa.Name = "lblSoVeToiDa";
            this.lblSoVeToiDa.Size = new System.Drawing.Size(47, 17);
            this.lblSoVeToiDa.TabIndex = 8;
            this.lblSoVeToiDa.Text = "Số vé:";
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVe.Location = new System.Drawing.Point(620, 23);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(105, 24);
            this.dtpNgayVe.TabIndex = 7;
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Location = new System.Drawing.Point(560, 26);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(59, 17);
            this.lblNgayVe.TabIndex = 6;
            this.lblNgayVe.Text = "Ngày về:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(445, 23);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(105, 24);
            this.dtpNgayDi.TabIndex = 5;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(385, 26);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(56, 17);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(215, 23);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(160, 24);
            this.cboTour.TabIndex = 3;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(175, 26);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(37, 17);
            this.lblTour.TabIndex = 2;
            this.lblTour.Text = "Tour:";
            // 
            // txtMaChuyenMoi
            // 
            this.txtMaChuyenMoi.Location = new System.Drawing.Point(75, 23);
            this.txtMaChuyenMoi.Name = "txtMaChuyenMoi";
            this.txtMaChuyenMoi.Size = new System.Drawing.Size(90, 24);
            this.txtMaChuyenMoi.TabIndex = 1;
            // 
            // lblMaChuyenMoi
            // 
            this.lblMaChuyenMoi.AutoSize = true;
            this.lblMaChuyenMoi.Location = new System.Drawing.Point(10, 26);
            this.lblMaChuyenMoi.Name = "lblMaChuyenMoi";
            this.lblMaChuyenMoi.Size = new System.Drawing.Size(65, 17);
            this.lblMaChuyenMoi.TabIndex = 0;
            this.lblMaChuyenMoi.Text = "Mã chuyến:";
            // 
            // dgvChuyen
            // 
            this.dgvChuyen.AllowUserToAddRows = false;
            this.dgvChuyen.AllowUserToDeleteRows = false;
            this.dgvChuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyen.Location = new System.Drawing.Point(6, 72);
            this.dgvChuyen.MultiSelect = false;
            this.dgvChuyen.Name = "dgvChuyen";
            this.dgvChuyen.ReadOnly = true;
            this.dgvChuyen.RowHeadersWidth = 30;
            this.dgvChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyen.Size = new System.Drawing.Size(974, 183);
            this.dgvChuyen.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(906, 638);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDangKyTourChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1018, 680);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.grpKhachHang);
            this.Controls.Add(this.grpChuyen);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDangKyTourChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký Tour theo Chuyến (Khách lẻ dưới 12 người) - Văn Hóa Việt TP.HCM";
            this.Load += new System.EventHandler(this.FrmDangKyTourChuyen_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpChuyen.ResumeLayout(false);
            this.grpChuyen.PerformLayout();
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongVe)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabLichSu.ResumeLayout(false);
            this.tabLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.tabChuyen.ResumeLayout(false);
            this.grpTaoChuyen.ResumeLayout(false);
            this.grpTaoChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoVeToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyen)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChuyen;
        private System.Windows.Forms.Label lblSoChoTrong;
        private System.Windows.Forms.Label lblThongTinChuyen;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblGhiChuDiemDon;
        private System.Windows.Forms.ComboBox cboDiemDon;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.Label lblCanhBaoSoVe;
        private System.Windows.Forms.NumericUpDown numSoLuongVe;
        private System.Windows.Forms.Label lblSoVe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXacNhanDatVe;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.Label lblHTTT;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.TabPage tabChuyen;
        private System.Windows.Forms.GroupBox grpTaoChuyen;
        private System.Windows.Forms.Button btnTaoChuyen;
        private System.Windows.Forms.NumericUpDown numSoVeToiDa;
        private System.Windows.Forms.Label lblSoVeToiDa;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.TextBox txtMaChuyenMoi;
        private System.Windows.Forms.Label lblMaChuyenMoi;
        private System.Windows.Forms.DataGridView dgvChuyen;
        private System.Windows.Forms.Button btnDong;
    }
}
