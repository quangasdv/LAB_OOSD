namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmHoanTatDieuTri
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
            this.grpDotDieuTri = new System.Windows.Forms.GroupBox();
            this.lblThongTinDot = new System.Windows.Forms.Label();
            this.cboDotDieuTri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDanhGiaXuatVien = new System.Windows.Forms.GroupBox();
            this.txtDanDo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKetQua = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHoanTat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoanTat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpQuyetToan = new System.Windows.Forms.GroupBox();
            this.txtBenhNhanTra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBHYTChiTra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numPhanTramBHYT = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongVienPhi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblChiTietChiPhi = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvHoanTat = new System.Windows.Forms.DataGridView();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnInGiayRaVien = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpDotDieuTri.SuspendLayout();
            this.grpDanhGiaXuatVien.SuspendLayout();
            this.grpQuyetToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramBHYT)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanTat)).BeginInit();
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
            this.lblHeader.Text = "HOÀN TẤT ĐỢT ĐIỀU TRỊ & TỔNG KẾT BỆNH ÁN XUẤT VIỆN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDotDieuTri
            // 
            this.grpDotDieuTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDotDieuTri.Controls.Add(this.lblThongTinDot);
            this.grpDotDieuTri.Controls.Add(this.cboDotDieuTri);
            this.grpDotDieuTri.Controls.Add(this.label1);
            this.grpDotDieuTri.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDotDieuTri.Location = new System.Drawing.Point(12, 53);
            this.grpDotDieuTri.Name = "grpDotDieuTri";
            this.grpDotDieuTri.Size = new System.Drawing.Size(1010, 65);
            this.grpDotDieuTri.TabIndex = 1;
            this.grpDotDieuTri.TabStop = false;
            this.grpDotDieuTri.Text = "Chọn đợt điều trị cần hoàn tất / xuất viện";
            // 
            // lblThongTinDot
            // 
            this.lblThongTinDot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongTinDot.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinDot.ForeColor = System.Drawing.Color.Navy;
            this.lblThongTinDot.Location = new System.Drawing.Point(400, 23);
            this.lblThongTinDot.Name = "lblThongTinDot";
            this.lblThongTinDot.Size = new System.Drawing.Size(595, 32);
            this.lblThongTinDot.TabIndex = 2;
            this.lblThongTinDot.Text = "Bệnh nhân: ... | Khoa: ... | Bác sĩ: ...";
            this.lblThongTinDot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDotDieuTri
            // 
            this.cboDotDieuTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDotDieuTri.FormattingEnabled = true;
            this.cboDotDieuTri.Location = new System.Drawing.Point(120, 27);
            this.cboDotDieuTri.Name = "cboDotDieuTri";
            this.cboDotDieuTri.Size = new System.Drawing.Size(265, 24);
            this.cboDotDieuTri.TabIndex = 1;
            this.cboDotDieuTri.SelectedIndexChanged += new System.EventHandler(this.cboDotDieuTri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn đợt điều trị:";
            // 
            // grpDanhGiaXuatVien
            // 
            this.grpDanhGiaXuatVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhGiaXuatVien.Controls.Add(this.txtDanDo);
            this.grpDanhGiaXuatVien.Controls.Add(this.label7);
            this.grpDanhGiaXuatVien.Controls.Add(this.txtTinhTrang);
            this.grpDanhGiaXuatVien.Controls.Add(this.label6);
            this.grpDanhGiaXuatVien.Controls.Add(this.cboKetQua);
            this.grpDanhGiaXuatVien.Controls.Add(this.label5);
            this.grpDanhGiaXuatVien.Controls.Add(this.cboBacSi);
            this.grpDanhGiaXuatVien.Controls.Add(this.label4);
            this.grpDanhGiaXuatVien.Controls.Add(this.dtpNgayHoanTat);
            this.grpDanhGiaXuatVien.Controls.Add(this.label3);
            this.grpDanhGiaXuatVien.Controls.Add(this.txtMaHoanTat);
            this.grpDanhGiaXuatVien.Controls.Add(this.label2);
            this.grpDanhGiaXuatVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhGiaXuatVien.Location = new System.Drawing.Point(12, 124);
            this.grpDanhGiaXuatVien.Name = "grpDanhGiaXuatVien";
            this.grpDanhGiaXuatVien.Size = new System.Drawing.Size(1010, 160);
            this.grpDanhGiaXuatVien.TabIndex = 2;
            this.grpDanhGiaXuatVien.TabStop = false;
            this.grpDanhGiaXuatVien.Text = "Đánh giá kết quả điều trị & Tình trạng xuất viện";
            // 
            // txtDanDo
            // 
            this.txtDanDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDanDo.Location = new System.Drawing.Point(145, 115);
            this.txtDanDo.Name = "txtDanDo";
            this.txtDanDo.Size = new System.Drawing.Size(850, 24);
            this.txtDanDo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dặn dò sau xuất viện:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTinhTrang.Location = new System.Drawing.Point(145, 75);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(850, 24);
            this.txtTinhTrang.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tình trạng xuất viện:";
            // 
            // cboKetQua
            // 
            this.cboKetQua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKetQua.FormattingEnabled = true;
            this.cboKetQua.Items.AddRange(new object[] {
            "Khỏi bệnh",
            "Thuyên giảm",
            "Không thay đổi",
            "Nặng hơn",
            "Tử vong"});
            this.cboKetQua.Location = new System.Drawing.Point(845, 27);
            this.cboKetQua.Name = "cboKetQua";
            this.cboKetQua.Size = new System.Drawing.Size(150, 24);
            this.cboKetQua.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kết quả điều trị:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(542, 27);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(175, 24);
            this.cboBacSi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "BS xác nhận:";
            // 
            // dtpNgayHoanTat
            // 
            this.dtpNgayHoanTat.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHoanTat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHoanTat.Location = new System.Drawing.Point(295, 27);
            this.dtpNgayHoanTat.Name = "dtpNgayHoanTat";
            this.dtpNgayHoanTat.Size = new System.Drawing.Size(150, 24);
            this.dtpNgayHoanTat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xuất viện:";
            // 
            // txtMaHoanTat
            // 
            this.txtMaHoanTat.Location = new System.Drawing.Point(88, 27);
            this.txtMaHoanTat.Name = "txtMaHoanTat";
            this.txtMaHoanTat.ReadOnly = true;
            this.txtMaHoanTat.Size = new System.Drawing.Size(95, 24);
            this.txtMaHoanTat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã xuất viện:";
            // 
            // grpQuyetToan
            // 
            this.grpQuyetToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuyetToan.Controls.Add(this.txtBenhNhanTra);
            this.grpQuyetToan.Controls.Add(this.label13);
            this.grpQuyetToan.Controls.Add(this.txtBHYTChiTra);
            this.grpQuyetToan.Controls.Add(this.label12);
            this.grpQuyetToan.Controls.Add(this.numPhanTramBHYT);
            this.grpQuyetToan.Controls.Add(this.label11);
            this.grpQuyetToan.Controls.Add(this.txtTongVienPhi);
            this.grpQuyetToan.Controls.Add(this.label10);
            this.grpQuyetToan.Controls.Add(this.lblChiTietChiPhi);
            this.grpQuyetToan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuyetToan.Location = new System.Drawing.Point(12, 290);
            this.grpQuyetToan.Name = "grpQuyetToan";
            this.grpQuyetToan.Size = new System.Drawing.Size(1010, 105);
            this.grpQuyetToan.TabIndex = 3;
            this.grpQuyetToan.TabStop = false;
            this.grpQuyetToan.Text = "Quyết toán viện phí & Thanh toán BHYT";
            // 
            // txtBenhNhanTra
            // 
            this.txtBenhNhanTra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenhNhanTra.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBenhNhanTra.Location = new System.Drawing.Point(835, 60);
            this.txtBenhNhanTra.Name = "txtBenhNhanTra";
            this.txtBenhNhanTra.ReadOnly = true;
            this.txtBenhNhanTra.Size = new System.Drawing.Size(160, 25);
            this.txtBenhNhanTra.TabIndex = 8;
            this.txtBenhNhanTra.Text = "0";
            this.txtBenhNhanTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(745, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "BN cùng trả:";
            // 
            // txtBHYTChiTra
            // 
            this.txtBHYTChiTra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBHYTChiTra.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBHYTChiTra.Location = new System.Drawing.Point(575, 60);
            this.txtBHYTChiTra.Name = "txtBHYTChiTra";
            this.txtBHYTChiTra.ReadOnly = true;
            this.txtBHYTChiTra.Size = new System.Drawing.Size(150, 24);
            this.txtBHYTChiTra.TabIndex = 6;
            this.txtBHYTChiTra.Text = "0";
            this.txtBHYTChiTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(485, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "BHYT chi trả:";
            // 
            // numPhanTramBHYT
            // 
            this.numPhanTramBHYT.Location = new System.Drawing.Point(405, 60);
            this.numPhanTramBHYT.Name = "numPhanTramBHYT";
            this.numPhanTramBHYT.Size = new System.Drawing.Size(65, 24);
            this.numPhanTramBHYT.TabIndex = 4;
            this.numPhanTramBHYT.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numPhanTramBHYT.ValueChanged += new System.EventHandler(this.TinhToanVienPhi);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "% BHYT trả:";
            // 
            // txtTongVienPhi
            // 
            this.txtTongVienPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongVienPhi.Location = new System.Drawing.Point(120, 60);
            this.txtTongVienPhi.Name = "txtTongVienPhi";
            this.txtTongVienPhi.ReadOnly = true;
            this.txtTongVienPhi.Size = new System.Drawing.Size(185, 24);
            this.txtTongVienPhi.TabIndex = 2;
            this.txtTongVienPhi.Text = "0";
            this.txtTongVienPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tổng viện phí:";
            // 
            // lblChiTietChiPhi
            // 
            this.lblChiTietChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTietChiPhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietChiPhi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChiTietChiPhi.Location = new System.Drawing.Point(12, 23);
            this.lblChiTietChiPhi.Name = "lblChiTietChiPhi";
            this.lblChiTietChiPhi.Size = new System.Drawing.Size(983, 28);
            this.lblChiTietChiPhi.TabIndex = 0;
            this.lblChiTietChiPhi.Text = "Bao gồm: Khám bệnh: 0 đ | Xét nghiệm: 0 đ | Toa thuốc: 0 đ";
            this.lblChiTietChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvHoanTat);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.Location = new System.Drawing.Point(12, 401);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1010, 227);
            this.grpDanhSach.TabIndex = 4;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách các đợt điều trị đã hoàn tất / xuất viện";
            // 
            // dgvHoanTat
            // 
            this.dgvHoanTat.AllowUserToAddRows = false;
            this.dgvHoanTat.AllowUserToDeleteRows = false;
            this.dgvHoanTat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoanTat.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoanTat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoanTat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoanTat.Location = new System.Drawing.Point(3, 20);
            this.dgvHoanTat.MultiSelect = false;
            this.dgvHoanTat.Name = "dgvHoanTat";
            this.dgvHoanTat.ReadOnly = true;
            this.dgvHoanTat.RowHeadersVisible = false;
            this.dgvHoanTat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoanTat.Size = new System.Drawing.Size(1004, 204);
            this.dgvHoanTat.TabIndex = 0;
            this.dgvHoanTat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoanTat_CellClick);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHoanTat.Location = new System.Drawing.Point(12, 638);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(195, 32);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "✓ Quyết toán & Xuất viện";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnInGiayRaVien
            // 
            this.btnInGiayRaVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInGiayRaVien.Location = new System.Drawing.Point(213, 638);
            this.btnInGiayRaVien.Name = "btnInGiayRaVien";
            this.btnInGiayRaVien.Size = new System.Drawing.Size(155, 32);
            this.btnInGiayRaVien.TabIndex = 6;
            this.btnInGiayRaVien.Text = "In giấy ra viện / biên lai";
            this.btnInGiayRaVien.UseVisualStyleBackColor = true;
            this.btnInGiayRaVien.Click += new System.EventHandler(this.btnInGiayRaVien_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.Location = new System.Drawing.Point(374, 638);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 32);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            // FrmHoanTatDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 682);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnInGiayRaVien);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpQuyetToan);
            this.Controls.Add(this.grpDanhGiaXuatVien);
            this.Controls.Add(this.grpDotDieuTri);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmHoanTatDieuTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoàn tất đợt điều trị & Quyết toán xuất viện";
            this.Load += new System.EventHandler(this.FrmHoanTatDieuTri_Load);
            this.grpDotDieuTri.ResumeLayout(false);
            this.grpDotDieuTri.PerformLayout();
            this.grpDanhGiaXuatVien.ResumeLayout(false);
            this.grpDanhGiaXuatVien.PerformLayout();
            this.grpQuyetToan.ResumeLayout(false);
            this.grpQuyetToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramBHYT)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoanTat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpDotDieuTri;
        private System.Windows.Forms.ComboBox cboDotDieuTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongTinDot;
        private System.Windows.Forms.GroupBox grpDanhGiaXuatVien;
        private System.Windows.Forms.TextBox txtMaHoanTat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayHoanTat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDanDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpQuyetToan;
        private System.Windows.Forms.Label lblChiTietChiPhi;
        private System.Windows.Forms.TextBox txtTongVienPhi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPhanTramBHYT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBHYTChiTra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBenhNhanTra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHoanTat;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnInGiayRaVien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
    }
}
