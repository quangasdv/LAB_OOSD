namespace QuanLyDuLich.Forms
{
    partial class FrmTour
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtDiemXuatPhat = new System.Windows.Forms.TextBox();
            this.lblDiemXuatPhat = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numSoDem = new System.Windows.Forms.NumericUpDown();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.lblMaTour = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTim = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC TOUR DU LỊCH";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnCapNhat);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.txtDiemXuatPhat);
            this.grpThongTin.Controls.Add(this.lblDiemXuatPhat);
            this.grpThongTin.Controls.Add(this.numDonGia);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.numSoDem);
            this.grpThongTin.Controls.Add(this.lblSoDem);
            this.grpThongTin.Controls.Add(this.numSoNgay);
            this.grpThongTin.Controls.Add(this.lblSoNgay);
            this.grpThongTin.Controls.Add(this.txtTenTour);
            this.grpThongTin.Controls.Add(this.lblTenTour);
            this.grpThongTin.Controls.Add(this.txtMaTour);
            this.grpThongTin.Controls.Add(this.lblMaTour);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThongTin.Location = new System.Drawing.Point(12, 65);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(860, 160);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết Tour";
            // 
            // txtDiemXuatPhat
            // 
            this.txtDiemXuatPhat.Location = new System.Drawing.Point(580, 68);
            this.txtDiemXuatPhat.Name = "txtDiemXuatPhat";
            this.txtDiemXuatPhat.Size = new System.Drawing.Size(260, 24);
            this.txtDiemXuatPhat.TabIndex = 11;
            this.txtDiemXuatPhat.Text = "TP.HCM";
            // 
            // lblDiemXuatPhat
            // 
            this.lblDiemXuatPhat.AutoSize = true;
            this.lblDiemXuatPhat.Location = new System.Drawing.Point(475, 71);
            this.lblDiemXuatPhat.Name = "lblDiemXuatPhat";
            this.lblDiemXuatPhat.Size = new System.Drawing.Size(99, 17);
            this.lblDiemXuatPhat.TabIndex = 10;
            this.lblDiemXuatPhat.Text = "Điểm xuất phát:";
            // 
            // numDonGia
            // 
            this.numDonGia.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numDonGia.Location = new System.Drawing.Point(580, 28);
            this.numDonGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(260, 24);
            this.numDonGia.TabIndex = 9;
            this.numDonGia.ThousandsSeparator = true;
            this.numDonGia.Value = new decimal(new int[] { 2500000, 0, 0, 0 });
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(475, 31);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(95, 17);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá (VNĐ):";
            // 
            // numSoDem
            // 
            this.numSoDem.Location = new System.Drawing.Point(280, 108);
            this.numSoDem.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numSoDem.Name = "numSoDem";
            this.numSoDem.Size = new System.Drawing.Size(70, 24);
            this.numSoDem.TabIndex = 7;
            this.numSoDem.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Location = new System.Drawing.Point(215, 111);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(56, 17);
            this.lblSoDem.TabIndex = 6;
            this.lblSoDem.Text = "Số đêm:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(110, 108);
            this.numSoNgay.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(70, 24);
            this.numSoNgay.TabIndex = 5;
            this.numSoNgay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(20, 111);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(58, 17);
            this.lblSoNgay.TabIndex = 4;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(110, 68);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(340, 24);
            this.txtTenTour.TabIndex = 3;
            // 
            // lblTenTour
            // 
            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Location = new System.Drawing.Point(20, 71);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(61, 17);
            this.lblTenTour.TabIndex = 2;
            this.lblTenTour.Text = "Tên Tour:";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(110, 28);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(180, 24);
            this.txtMaTour.TabIndex = 1;
            // 
            // lblMaTour
            // 
            this.lblMaTour.AutoSize = true;
            this.lblMaTour.Location = new System.Drawing.Point(20, 31);
            this.lblMaTour.Name = "lblMaTour";
            this.lblMaTour.Size = new System.Drawing.Size(60, 17);
            this.lblMaTour.TabIndex = 0;
            this.lblMaTour.Text = "Mã Tour:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(475, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 32);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(570, 110);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 32);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(665, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 32);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(760, 110);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 32);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvTour);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.lblTim);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 235);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(860, 260);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách Tour hiện có";
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(10, 60);
            this.dgvTour.MultiSelect = false;
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersWidth = 30;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(840, 190);
            this.dgvTour.TabIndex = 3;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(155, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(445, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(10, 26);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(135, 17);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Tìm theo Mã/Tên tour:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(765, 505);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 32);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tour Du Lịch - Văn Hóa Việt TP.HCM";
            this.Load += new System.EventHandler(this.FrmTour_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.NumericUpDown numSoDem;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblDiemXuatPhat;
        private System.Windows.Forms.TextBox txtDiemXuatPhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Button btnDong;
    }
}
