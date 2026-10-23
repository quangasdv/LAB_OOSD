namespace QuanLyNhanSu.Forms
{
    partial class FrmNhanVien
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grpHopDongLuong = new System.Windows.Forms.GroupBox();
            this.chkDocHai = new System.Windows.Forms.CheckBox();
            this.numPhuCapDocHai = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numPhuCapCV = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numHeSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaBHYT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoBHXH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numLuongDongBH = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChuyenChinhThuc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpHopDongLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhuCapDocHai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhuCapCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongDongBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(280, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(570, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỒ SƠ NHÂN SỰ & HỢP ĐỒNG LAO ĐỘNG";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.label11);
            this.grpThongTin.Controls.Add(this.dtpNgayVaoLam);
            this.grpThongTin.Controls.Add(this.label10);
            this.grpThongTin.Controls.Add(this.cboChucVu);
            this.grpThongTin.Controls.Add(this.label9);
            this.grpThongTin.Controls.Add(this.cboPhongBan);
            this.grpThongTin.Controls.Add(this.label8);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.label7);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.txtCCCD);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.txtMaNV);
            this.grpThongTin.Controls.Add(this.lblMaNV);
            this.grpThongTin.Location = new System.Drawing.Point(12, 60);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(560, 275);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin lý lịch nhân sự";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Thử việc",
            "Chính thức",
            "Đã nghỉ việc"});
            this.cboTrangThai.Location = new System.Drawing.Point(375, 235);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(170, 28);
            this.cboTrangThai.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Trạng thái:";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(100, 235);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayVaoLam.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ngày vào:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(375, 200);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(170, 28);
            this.cboChucVu.TabIndex = 19;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Chức vụ:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(100, 200);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(180, 28);
            this.cboPhongBan.TabIndex = 17;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phòng ban:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 165);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(445, 27);
            this.txtDiaChi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(375, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 27);
            this.txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(100, 130);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 27);
            this.txtSDT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SĐT:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(375, 95);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(170, 27);
            this.txtCCCD.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số CCCD:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(100, 95);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(180, 28);
            this.cboGioiTinh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 60);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(180, 27);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(375, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(100, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(12, 28);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 20);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // grpHopDongLuong
            // 
            this.grpHopDongLuong.Controls.Add(this.chkDocHai);
            this.grpHopDongLuong.Controls.Add(this.numPhuCapDocHai);
            this.grpHopDongLuong.Controls.Add(this.label18);
            this.grpHopDongLuong.Controls.Add(this.numPhuCapCV);
            this.grpHopDongLuong.Controls.Add(this.label17);
            this.grpHopDongLuong.Controls.Add(this.numHeSoLuong);
            this.grpHopDongLuong.Controls.Add(this.label16);
            this.grpHopDongLuong.Controls.Add(this.numLuongCoBan);
            this.grpHopDongLuong.Controls.Add(this.label15);
            this.grpHopDongLuong.Controls.Add(this.txtMaBHYT);
            this.grpHopDongLuong.Controls.Add(this.label14);
            this.grpHopDongLuong.Controls.Add(this.txtSoBHXH);
            this.grpHopDongLuong.Controls.Add(this.label13);
            this.grpHopDongLuong.Controls.Add(this.numLuongDongBH);
            this.grpHopDongLuong.Controls.Add(this.label12);
            this.grpHopDongLuong.Controls.Add(this.cboLoaiHD);
            this.grpHopDongLuong.Controls.Add(this.lblLoaiHD);
            this.grpHopDongLuong.Location = new System.Drawing.Point(585, 60);
            this.grpHopDongLuong.Name = "grpHopDongLuong";
            this.grpHopDongLuong.Size = new System.Drawing.Size(537, 275);
            this.grpHopDongLuong.TabIndex = 2;
            this.grpHopDongLuong.TabStop = false;
            this.grpHopDongLuong.Text = "Hợp đồng, Bảo hiểm & Lương";
            // 
            // chkDocHai
            // 
            this.chkDocHai.AutoSize = true;
            this.chkDocHai.Location = new System.Drawing.Point(15, 237);
            this.chkDocHai.Name = "chkDocHai";
            this.chkDocHai.Size = new System.Drawing.Size(430, 24);
            this.chkDocHai.TabIndex = 16;
            this.chkDocHai.Text = "Phân xưởng sản xuất sơn (Môi trường độc hại/dung môi)";
            this.chkDocHai.UseVisualStyleBackColor = true;
            // 
            // numPhuCapDocHai
            // 
            this.numPhuCapDocHai.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPhuCapDocHai.Location = new System.Drawing.Point(375, 200);
            this.numPhuCapDocHai.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPhuCapDocHai.Name = "numPhuCapDocHai";
            this.numPhuCapDocHai.Size = new System.Drawing.Size(145, 27);
            this.numPhuCapDocHai.TabIndex = 15;
            this.numPhuCapDocHai.ThousandsSeparator = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(265, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "PC Độc hại:";
            // 
            // numPhuCapCV
            // 
            this.numPhuCapCV.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPhuCapCV.Location = new System.Drawing.Point(115, 200);
            this.numPhuCapCV.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numPhuCapCV.Name = "numPhuCapCV";
            this.numPhuCapCV.Size = new System.Drawing.Size(140, 27);
            this.numPhuCapCV.TabIndex = 13;
            this.numPhuCapCV.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "PC Chức vụ:";
            // 
            // numHeSoLuong
            // 
            this.numHeSoLuong.DecimalPlaces = 2;
            this.numHeSoLuong.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numHeSoLuong.Location = new System.Drawing.Point(375, 165);
            this.numHeSoLuong.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeSoLuong.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numHeSoLuong.Name = "numHeSoLuong";
            this.numHeSoLuong.Size = new System.Drawing.Size(145, 27);
            this.numHeSoLuong.TabIndex = 11;
            this.numHeSoLuong.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Hệ số lương:";
            // 
            // numLuongCoBan
            // 
            this.numLuongCoBan.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numLuongCoBan.Location = new System.Drawing.Point(115, 165);
            this.numLuongCoBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numLuongCoBan.Name = "numLuongCoBan";
            this.numLuongCoBan.Size = new System.Drawing.Size(140, 27);
            this.numLuongCoBan.TabIndex = 9;
            this.numLuongCoBan.ThousandsSeparator = true;
            this.numLuongCoBan.Value = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Lương cơ bản:";
            // 
            // txtMaBHYT
            // 
            this.txtMaBHYT.Location = new System.Drawing.Point(115, 130);
            this.txtMaBHYT.Name = "txtMaBHYT";
            this.txtMaBHYT.Size = new System.Drawing.Size(405, 27);
            this.txtMaBHYT.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Mã BHYT:";
            // 
            // txtSoBHXH
            // 
            this.txtSoBHXH.Location = new System.Drawing.Point(115, 95);
            this.txtSoBHXH.Name = "txtSoBHXH";
            this.txtSoBHXH.Size = new System.Drawing.Size(405, 27);
            this.txtSoBHXH.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Sổ BHXH:";
            // 
            // numLuongDongBH
            // 
            this.numLuongDongBH.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numLuongDongBH.Location = new System.Drawing.Point(115, 60);
            this.numLuongDongBH.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numLuongDongBH.Name = "numLuongDongBH";
            this.numLuongDongBH.Size = new System.Drawing.Size(405, 27);
            this.numLuongDongBH.TabIndex = 3;
            this.numLuongDongBH.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Lương BH:";
            // 
            // cboLoaiHD
            // 
            this.cboLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHD.FormattingEnabled = true;
            this.cboLoaiHD.Items.AddRange(new object[] {
            "Dài hạn",
            "Ngắn hạn",
            "Không xác định thời hạn"});
            this.cboLoaiHD.Location = new System.Drawing.Point(115, 25);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.Size = new System.Drawing.Size(405, 28);
            this.cboLoaiHD.TabIndex = 1;
            this.cboLoaiHD.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHD_SelectedIndexChanged);
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Location = new System.Drawing.Point(12, 28);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(64, 20);
            this.lblLoaiHD.TabIndex = 0;
            this.lblLoaiHD.Text = "Loại HĐ:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(12, 345);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(120, 36);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(145, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 36);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu / Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(290, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyenChinhThuc
            // 
            this.btnChuyenChinhThuc.Location = new System.Drawing.Point(585, 345);
            this.btnChuyenChinhThuc.Name = "btnChuyenChinhThuc";
            this.btnChuyenChinhThuc.Size = new System.Drawing.Size(240, 36);
            this.btnChuyenChinhThuc.TabIndex = 6;
            this.btnChuyenChinhThuc.Text = "Chuyển Nhân Viên Chính Thức";
            this.btnChuyenChinhThuc.UseVisualStyleBackColor = true;
            this.btnChuyenChinhThuc.Click += new System.EventHandler(this.btnChuyenChinhThuc_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1002, 345);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 36);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 395);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1110, 260);
            this.dgvNhanVien.TabIndex = 8;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 670);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChuyenChinhThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.grpHopDongLuong);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Hồ Sơ Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpHopDongLuong.ResumeLayout(false);
            this.grpHopDongLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhuCapDocHai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhuCapCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongDongBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpHopDongLuong;
        private System.Windows.Forms.ComboBox cboLoaiHD;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.NumericUpDown numLuongDongBH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoBHXH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaBHYT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numLuongCoBan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numHeSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numPhuCapCV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numPhuCapDocHai;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkDocHai;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuyenChinhThuc;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}
