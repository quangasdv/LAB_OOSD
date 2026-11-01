namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmChiDinhXN
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
            this.grpThongTinChiDinh = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayChiDinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhieuKham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChiDinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChonXetNghiem = new System.Windows.Forms.GroupBox();
            this.btnXoaKhoiPhieu = new System.Windows.Forms.Button();
            this.btnThemVaoPhieu = new System.Windows.Forms.Button();
            this.lblGiaXN = new System.Windows.Forms.Label();
            this.lblChiSoBinhThuong = new System.Windows.Forms.Label();
            this.cboDanhMucXN = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChiTietXN = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.grpCapNhatKQ = new System.Windows.Forms.GroupBox();
            this.btnLuuKQ = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKTV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDanhGia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTinChiDinh.SuspendLayout();
            this.grpChonXetNghiem.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXN)).BeginInit();
            this.grpCapNhatKQ.SuspendLayout();
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
            this.lblHeader.Text = "CHỈ ĐỊNH VÀ KẾT QUẢ XÉT NGHIỆM CẬN LÂM SÀNG";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinChiDinh
            // 
            this.grpThongTinChiDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinChiDinh.Controls.Add(this.cboTrangThai);
            this.grpThongTinChiDinh.Controls.Add(this.label6);
            this.grpThongTinChiDinh.Controls.Add(this.txtLyDo);
            this.grpThongTinChiDinh.Controls.Add(this.label5);
            this.grpThongTinChiDinh.Controls.Add(this.dtpNgayChiDinh);
            this.grpThongTinChiDinh.Controls.Add(this.label4);
            this.grpThongTinChiDinh.Controls.Add(this.cboBacSi);
            this.grpThongTinChiDinh.Controls.Add(this.label3);
            this.grpThongTinChiDinh.Controls.Add(this.cboPhieuKham);
            this.grpThongTinChiDinh.Controls.Add(this.label2);
            this.grpThongTinChiDinh.Controls.Add(this.txtMaChiDinh);
            this.grpThongTinChiDinh.Controls.Add(this.label1);
            this.grpThongTinChiDinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinChiDinh.Location = new System.Drawing.Point(12, 53);
            this.grpThongTinChiDinh.Name = "grpThongTinChiDinh";
            this.grpThongTinChiDinh.Size = new System.Drawing.Size(1010, 105);
            this.grpThongTinChiDinh.TabIndex = 1;
            this.grpThongTinChiDinh.TabStop = false;
            this.grpThongTinChiDinh.Text = "Thông tin phiếu chỉ định xét nghiệm";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ thực hiện",
            "Đang thực hiện",
            "Đã có kết quả"});
            this.cboTrangThai.Location = new System.Drawing.Point(825, 63);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(170, 24);
            this.cboTrangThai.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng thái:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(105, 63);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(627, 24);
            this.txtLyDo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lý do chỉ định:";
            // 
            // dtpNgayChiDinh
            // 
            this.dtpNgayChiDinh.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayChiDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChiDinh.Location = new System.Drawing.Point(825, 26);
            this.dtpNgayChiDinh.Name = "dtpNgayChiDinh";
            this.dtpNgayChiDinh.Size = new System.Drawing.Size(170, 24);
            this.dtpNgayChiDinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày chỉ định:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(525, 26);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(190, 24);
            this.cboBacSi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bác sĩ chỉ định:";
            // 
            // cboPhieuKham
            // 
            this.cboPhieuKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuKham.FormattingEnabled = true;
            this.cboPhieuKham.Location = new System.Drawing.Point(232, 26);
            this.cboPhieuKham.Name = "cboPhieuKham";
            this.cboPhieuKham.Size = new System.Drawing.Size(175, 24);
            this.cboPhieuKham.TabIndex = 3;
            this.cboPhieuKham.SelectedIndexChanged += new System.EventHandler(this.cboPhieuKham_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã PK:";
            // 
            // txtMaChiDinh
            // 
            this.txtMaChiDinh.Location = new System.Drawing.Point(74, 26);
            this.txtMaChiDinh.Name = "txtMaChiDinh";
            this.txtMaChiDinh.ReadOnly = true;
            this.txtMaChiDinh.Size = new System.Drawing.Size(88, 24);
            this.txtMaChiDinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CĐ:";
            // 
            // grpChonXetNghiem
            // 
            this.grpChonXetNghiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChonXetNghiem.Controls.Add(this.btnXoaKhoiPhieu);
            this.grpChonXetNghiem.Controls.Add(this.btnThemVaoPhieu);
            this.grpChonXetNghiem.Controls.Add(this.lblGiaXN);
            this.grpChonXetNghiem.Controls.Add(this.lblChiSoBinhThuong);
            this.grpChonXetNghiem.Controls.Add(this.cboDanhMucXN);
            this.grpChonXetNghiem.Controls.Add(this.label7);
            this.grpChonXetNghiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonXetNghiem.Location = new System.Drawing.Point(12, 164);
            this.grpChonXetNghiem.Name = "grpChonXetNghiem";
            this.grpChonXetNghiem.Size = new System.Drawing.Size(1010, 68);
            this.grpChonXetNghiem.TabIndex = 2;
            this.grpChonXetNghiem.TabStop = false;
            this.grpChonXetNghiem.Text = "Chọn xét nghiệm cận lâm sàng";
            // 
            // btnXoaKhoiPhieu
            // 
            this.btnXoaKhoiPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKhoiPhieu.Location = new System.Drawing.Point(905, 23);
            this.btnXoaKhoiPhieu.Name = "btnXoaKhoiPhieu";
            this.btnXoaKhoiPhieu.Size = new System.Drawing.Size(90, 30);
            this.btnXoaKhoiPhieu.TabIndex = 5;
            this.btnXoaKhoiPhieu.Text = "- Xóa mục";
            this.btnXoaKhoiPhieu.UseVisualStyleBackColor = true;
            this.btnXoaKhoiPhieu.Click += new System.EventHandler(this.btnXoaKhoiPhieu_Click);
            // 
            // btnThemVaoPhieu
            // 
            this.btnThemVaoPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemVaoPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoPhieu.Location = new System.Drawing.Point(798, 23);
            this.btnThemVaoPhieu.Name = "btnThemVaoPhieu";
            this.btnThemVaoPhieu.Size = new System.Drawing.Size(101, 30);
            this.btnThemVaoPhieu.TabIndex = 4;
            this.btnThemVaoPhieu.Text = "+ Thêm XN";
            this.btnThemVaoPhieu.UseVisualStyleBackColor = true;
            this.btnThemVaoPhieu.Click += new System.EventHandler(this.btnThemVaoPhieu_Click);
            // 
            // lblGiaXN
            // 
            this.lblGiaXN.AutoSize = true;
            this.lblGiaXN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaXN.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGiaXN.Location = new System.Drawing.Point(630, 30);
            this.lblGiaXN.Name = "lblGiaXN";
            this.lblGiaXN.Size = new System.Drawing.Size(89, 17);
            this.lblGiaXN.TabIndex = 3;
            this.lblGiaXN.Text = "Đơn giá: 0 đ";
            // 
            // lblChiSoBinhThuong
            // 
            this.lblChiSoBinhThuong.AutoSize = true;
            this.lblChiSoBinhThuong.Location = new System.Drawing.Point(395, 30);
            this.lblChiSoBinhThuong.Name = "lblChiSoBinhThuong";
            this.lblChiSoBinhThuong.Size = new System.Drawing.Size(91, 17);
            this.lblChiSoBinhThuong.TabIndex = 2;
            this.lblChiSoBinhThuong.Text = "Chỉ số chuẩn: ";
            // 
            // cboDanhMucXN
            // 
            this.cboDanhMucXN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMucXN.FormattingEnabled = true;
            this.cboDanhMucXN.Location = new System.Drawing.Point(120, 27);
            this.cboDanhMucXN.Name = "cboDanhMucXN";
            this.cboDanhMucXN.Size = new System.Drawing.Size(260, 24);
            this.cboDanhMucXN.TabIndex = 1;
            this.cboDanhMucXN.SelectedIndexChanged += new System.EventHandler(this.cboDanhMucXN_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Xét nghiệm cần:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvChiTietXN);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.Location = new System.Drawing.Point(12, 238);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1010, 255);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách các xét nghiệm chỉ định trong phiếu (Chọn dòng để nhập kết quả)";
            // 
            // dgvChiTietXN
            // 
            this.dgvChiTietXN.AllowUserToAddRows = false;
            this.dgvChiTietXN.AllowUserToDeleteRows = false;
            this.dgvChiTietXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietXN.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietXN.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTietXN.MultiSelect = false;
            this.dgvChiTietXN.Name = "dgvChiTietXN";
            this.dgvChiTietXN.ReadOnly = true;
            this.dgvChiTietXN.RowHeadersVisible = false;
            this.dgvChiTietXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietXN.Size = new System.Drawing.Size(1004, 232);
            this.dgvChiTietXN.TabIndex = 0;
            this.dgvChiTietXN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietXN_CellClick);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongTien.Location = new System.Drawing.Point(620, 496);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(400, 25);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "TỔNG TIỀN XÉT NGHIỆM: 0 VNĐ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpCapNhatKQ
            // 
            this.grpCapNhatKQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCapNhatKQ.Controls.Add(this.btnLuuKQ);
            this.grpCapNhatKQ.Controls.Add(this.txtGhiChu);
            this.grpCapNhatKQ.Controls.Add(this.label11);
            this.grpCapNhatKQ.Controls.Add(this.txtKTV);
            this.grpCapNhatKQ.Controls.Add(this.label10);
            this.grpCapNhatKQ.Controls.Add(this.cboDanhGia);
            this.grpCapNhatKQ.Controls.Add(this.label9);
            this.grpCapNhatKQ.Controls.Add(this.txtKetQua);
            this.grpCapNhatKQ.Controls.Add(this.label8);
            this.grpCapNhatKQ.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCapNhatKQ.Location = new System.Drawing.Point(12, 524);
            this.grpCapNhatKQ.Name = "grpCapNhatKQ";
            this.grpCapNhatKQ.Size = new System.Drawing.Size(1010, 105);
            this.grpCapNhatKQ.TabIndex = 5;
            this.grpCapNhatKQ.TabStop = false;
            this.grpCapNhatKQ.Text = "Cập nhật kết quả xét nghiệm (Dành cho Kỹ thuật viên)";
            // 
            // btnLuuKQ
            // 
            this.btnLuuKQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuKQ.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKQ.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLuuKQ.Location = new System.Drawing.Point(882, 26);
            this.btnLuuKQ.Name = "btnLuuKQ";
            this.btnLuuKQ.Size = new System.Drawing.Size(113, 61);
            this.btnLuuKQ.TabIndex = 8;
            this.btnLuuKQ.Text = "Lưu kết quả dòng chọn";
            this.btnLuuKQ.UseVisualStyleBackColor = true;
            this.btnLuuKQ.Click += new System.EventHandler(this.btnLuuKQ_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(450, 63);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(415, 24);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ghi chú:";
            // 
            // txtKTV
            // 
            this.txtKTV.Location = new System.Drawing.Point(120, 63);
            this.txtKTV.Name = "txtKTV";
            this.txtKTV.Size = new System.Drawing.Size(250, 24);
            this.txtKTV.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "KTV thực hiện:";
            // 
            // cboDanhGia
            // 
            this.cboDanhGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhGia.FormattingEnabled = true;
            this.cboDanhGia.Items.AddRange(new object[] {
            "Bình thường",
            "Cao",
            "Thấp",
            "Bất thường",
            "Dương tính",
            "Âm tính"});
            this.cboDanhGia.Location = new System.Drawing.Point(620, 26);
            this.cboDanhGia.Name = "cboDanhGia";
            this.cboDanhGia.Size = new System.Drawing.Size(245, 24);
            this.cboDanhGia.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Đánh giá:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(120, 26);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(410, 24);
            this.txtKetQua.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kết quả:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.Location = new System.Drawing.Point(12, 638);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 32);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Phiếu mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieu.Location = new System.Drawing.Point(128, 638);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(125, 32);
            this.btnLuuPhieu.TabIndex = 7;
            this.btnLuuPhieu.Text = "Lưu phiếu CĐ";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaPhieu.Location = new System.Drawing.Point(259, 638);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(100, 32);
            this.btnXoaPhieu.TabIndex = 8;
            this.btnXoaPhieu.Text = "Xóa phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(922, 638);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmChiDinhXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 682);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnLuuPhieu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grpCapNhatKQ);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChonXetNghiem);
            this.Controls.Add(this.grpThongTinChiDinh);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmChiDinhXN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chỉ định & Kết quả xét nghiệm cận lâm sàng";
            this.Load += new System.EventHandler(this.FrmChiDinhXN_Load);
            this.grpThongTinChiDinh.ResumeLayout(false);
            this.grpThongTinChiDinh.PerformLayout();
            this.grpChonXetNghiem.ResumeLayout(false);
            this.grpChonXetNghiem.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXN)).EndInit();
            this.grpCapNhatKQ.ResumeLayout(false);
            this.grpCapNhatKQ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpThongTinChiDinh;
        private System.Windows.Forms.TextBox txtMaChiDinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhieuKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayChiDinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpChonXetNghiem;
        private System.Windows.Forms.ComboBox cboDanhMucXN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChiSoBinhThuong;
        private System.Windows.Forms.Label lblGiaXN;
        private System.Windows.Forms.Button btnThemVaoPhieu;
        private System.Windows.Forms.Button btnXoaKhoiPhieu;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvChiTietXN;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox grpCapNhatKQ;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDanhGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKTV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuuKQ;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}
