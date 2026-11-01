namespace QuanLyDuLich.Forms
{
    partial class FrmThongKe
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblKpiTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTitleCard1 = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblKpiDoan = new System.Windows.Forms.Label();
            this.lblTitleCard2 = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblKpiLe = new System.Windows.Forms.Label();
            this.lblTitleCard3 = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblKpiKhach = new System.Windows.Forms.Label();
            this.lblTitleCard4 = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.dgvTourRevenue = new System.Windows.Forms.DataGridView();
            this.tabHDV = new System.Windows.Forms.TabPage();
            this.dgvHDVRevenue = new System.Windows.Forms.DataGridView();
            this.pnlFilterHDV = new System.Windows.Forms.Panel();
            this.btnTinhLuongHDV = new System.Windows.Forms.Button();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.lblThang = new System.Windows.Forms.Label();
            this.tabGiaoDich = new System.Windows.Forms.TabPage();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourRevenue)).BeginInit();
            this.tabHDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDVRevenue)).BeginInit();
            this.pnlFilterHDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            this.tabGiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
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
            this.lblSubTitle.Size = new System.Drawing.Size(653, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Thống kê doanh thu khách đoàn, khách lẻ, cọc đã thu, bảng tính lương & thù lao h" +
    "ướng dẫn viên theo thời gian";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ DOANH THU & HOẠT ĐỘNG TOUR";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.btnLamMoi);
            this.pnlFilter.Controls.Add(this.btnXemBaoCao);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Location = new System.Drawing.Point(12, 70);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(994, 42);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(545, 6);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 28);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnXemBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(420, 6);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(115, 28);
            this.btnXemBaoCao.TabIndex = 4;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(280, 8);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(215, 12);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(66, 17);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(75, 8);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 24);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(12, 12);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(58, 17);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlCard1.Controls.Add(this.lblKpiTongDoanhThu);
            this.pnlCard1.Controls.Add(this.lblTitleCard1);
            this.pnlCard1.Location = new System.Drawing.Point(12, 118);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(240, 75);
            this.pnlCard1.TabIndex = 2;
            // 
            // lblKpiTongDoanhThu
            // 
            this.lblKpiTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiTongDoanhThu.ForeColor = System.Drawing.Color.Gold;
            this.lblKpiTongDoanhThu.Location = new System.Drawing.Point(10, 35);
            this.lblKpiTongDoanhThu.Name = "lblKpiTongDoanhThu";
            this.lblKpiTongDoanhThu.Size = new System.Drawing.Size(220, 28);
            this.lblKpiTongDoanhThu.TabIndex = 1;
            this.lblKpiTongDoanhThu.Text = "0 VNĐ";
            // 
            // lblTitleCard1
            // 
            this.lblTitleCard1.AutoSize = true;
            this.lblTitleCard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleCard1.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard1.Location = new System.Drawing.Point(10, 10);
            this.lblTitleCard1.Name = "lblTitleCard1";
            this.lblTitleCard1.Size = new System.Drawing.Size(149, 15);
            this.lblTitleCard1.TabIndex = 0;
            this.lblTitleCard1.Text = "TỔNG DOANH THU TOUR";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlCard2.Controls.Add(this.lblKpiDoan);
            this.pnlCard2.Controls.Add(this.lblTitleCard2);
            this.pnlCard2.Location = new System.Drawing.Point(262, 118);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(240, 75);
            this.pnlCard2.TabIndex = 3;
            // 
            // lblKpiDoan
            // 
            this.lblKpiDoan.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiDoan.ForeColor = System.Drawing.Color.White;
            this.lblKpiDoan.Location = new System.Drawing.Point(10, 35);
            this.lblKpiDoan.Name = "lblKpiDoan";
            this.lblKpiDoan.Size = new System.Drawing.Size(220, 28);
            this.lblKpiDoan.TabIndex = 1;
            this.lblKpiDoan.Text = "0 VNĐ";
            // 
            // lblTitleCard2
            // 
            this.lblTitleCard2.AutoSize = true;
            this.lblTitleCard2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleCard2.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard2.Location = new System.Drawing.Point(10, 10);
            this.lblTitleCard2.Name = "lblTitleCard2";
            this.lblTitleCard2.Size = new System.Drawing.Size(168, 15);
            this.lblTitleCard2.TabIndex = 0;
            this.lblTitleCard2.Text = "DOANH THU KHÁCH ĐOÀN";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.pnlCard3.Controls.Add(this.lblKpiLe);
            this.pnlCard3.Controls.Add(this.lblTitleCard3);
            this.pnlCard3.Location = new System.Drawing.Point(512, 118);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(240, 75);
            this.pnlCard3.TabIndex = 4;
            // 
            // lblKpiLe
            // 
            this.lblKpiLe.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiLe.ForeColor = System.Drawing.Color.White;
            this.lblKpiLe.Location = new System.Drawing.Point(10, 35);
            this.lblKpiLe.Name = "lblKpiLe";
            this.lblKpiLe.Size = new System.Drawing.Size(220, 28);
            this.lblKpiLe.TabIndex = 1;
            this.lblKpiLe.Text = "0 VNĐ";
            // 
            // lblTitleCard3
            // 
            this.lblTitleCard3.AutoSize = true;
            this.lblTitleCard3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleCard3.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard3.Location = new System.Drawing.Point(10, 10);
            this.lblTitleCard3.Name = "lblTitleCard3";
            this.lblTitleCard3.Size = new System.Drawing.Size(175, 15);
            this.lblTitleCard3.TabIndex = 0;
            this.lblTitleCard3.Text = "DOANH THU VÉ CHUYẾN LẺ";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlCard4.Controls.Add(this.lblKpiKhach);
            this.pnlCard4.Controls.Add(this.lblTitleCard4);
            this.pnlCard4.Location = new System.Drawing.Point(762, 118);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(244, 75);
            this.pnlCard4.TabIndex = 5;
            // 
            // lblKpiKhach
            // 
            this.lblKpiKhach.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiKhach.ForeColor = System.Drawing.Color.White;
            this.lblKpiKhach.Location = new System.Drawing.Point(10, 35);
            this.lblKpiKhach.Name = "lblKpiKhach";
            this.lblKpiKhach.Size = new System.Drawing.Size(225, 28);
            this.lblKpiKhach.TabIndex = 1;
            this.lblKpiKhach.Text = "0 Khách";
            // 
            // lblTitleCard4
            // 
            this.lblTitleCard4.AutoSize = true;
            this.lblTitleCard4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleCard4.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard4.Location = new System.Drawing.Point(10, 10);
            this.lblTitleCard4.Name = "lblTitleCard4";
            this.lblTitleCard4.Size = new System.Drawing.Size(155, 15);
            this.lblTitleCard4.TabIndex = 0;
            this.lblTitleCard4.Text = "TỔNG SỐ KHÁCH ĐÃ ĐI";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabTour);
            this.tabThongKe.Controls.Add(this.tabHDV);
            this.tabThongKe.Controls.Add(this.tabGiaoDich);
            this.tabThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabThongKe.Location = new System.Drawing.Point(12, 202);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(994, 428);
            this.tabThongKe.TabIndex = 6;
            // 
            // tabTour
            // 
            this.tabTour.BackColor = System.Drawing.Color.White;
            this.tabTour.Controls.Add(this.dgvTourRevenue);
            this.tabTour.Location = new System.Drawing.Point(4, 25);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.Size = new System.Drawing.Size(986, 399);
            this.tabTour.TabIndex = 0;
            this.tabTour.Text = "Báo cáo Doanh thu theo Tour";
            // 
            // dgvTourRevenue
            // 
            this.dgvTourRevenue.AllowUserToAddRows = false;
            this.dgvTourRevenue.AllowUserToDeleteRows = false;
            this.dgvTourRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvTourRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTourRevenue.Location = new System.Drawing.Point(3, 3);
            this.dgvTourRevenue.MultiSelect = false;
            this.dgvTourRevenue.Name = "dgvTourRevenue";
            this.dgvTourRevenue.ReadOnly = true;
            this.dgvTourRevenue.RowHeadersWidth = 30;
            this.dgvTourRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTourRevenue.Size = new System.Drawing.Size(980, 393);
            this.dgvTourRevenue.TabIndex = 0;
            // 
            // tabHDV
            // 
            this.tabHDV.BackColor = System.Drawing.Color.White;
            this.tabHDV.Controls.Add(this.dgvHDVRevenue);
            this.tabHDV.Controls.Add(this.pnlFilterHDV);
            this.tabHDV.Location = new System.Drawing.Point(4, 25);
            this.tabHDV.Name = "tabHDV";
            this.tabHDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabHDV.Size = new System.Drawing.Size(986, 399);
            this.tabHDV.TabIndex = 1;
            this.tabHDV.Text = "Bảng tính Lương & Thù lao Hướng Dẫn Viên";
            // 
            // dgvHDVRevenue
            // 
            this.dgvHDVRevenue.AllowUserToAddRows = false;
            this.dgvHDVRevenue.AllowUserToDeleteRows = false;
            this.dgvHDVRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDVRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDVRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDVRevenue.Location = new System.Drawing.Point(3, 43);
            this.dgvHDVRevenue.MultiSelect = false;
            this.dgvHDVRevenue.Name = "dgvHDVRevenue";
            this.dgvHDVRevenue.ReadOnly = true;
            this.dgvHDVRevenue.RowHeadersWidth = 30;
            this.dgvHDVRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDVRevenue.Size = new System.Drawing.Size(980, 353);
            this.dgvHDVRevenue.TabIndex = 1;
            // 
            // pnlFilterHDV
            // 
            this.pnlFilterHDV.Controls.Add(this.btnTinhLuongHDV);
            this.pnlFilterHDV.Controls.Add(this.numNam);
            this.pnlFilterHDV.Controls.Add(this.lblNam);
            this.pnlFilterHDV.Controls.Add(this.numThang);
            this.pnlFilterHDV.Controls.Add(this.lblThang);
            this.pnlFilterHDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterHDV.Location = new System.Drawing.Point(3, 3);
            this.pnlFilterHDV.Name = "pnlFilterHDV";
            this.pnlFilterHDV.Size = new System.Drawing.Size(980, 40);
            this.pnlFilterHDV.TabIndex = 0;
            // 
            // btnTinhLuongHDV
            // 
            this.btnTinhLuongHDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnTinhLuongHDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuongHDV.FlatAppearance.BorderSize = 0;
            this.btnTinhLuongHDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuongHDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhLuongHDV.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuongHDV.Location = new System.Drawing.Point(335, 6);
            this.btnTinhLuongHDV.Name = "btnTinhLuongHDV";
            this.btnTinhLuongHDV.Size = new System.Drawing.Size(130, 28);
            this.btnTinhLuongHDV.TabIndex = 4;
            this.btnTinhLuongHDV.Text = "Tính bảng lương";
            this.btnTinhLuongHDV.UseVisualStyleBackColor = false;
            this.btnTinhLuongHDV.Click += new System.EventHandler(this.btnTinhLuongHDV_Click);
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(225, 8);
            this.numNam.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            this.numNam.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(80, 24);
            this.numNam.TabIndex = 3;
            this.numNam.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(180, 11);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // numThang
            // 
            this.numThang.Location = new System.Drawing.Point(100, 8);
            this.numThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThang.Name = "numThang";
            this.numThang.Size = new System.Drawing.Size(60, 24);
            this.numThang.TabIndex = 1;
            this.numThang.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(15, 11);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(79, 17);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Chọn tháng:";
            // 
            // tabGiaoDich
            // 
            this.tabGiaoDich.BackColor = System.Drawing.Color.White;
            this.tabGiaoDich.Controls.Add(this.dgvGiaoDich);
            this.tabGiaoDich.Location = new System.Drawing.Point(4, 25);
            this.tabGiaoDich.Name = "tabGiaoDich";
            this.tabGiaoDich.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiaoDich.Size = new System.Drawing.Size(986, 399);
            this.tabGiaoDich.TabIndex = 2;
            this.tabGiaoDich.Text = "Nhật ký Giao dịch Đoàn & Vé Chuyến lẻ";
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.AllowUserToAddRows = false;
            this.dgvGiaoDich.AllowUserToDeleteRows = false;
            this.dgvGiaoDich.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoDich.Location = new System.Drawing.Point(3, 3);
            this.dgvGiaoDich.MultiSelect = false;
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.ReadOnly = true;
            this.dgvGiaoDich.RowHeadersWidth = 30;
            this.dgvGiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDich.Size = new System.Drawing.Size(980, 393);
            this.dgvGiaoDich.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(906, 638);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1018, 680);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.pnlCard4);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard1);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Thống kê Doanh thu & Tình hình Tour - Văn Hóa Việt TP.HCM";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.tabTour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourRevenue)).EndInit();
            this.tabHDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDVRevenue)).EndInit();
            this.pnlFilterHDV.ResumeLayout(false);
            this.pnlFilterHDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            this.tabGiaoDich.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTitleCard1;
        private System.Windows.Forms.Label lblKpiTongDoanhThu;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblTitleCard2;
        private System.Windows.Forms.Label lblKpiDoan;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblTitleCard3;
        private System.Windows.Forms.Label lblKpiLe;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblTitleCard4;
        private System.Windows.Forms.Label lblKpiKhach;
        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.DataGridView dgvTourRevenue;
        private System.Windows.Forms.TabPage tabHDV;
        private System.Windows.Forms.Panel pnlFilterHDV;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnTinhLuongHDV;
        private System.Windows.Forms.DataGridView dgvHDVRevenue;
        private System.Windows.Forms.TabPage tabGiaoDich;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.Button btnDong;
    }
}
