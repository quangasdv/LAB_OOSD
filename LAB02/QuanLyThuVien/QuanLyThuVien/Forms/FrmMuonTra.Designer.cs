namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.lblSachChon = new System.Windows.Forms.Label();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.lblSachCon = new System.Windows.Forms.Label();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.pnlMuonTop = new System.Windows.Forms.Panel();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblHenTra = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();
            this.lblNVMuon = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.pnlTraBottom = new System.Windows.Forms.Panel();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.pnlTraTop = new System.Windows.Forms.Panel();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();
            this.lblNVTra = new System.Windows.Forms.Label();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.lblDocGiaTra = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            this.pnlMuonTop.SuspendLayout();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.pnlTraBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();
            this.pnlTraTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabMuon);
            this.tabs.Controls.Add(this.tabTra);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1186, 680);
            this.tabs.TabIndex = 0;
            // 
            // tabMuon
            // 
            this.tabMuon.Controls.Add(this.btnBoSach);
            this.tabMuon.Controls.Add(this.btnThemSach);
            this.tabMuon.Controls.Add(this.lblSachChon);
            this.tabMuon.Controls.Add(this.dgvSachChon);
            this.tabMuon.Controls.Add(this.lblSachCon);
            this.tabMuon.Controls.Add(this.dgvSachCon);
            this.tabMuon.Controls.Add(this.pnlMuonTop);
            this.tabMuon.Location = new System.Drawing.Point(4, 30);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1178, 646);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;
            // 
            // btnBoSach
            // 
            this.btnBoSach.Location = new System.Drawing.Point(545, 390);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(80, 40);
            this.btnBoSach.TabIndex = 6;
            this.btnBoSach.Text = "<< Bỏ";
            this.btnBoSach.UseVisualStyleBackColor = true;
            this.btnBoSach.Click += new System.EventHandler(this.btnBoSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(545, 330);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(80, 40);
            this.btnThemSach.TabIndex = 5;
            this.btnThemSach.Text = "Thêm >>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // lblSachChon
            // 
            this.lblSachChon.AutoSize = true;
            this.lblSachChon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSachChon.Location = new System.Drawing.Point(640, 160);
            this.lblSachChon.Name = "lblSachChon";
            this.lblSachChon.Size = new System.Drawing.Size(262, 21);
            this.lblSachChon.TabIndex = 4;
            this.lblSachChon.Text = "Sách chọn mượn (tối đa 3 cuốn):";
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSachChon.Location = new System.Drawing.Point(640, 190);
            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersWidth = 51;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(525, 440);
            this.dgvSachChon.TabIndex = 3;
            // 
            // lblSachCon
            // 
            this.lblSachCon.AutoSize = true;
            this.lblSachCon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSachCon.Location = new System.Drawing.Point(15, 160);
            this.lblSachCon.Name = "lblSachCon";
            this.lblSachCon.Size = new System.Drawing.Size(193, 21);
            this.lblSachCon.TabIndex = 2;
            this.lblSachCon.Text = "Sách còn trong kho (>0):";
            // 
            // dgvSachCon
            // 
            this.dgvSachCon.AllowUserToAddRows = false;
            this.dgvSachCon.AllowUserToDeleteRows = false;
            this.dgvSachCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSachCon.Location = new System.Drawing.Point(15, 190);
            this.dgvSachCon.MultiSelect = false;
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.RowHeadersWidth = 51;
            this.dgvSachCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachCon.Size = new System.Drawing.Size(515, 440);
            this.dgvSachCon.TabIndex = 1;
            // 
            // pnlMuonTop
            // 
            this.pnlMuonTop.Controls.Add(this.btnLapPhieu);
            this.pnlMuonTop.Controls.Add(this.dtHenTra);
            this.pnlMuonTop.Controls.Add(this.lblHenTra);
            this.pnlMuonTop.Controls.Add(this.dtNgayMuon);
            this.pnlMuonTop.Controls.Add(this.lblNgayMuon);
            this.pnlMuonTop.Controls.Add(this.cboNhanVienMuon);
            this.pnlMuonTop.Controls.Add(this.lblNVMuon);
            this.pnlMuonTop.Controls.Add(this.lblTrangThai);
            this.pnlMuonTop.Controls.Add(this.btnKiemTra);
            this.pnlMuonTop.Controls.Add(this.cboDocGia);
            this.pnlMuonTop.Controls.Add(this.lblDocGia);
            this.pnlMuonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMuonTop.Location = new System.Drawing.Point(3, 3);
            this.pnlMuonTop.Name = "pnlMuonTop";
            this.pnlMuonTop.Size = new System.Drawing.Size(1172, 145);
            this.pnlMuonTop.TabIndex = 0;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapPhieu.Location = new System.Drawing.Point(920, 90);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(180, 45);
            this.btnLapPhieu.TabIndex = 10;
            this.btnLapPhieu.Text = "LẬP PHIẾU MƯỢN";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtHenTra
            // 
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHenTra.Location = new System.Drawing.Point(680, 95);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(180, 29);
            this.dtHenTra.TabIndex = 9;
            // 
            // lblHenTra
            // 
            this.lblHenTra.AutoSize = true;
            this.lblHenTra.Location = new System.Drawing.Point(590, 98);
            this.lblHenTra.Name = "lblHenTra";
            this.lblHenTra.Size = new System.Drawing.Size(73, 21);
            this.lblHenTra.TabIndex = 8;
            this.lblHenTra.Text = "Hẹn trả:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(390, 95);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(180, 29);
            this.dtNgayMuon.TabIndex = 7;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(290, 98);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(97, 21);
            this.lblNgayMuon.TabIndex = 6;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // cboNhanVienMuon
            // 
            this.cboNhanVienMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(90, 95);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(180, 29);
            this.cboNhanVienMuon.TabIndex = 5;
            // 
            // lblNVMuon
            // 
            this.lblNVMuon.AutoSize = true;
            this.lblNVMuon.Location = new System.Drawing.Point(10, 98);
            this.lblNVMuon.Name = "lblNVMuon";
            this.lblNVMuon.Size = new System.Drawing.Size(64, 21);
            this.lblNVMuon.TabIndex = 4;
            this.lblNVMuon.Text = "Thủ thư:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThai.Location = new System.Drawing.Point(590, 22);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 21);
            this.lblTrangThai.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(400, 15);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(160, 35);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra điều kiện";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(90, 18);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(280, 29);
            this.cboDocGia.TabIndex = 1;
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(10, 22);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(65, 21);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // tabTra
            // 
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.pnlTraBottom);
            this.tabTra.Controls.Add(this.pnlTraTop);
            this.tabTra.Location = new System.Drawing.Point(4, 30);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1178, 646);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách";
            this.tabTra.UseVisualStyleBackColor = true;
            // 
            // dgvDangMuon
            // 
            this.dgvDangMuon.AllowUserToAddRows = false;
            this.dgvDangMuon.AllowUserToDeleteRows = false;
            this.dgvDangMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangMuon.Location = new System.Drawing.Point(3, 73);
            this.dgvDangMuon.MultiSelect = false;
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.RowHeadersWidth = 51;
            this.dgvDangMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangMuon.Size = new System.Drawing.Size(1172, 490);
            this.dgvDangMuon.TabIndex = 2;
            // 
            // pnlTraBottom
            // 
            this.pnlTraBottom.Controls.Add(this.btnTraSach);
            this.pnlTraBottom.Controls.Add(this.numPhiPhat);
            this.pnlTraBottom.Controls.Add(this.lblPhiPhat);
            this.pnlTraBottom.Controls.Add(this.cboTinhTrang);
            this.pnlTraBottom.Controls.Add(this.lblTinhTrang);
            this.pnlTraBottom.Controls.Add(this.dtNgayTra);
            this.pnlTraBottom.Controls.Add(this.lblNgayTra);
            this.pnlTraBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTraBottom.Location = new System.Drawing.Point(3, 563);
            this.pnlTraBottom.Name = "pnlTraBottom";
            this.pnlTraBottom.Size = new System.Drawing.Size(1172, 80);
            this.pnlTraBottom.TabIndex = 1;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.Location = new System.Drawing.Point(930, 18);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(180, 45);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "XÁC NHẬN TRẢ SÁCH";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // numPhiPhat
            // 
            this.numPhiPhat.Location = new System.Drawing.Point(710, 25);
            this.numPhiPhat.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(180, 29);
            this.numPhiPhat.TabIndex = 5;
            this.numPhiPhat.ThousandsSeparator = true;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Location = new System.Drawing.Point(620, 28);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(74, 21);
            this.lblPhiPhat.TabIndex = 4;
            this.lblPhiPhat.Text = "Phí phạt:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(390, 25);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(180, 29);
            this.cboTinhTrang.TabIndex = 3;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(300, 28);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(85, 21);
            this.lblTinhTrang.TabIndex = 2;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(100, 25);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(170, 29);
            this.dtNgayTra.TabIndex = 1;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(10, 28);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(73, 21);
            this.lblNgayTra.TabIndex = 0;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // pnlTraTop
            // 
            this.pnlTraTop.Controls.Add(this.cboNhanVienTra);
            this.pnlTraTop.Controls.Add(this.lblNVTra);
            this.pnlTraTop.Controls.Add(this.btnTaiSachMuon);
            this.pnlTraTop.Controls.Add(this.cboDocGiaTra);
            this.pnlTraTop.Controls.Add(this.lblDocGiaTra);
            this.pnlTraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTraTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTraTop.Name = "pnlTraTop";
            this.pnlTraTop.Size = new System.Drawing.Size(1172, 70);
            this.pnlTraTop.TabIndex = 0;
            // 
            // cboNhanVienTra
            // 
            this.cboNhanVienTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(680, 18);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(200, 29);
            this.cboNhanVienTra.TabIndex = 4;
            // 
            // lblNVTra
            // 
            this.lblNVTra.AutoSize = true;
            this.lblNVTra.Location = new System.Drawing.Point(590, 22);
            this.lblNVTra.Name = "lblNVTra";
            this.lblNVTra.Size = new System.Drawing.Size(78, 21);
            this.lblNVTra.TabIndex = 3;
            this.lblNVTra.Text = "NV nhận:";
            // 
            // btnTaiSachMuon
            // 
            this.btnTaiSachMuon.Location = new System.Drawing.Point(390, 15);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(160, 35);
            this.btnTaiSachMuon.TabIndex = 2;
            this.btnTaiSachMuon.Text = "Tải sách đang mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            this.btnTaiSachMuon.Click += new System.EventHandler(this.btnTaiSachMuon_Click);
            // 
            // cboDocGiaTra
            // 
            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(90, 18);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(280, 29);
            this.cboDocGiaTra.TabIndex = 1;
            this.cboDocGiaTra.SelectedIndexChanged += new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);
            // 
            // lblDocGiaTra
            // 
            this.lblDocGiaTra.AutoSize = true;
            this.lblDocGiaTra.Location = new System.Drawing.Point(10, 22);
            this.lblDocGiaTra.Name = "lblDocGiaTra";
            this.lblDocGiaTra.Size = new System.Drawing.Size(65, 21);
            this.lblDocGiaTra.TabIndex = 0;
            this.lblDocGiaTra.Text = "Độc giả:";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1078, 705);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 45);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 765);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.FrmMuonTra_Load);
            this.tabs.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            this.pnlMuonTop.ResumeLayout(false);
            this.pnlMuonTop.PerformLayout();
            this.tabTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.pnlTraBottom.ResumeLayout(false);
            this.pnlTraBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();
            this.pnlTraTop.ResumeLayout(false);
            this.pnlTraTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.Panel pnlMuonTop;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNVMuon;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label lblHenTra;
        private System.Windows.Forms.DateTimePicker dtHenTra;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblSachCon;
        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.Label lblSachChon;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.Panel pnlTraTop;
        private System.Windows.Forms.Label lblDocGiaTra;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.Button btnTaiSachMuon;
        private System.Windows.Forms.Label lblNVTra;
        private System.Windows.Forms.ComboBox cboNhanVienTra;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.Panel pnlTraBottom;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.NumericUpDown numPhiPhat;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnDong;
    }
}
