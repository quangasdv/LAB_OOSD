namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmKhamBenh
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
            this.grpChonDotKham = new System.Windows.Forms.GroupBox();
            this.btnTaoDotMoi = new System.Windows.Forms.Button();
            this.lblThongTinBenhNhan = new System.Windows.Forms.Label();
            this.cboDotDieuTri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSinhHieu = new System.Windows.Forms.GroupBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNhipTho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpKhamBenh = new System.Windows.Forms.GroupBox();
            this.cboHuongXuLy = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaICD10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChanDoanXacDinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtChanDoanSoBo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numLanKham = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiDinhXN = new System.Windows.Forms.Button();
            this.btnKeToaThuoc = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSuKham = new System.Windows.Forms.DataGridView();
            this.grpChonDotKham.SuspendLayout();
            this.grpSinhHieu.SuspendLayout();
            this.grpKhamBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLanKham)).BeginInit();
            this.grpLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).BeginInit();
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
            this.lblHeader.Text = "KHÁM BỆNH & GHI NHẬN TRIỆU CHỨNG LÂM SÀNG";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChonDotKham
            // 
            this.grpChonDotKham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChonDotKham.Controls.Add(this.btnTaoDotMoi);
            this.grpChonDotKham.Controls.Add(this.lblThongTinBenhNhan);
            this.grpChonDotKham.Controls.Add(this.cboDotDieuTri);
            this.grpChonDotKham.Controls.Add(this.label2);
            this.grpChonDotKham.Controls.Add(this.cboHoSo);
            this.grpChonDotKham.Controls.Add(this.label1);
            this.grpChonDotKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonDotKham.Location = new System.Drawing.Point(12, 53);
            this.grpChonDotKham.Name = "grpChonDotKham";
            this.grpChonDotKham.Size = new System.Drawing.Size(1010, 68);
            this.grpChonDotKham.TabIndex = 1;
            this.grpChonDotKham.TabStop = false;
            this.grpChonDotKham.Text = "Chọn Hồ sơ & Đợt điều trị";
            // 
            // btnTaoDotMoi
            // 
            this.btnTaoDotMoi.Location = new System.Drawing.Point(552, 25);
            this.btnTaoDotMoi.Name = "btnTaoDotMoi";
            this.btnTaoDotMoi.Size = new System.Drawing.Size(110, 29);
            this.btnTaoDotMoi.TabIndex = 5;
            this.btnTaoDotMoi.Text = "+ Đợt điều trị";
            this.btnTaoDotMoi.UseVisualStyleBackColor = true;
            this.btnTaoDotMoi.Click += new System.EventHandler(this.btnTaoDotMoi_Click);
            // 
            // lblThongTinBenhNhan
            // 
            this.lblThongTinBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongTinBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinBenhNhan.ForeColor = System.Drawing.Color.Navy;
            this.lblThongTinBenhNhan.Location = new System.Drawing.Point(672, 23);
            this.lblThongTinBenhNhan.Name = "lblThongTinBenhNhan";
            this.lblThongTinBenhNhan.Size = new System.Drawing.Size(325, 32);
            this.lblThongTinBenhNhan.TabIndex = 4;
            this.lblThongTinBenhNhan.Text = "Bệnh nhân: Chưa chọn";
            this.lblThongTinBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDotDieuTri
            // 
            this.cboDotDieuTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDotDieuTri.FormattingEnabled = true;
            this.cboDotDieuTri.Location = new System.Drawing.Point(365, 27);
            this.cboDotDieuTri.Name = "cboDotDieuTri";
            this.cboDotDieuTri.Size = new System.Drawing.Size(180, 24);
            this.cboDotDieuTri.TabIndex = 3;
            this.cboDotDieuTri.SelectedIndexChanged += new System.EventHandler(this.cboDotDieuTri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đợt điều trị:";
            // 
            // cboHoSo
            // 
            this.cboHoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSo.FormattingEnabled = true;
            this.cboHoSo.Location = new System.Drawing.Point(92, 27);
            this.cboHoSo.Name = "cboHoSo";
            this.cboHoSo.Size = new System.Drawing.Size(180, 24);
            this.cboHoSo.TabIndex = 1;
            this.cboHoSo.SelectedIndexChanged += new System.EventHandler(this.cboHoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hồ sơ bệnh:";
            // 
            // grpSinhHieu
            // 
            this.grpSinhHieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSinhHieu.Controls.Add(this.lblBMI);
            this.grpSinhHieu.Controls.Add(this.txtChieuCao);
            this.grpSinhHieu.Controls.Add(this.label10);
            this.grpSinhHieu.Controls.Add(this.txtCanNang);
            this.grpSinhHieu.Controls.Add(this.label9);
            this.grpSinhHieu.Controls.Add(this.txtNhipTho);
            this.grpSinhHieu.Controls.Add(this.label8);
            this.grpSinhHieu.Controls.Add(this.txtMach);
            this.grpSinhHieu.Controls.Add(this.label7);
            this.grpSinhHieu.Controls.Add(this.txtHuyetAp);
            this.grpSinhHieu.Controls.Add(this.label6);
            this.grpSinhHieu.Controls.Add(this.txtNhietDo);
            this.grpSinhHieu.Controls.Add(this.label5);
            this.grpSinhHieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSinhHieu.Location = new System.Drawing.Point(12, 127);
            this.grpSinhHieu.Name = "grpSinhHieu";
            this.grpSinhHieu.Size = new System.Drawing.Size(1010, 68);
            this.grpSinhHieu.TabIndex = 2;
            this.grpSinhHieu.TabStop = false;
            this.grpSinhHieu.Text = "Chỉ số sinh hiệu cơ bản";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBMI.Location = new System.Drawing.Point(892, 30);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(65, 17);
            this.lblBMI.TabIndex = 12;
            this.lblBMI.Text = "BMI: --.-";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(798, 27);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(75, 24);
            this.txtChieuCao.TabIndex = 11;
            this.txtChieuCao.Text = "165";
            this.txtChieuCao.TextChanged += new System.EventHandler(this.TinhBMI);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "C.Cao (cm):";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(642, 27);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(75, 24);
            this.txtCanNang.TabIndex = 9;
            this.txtCanNang.Text = "60";
            this.txtCanNang.TextChanged += new System.EventHandler(this.TinhBMI);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "C.Nặng (kg):";
            // 
            // txtNhipTho
            // 
            this.txtNhipTho.Location = new System.Drawing.Point(495, 27);
            this.txtNhipTho.Name = "txtNhipTho";
            this.txtNhipTho.Size = new System.Drawing.Size(65, 24);
            this.txtNhipTho.TabIndex = 7;
            this.txtNhipTho.Text = "18";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nhịp thở:";
            // 
            // txtMach
            // 
            this.txtMach.Location = new System.Drawing.Point(352, 27);
            this.txtMach.Name = "txtMach";
            this.txtMach.Size = new System.Drawing.Size(65, 24);
            this.txtMach.TabIndex = 5;
            this.txtMach.Text = "78";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mạch (l/p):";
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(198, 27);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(70, 24);
            this.txtHuyetAp.TabIndex = 3;
            this.txtHuyetAp.Text = "120/80";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Huyết áp:";
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(74, 27);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(55, 24);
            this.txtNhietDo.TabIndex = 1;
            this.txtNhietDo.Text = "37.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhiệt độ:";
            // 
            // grpKhamBenh
            // 
            this.grpKhamBenh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKhamBenh.Controls.Add(this.cboHuongXuLy);
            this.grpKhamBenh.Controls.Add(this.label16);
            this.grpKhamBenh.Controls.Add(this.txtMaICD10);
            this.grpKhamBenh.Controls.Add(this.label15);
            this.grpKhamBenh.Controls.Add(this.txtChanDoanXacDinh);
            this.grpKhamBenh.Controls.Add(this.label14);
            this.grpKhamBenh.Controls.Add(this.txtChanDoanSoBo);
            this.grpKhamBenh.Controls.Add(this.label13);
            this.grpKhamBenh.Controls.Add(this.txtTrieuChung);
            this.grpKhamBenh.Controls.Add(this.label12);
            this.grpKhamBenh.Controls.Add(this.numLanKham);
            this.grpKhamBenh.Controls.Add(this.label11);
            this.grpKhamBenh.Controls.Add(this.cboBacSi);
            this.grpKhamBenh.Controls.Add(this.label4);
            this.grpKhamBenh.Controls.Add(this.dtpNgayKham);
            this.grpKhamBenh.Controls.Add(this.label3);
            this.grpKhamBenh.Controls.Add(this.txtMaPhieuKham);
            this.grpKhamBenh.Controls.Add(this.label17);
            this.grpKhamBenh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhamBenh.Location = new System.Drawing.Point(12, 201);
            this.grpKhamBenh.Name = "grpKhamBenh";
            this.grpKhamBenh.Size = new System.Drawing.Size(1010, 185);
            this.grpKhamBenh.TabIndex = 3;
            this.grpKhamBenh.TabStop = false;
            this.grpKhamBenh.Text = "Nội dung khám & Chẩn đoán y khoa";
            // 
            // cboHuongXuLy
            // 
            this.cboHuongXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHuongXuLy.FormattingEnabled = true;
            this.cboHuongXuLy.Items.AddRange(new object[] {
            "Kê toa về điều trị ngoại trú",
            "Chỉ định làm cận lâm sàng / xét nghiệm bổ sung",
            "Chuyển nhập viện điều trị nội trú",
            "Chuyển viện tuyến trên",
            "Hẹn tái khám định kỳ"});
            this.cboHuongXuLy.Location = new System.Drawing.Point(630, 148);
            this.cboHuongXuLy.Name = "cboHuongXuLy";
            this.cboHuongXuLy.Size = new System.Drawing.Size(367, 24);
            this.cboHuongXuLy.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(545, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Hướng xử lý:";
            // 
            // txtMaICD10
            // 
            this.txtMaICD10.Location = new System.Drawing.Point(120, 148);
            this.txtMaICD10.Name = "txtMaICD10";
            this.txtMaICD10.Size = new System.Drawing.Size(152, 24);
            this.txtMaICD10.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Mã bệnh ICD10:";
            // 
            // txtChanDoanXacDinh
            // 
            this.txtChanDoanXacDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChanDoanXacDinh.Location = new System.Drawing.Point(630, 115);
            this.txtChanDoanXacDinh.Name = "txtChanDoanXacDinh";
            this.txtChanDoanXacDinh.Size = new System.Drawing.Size(367, 24);
            this.txtChanDoanXacDinh.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Chẩn đoán xác định:";
            // 
            // txtChanDoanSoBo
            // 
            this.txtChanDoanSoBo.Location = new System.Drawing.Point(120, 115);
            this.txtChanDoanSoBo.Name = "txtChanDoanSoBo";
            this.txtChanDoanSoBo.Size = new System.Drawing.Size(370, 24);
            this.txtChanDoanSoBo.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Chẩn đoán sơ bộ:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrieuChung.Location = new System.Drawing.Point(120, 60);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrieuChung.Size = new System.Drawing.Size(877, 48);
            this.txtTrieuChung.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Triệu chứng:";
            // 
            // numLanKham
            // 
            this.numLanKham.Location = new System.Drawing.Point(920, 26);
            this.numLanKham.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLanKham.Name = "numLanKham";
            this.numLanKham.Size = new System.Drawing.Size(77, 24);
            this.numLanKham.TabIndex = 7;
            this.numLanKham.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(852, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lần khám:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(630, 26);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(210, 24);
            this.cboBacSi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bác sĩ khám:";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(365, 26);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(160, 24);
            this.dtpNgayKham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày khám:";
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Location = new System.Drawing.Point(120, 26);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.ReadOnly = true;
            this.txtMaPhieuKham.Size = new System.Drawing.Size(152, 24);
            this.txtMaPhieuKham.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã phiếu khám:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(12, 395);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 32);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(113, 395);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(234, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 32);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa phiếu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiDinhXN
            // 
            this.btnChiDinhXN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiDinhXN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiDinhXN.ForeColor = System.Drawing.Color.Indigo;
            this.btnChiDinhXN.Location = new System.Drawing.Point(620, 395);
            this.btnChiDinhXN.Name = "btnChiDinhXN";
            this.btnChiDinhXN.Size = new System.Drawing.Size(145, 32);
            this.btnChiDinhXN.TabIndex = 7;
            this.btnChiDinhXN.Text = "→ Chỉ định XN";
            this.btnChiDinhXN.UseVisualStyleBackColor = true;
            this.btnChiDinhXN.Click += new System.EventHandler(this.btnChiDinhXN_Click);
            // 
            // btnKeToaThuoc
            // 
            this.btnKeToaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeToaThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeToaThuoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnKeToaThuoc.Location = new System.Drawing.Point(771, 395);
            this.btnKeToaThuoc.Name = "btnKeToaThuoc";
            this.btnKeToaThuoc.Size = new System.Drawing.Size(145, 32);
            this.btnKeToaThuoc.TabIndex = 8;
            this.btnKeToaThuoc.Text = "→ Kê toa thuốc";
            this.btnKeToaThuoc.UseVisualStyleBackColor = true;
            this.btnKeToaThuoc.Click += new System.EventHandler(this.btnKeToaThuoc_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(922, 395);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpLichSu
            // 
            this.grpLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLichSu.Controls.Add(this.dgvLichSuKham);
            this.grpLichSu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLichSu.Location = new System.Drawing.Point(12, 433);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(1010, 240);
            this.grpLichSu.TabIndex = 10;
            this.grpLichSu.TabStop = false;
            this.grpLichSu.Text = "Danh sách phiếu khám bệnh của đợt điều trị";
            // 
            // dgvLichSuKham
            // 
            this.dgvLichSuKham.AllowUserToAddRows = false;
            this.dgvLichSuKham.AllowUserToDeleteRows = false;
            this.dgvLichSuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuKham.Location = new System.Drawing.Point(3, 20);
            this.dgvLichSuKham.MultiSelect = false;
            this.dgvLichSuKham.Name = "dgvLichSuKham";
            this.dgvLichSuKham.ReadOnly = true;
            this.dgvLichSuKham.RowHeadersVisible = false;
            this.dgvLichSuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuKham.Size = new System.Drawing.Size(1004, 217);
            this.dgvLichSuKham.TabIndex = 0;
            this.dgvLichSuKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuKham_CellClick);
            // 
            // FrmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 685);
            this.Controls.Add(this.grpLichSu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKeToaThuoc);
            this.Controls.Add(this.btnChiDinhXN);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grpKhamBenh);
            this.Controls.Add(this.grpSinhHieu);
            this.Controls.Add(this.grpChonDotKham);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống khám bệnh & Ghi nhận triệu chứng lâm sàng";
            this.Load += new System.EventHandler(this.FrmKhamBenh_Load);
            this.grpChonDotKham.ResumeLayout(false);
            this.grpChonDotKham.PerformLayout();
            this.grpSinhHieu.ResumeLayout(false);
            this.grpSinhHieu.PerformLayout();
            this.grpKhamBenh.ResumeLayout(false);
            this.grpKhamBenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLanKham)).EndInit();
            this.grpLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpChonDotKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDotDieuTri;
        private System.Windows.Forms.Label lblThongTinBenhNhan;
        private System.Windows.Forms.Button btnTaoDotMoi;
        private System.Windows.Forms.GroupBox grpSinhHieu;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhipTho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.GroupBox grpKhamBenh;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numLanKham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChanDoanSoBo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtChanDoanXacDinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaICD10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboHuongXuLy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiDinhXN;
        private System.Windows.Forms.Button btnKeToaThuoc;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.DataGridView dgvLichSuKham;
    }
}
