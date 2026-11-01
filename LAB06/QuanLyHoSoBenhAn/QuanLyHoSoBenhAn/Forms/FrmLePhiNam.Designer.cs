namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLePhiNam
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
            this.grpThuPhi = new System.Windows.Forms.GroupBox();
            this.txtNguoiThu = new System.Windows.Forms.TextBox();
            this.lblNguoiThu = new System.Windows.Forms.Label();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.lblHinhThucTT = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThu = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.numNamThu = new System.Windows.Forms.NumericUpDown();
            this.lblNamThu = new System.Windows.Forms.Label();
            this.cboBenhNhan = new System.Windows.Forms.ComboBox();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.txtMaLePhi = new System.Windows.Forms.TextBox();
            this.lblMaLePhi = new System.Windows.Forms.Label();
            this.btnThuPhi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvLePhi = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThuPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamThu)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePhi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(960, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ LỆ PHÍ HẰNG NĂM & GIA HẠN THẺ HỘI VIÊN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThuPhi
            // 
            this.grpThuPhi.Controls.Add(this.btnLamMoi);
            this.grpThuPhi.Controls.Add(this.btnThuPhi);
            this.grpThuPhi.Controls.Add(this.txtNguoiThu);
            this.grpThuPhi.Controls.Add(this.lblNguoiThu);
            this.grpThuPhi.Controls.Add(this.cboHinhThucTT);
            this.grpThuPhi.Controls.Add(this.lblHinhThucTT);
            this.grpThuPhi.Controls.Add(this.dtpNgayHetHan);
            this.grpThuPhi.Controls.Add(this.lblNgayHetHan);
            this.grpThuPhi.Controls.Add(this.dtpNgayThu);
            this.grpThuPhi.Controls.Add(this.lblNgayThu);
            this.grpThuPhi.Controls.Add(this.txtSoTien);
            this.grpThuPhi.Controls.Add(this.lblSoTien);
            this.grpThuPhi.Controls.Add(this.numNamThu);
            this.grpThuPhi.Controls.Add(this.lblNamThu);
            this.grpThuPhi.Controls.Add(this.cboBenhNhan);
            this.grpThuPhi.Controls.Add(this.lblBenhNhan);
            this.grpThuPhi.Controls.Add(this.txtMaLePhi);
            this.grpThuPhi.Controls.Add(this.lblMaLePhi);
            this.grpThuPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThuPhi.Location = new System.Drawing.Point(12, 47);
            this.grpThuPhi.Name = "grpThuPhi";
            this.grpThuPhi.Size = new System.Drawing.Size(960, 160);
            this.grpThuPhi.TabIndex = 1;
            this.grpThuPhi.TabStop = false;
            this.grpThuPhi.Text = "Thông tin Thu phí / Gia hạn Lệ phí 1 năm";
            // 
            // txtNguoiThu
            // 
            this.txtNguoiThu.Location = new System.Drawing.Point(620, 78);
            this.txtNguoiThu.Name = "txtNguoiThu";
            this.txtNguoiThu.Size = new System.Drawing.Size(180, 24);
            this.txtNguoiThu.TabIndex = 15;
            this.txtNguoiThu.Text = "Thu ngân";
            // 
            // lblNguoiThu
            // 
            this.lblNguoiThu.AutoSize = true;
            this.lblNguoiThu.Location = new System.Drawing.Point(525, 81);
            this.lblNguoiThu.Name = "lblNguoiThu";
            this.lblNguoiThu.Size = new System.Drawing.Size(70, 17);
            this.lblNguoiThu.TabIndex = 14;
            this.lblNguoiThu.Text = "Người thu:";
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucTT.FormattingEnabled = true;
            this.cboHinhThucTT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ POS"});
            this.cboHinhThucTT.Location = new System.Drawing.Point(365, 78);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(140, 24);
            this.cboHinhThucTT.TabIndex = 13;
            // 
            // lblHinhThucTT
            // 
            this.lblHinhThucTT.AutoSize = true;
            this.lblHinhThucTT.Location = new System.Drawing.Point(270, 81);
            this.lblHinhThucTT.Name = "lblHinhThucTT";
            this.lblHinhThucTT.Size = new System.Drawing.Size(89, 17);
            this.lblHinhThucTT.TabIndex = 12;
            this.lblHinhThucTT.Text = "Hình thức TT:";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(115, 78);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayHetHan.TabIndex = 11;
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Location = new System.Drawing.Point(20, 81);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(89, 17);
            this.lblNgayHetHan.TabIndex = 10;
            this.lblNgayHetHan.Text = "Hạn dùng (1n):";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(740, 33);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(120, 24);
            this.dtpNgayThu.TabIndex = 9;
            this.dtpNgayThu.ValueChanged += new System.EventHandler(this.dtpNgayThu_ValueChanged);
            // 
            // lblNgayThu
            // 
            this.lblNgayThu.AutoSize = true;
            this.lblNgayThu.Location = new System.Drawing.Point(670, 36);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(65, 17);
            this.lblNgayThu.TabIndex = 8;
            this.lblNgayThu.Text = "Ngày thu:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(545, 33);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(105, 24);
            this.txtSoTien.TabIndex = 7;
            this.txtSoTien.Text = "200,000";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(475, 36);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(64, 17);
            this.lblSoTien.TabIndex = 6;
            this.lblSoTien.Text = "Số tiền đ:";
            // 
            // numNamThu
            // 
            this.numNamThu.Location = new System.Drawing.Point(395, 33);
            this.numNamThu.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            this.numNamThu.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            this.numNamThu.Name = "numNamThu";
            this.numNamThu.Size = new System.Drawing.Size(65, 24);
            this.numNamThu.TabIndex = 5;
            this.numNamThu.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblNamThu
            // 
            this.lblNamThu.AutoSize = true;
            this.lblNamThu.Location = new System.Drawing.Point(330, 36);
            this.lblNamThu.Name = "lblNamThu";
            this.lblNamThu.Size = new System.Drawing.Size(63, 17);
            this.lblNamThu.TabIndex = 4;
            this.lblNamThu.Text = "Năm thu:";
            // 
            // cboBenhNhan
            // 
            this.cboBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBenhNhan.FormattingEnabled = true;
            this.cboBenhNhan.Location = new System.Drawing.Point(115, 33);
            this.cboBenhNhan.Name = "cboBenhNhan";
            this.cboBenhNhan.Size = new System.Drawing.Size(200, 24);
            this.cboBenhNhan.TabIndex = 3;
            this.cboBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cboBenhNhan_SelectedIndexChanged);
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Location = new System.Drawing.Point(20, 36);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(73, 17);
            this.lblBenhNhan.TabIndex = 2;
            this.lblBenhNhan.Text = "Bệnh nhân:";
            // 
            // txtMaLePhi
            // 
            this.txtMaLePhi.Location = new System.Drawing.Point(820, 78);
            this.txtMaLePhi.Name = "txtMaLePhi";
            this.txtMaLePhi.ReadOnly = true;
            this.txtMaLePhi.Size = new System.Drawing.Size(120, 24);
            this.txtMaLePhi.TabIndex = 1;
            // 
            // lblMaLePhi
            // 
            this.lblMaLePhi.AutoSize = true;
            this.lblMaLePhi.Location = new System.Drawing.Point(820, 60);
            this.lblMaLePhi.Name = "lblMaLePhi";
            this.lblMaLePhi.Size = new System.Drawing.Size(68, 17);
            this.lblMaLePhi.TabIndex = 0;
            this.lblMaLePhi.Text = "Mã lệ phí:";
            // 
            // btnThuPhi
            // 
            this.btnThuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThuPhi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuPhi.FlatAppearance.BorderSize = 0;
            this.btnThuPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThuPhi.ForeColor = System.Drawing.Color.White;
            this.btnThuPhi.Location = new System.Drawing.Point(115, 115);
            this.btnThuPhi.Name = "btnThuPhi";
            this.btnThuPhi.Size = new System.Drawing.Size(200, 32);
            this.btnThuPhi.TabIndex = 16;
            this.btnThuPhi.Text = "Thu tiền / Gia hạn 1 năm";
            this.btnThuPhi.UseVisualStyleBackColor = false;
            this.btnThuPhi.Click += new System.EventHandler(this.btnThuPhi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(330, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 32);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvLePhi);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 215);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(960, 385);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Lịch sử nộp Lệ phí & Tình trạng Hạn sử dụng Hội viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(435, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 28);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(165, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 24);
            this.txtTimKiem.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 28);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(139, 17);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm theo Mã BN / Tên:";
            // 
            // dgvLePhi
            // 
            this.dgvLePhi.AllowUserToAddRows = false;
            this.dgvLePhi.AllowUserToDeleteRows = false;
            this.dgvLePhi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLePhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLePhi.Location = new System.Drawing.Point(15, 60);
            this.dgvLePhi.MultiSelect = false;
            this.dgvLePhi.Name = "dgvLePhi";
            this.dgvLePhi.ReadOnly = true;
            this.dgvLePhi.RowHeadersWidth = 30;
            this.dgvLePhi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLePhi.Size = new System.Drawing.Size(930, 310);
            this.dgvLePhi.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(872, 608);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmLePhiNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpThuPhi);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLePhiNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lệ phí hằng năm - Bệnh viện Đa khoa Quốc tế";
            this.Load += new System.EventHandler(this.FrmLePhiNam_Load);
            this.grpThuPhi.ResumeLayout(false);
            this.grpThuPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamThu)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpThuPhi;
        private System.Windows.Forms.TextBox txtMaLePhi;
        private System.Windows.Forms.Label lblMaLePhi;
        private System.Windows.Forms.ComboBox cboBenhNhan;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.NumericUpDown numNamThu;
        private System.Windows.Forms.Label lblNamThu;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label lblNgayThu;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.Label lblHinhThucTT;
        private System.Windows.Forms.TextBox txtNguoiThu;
        private System.Windows.Forms.Label lblNguoiThu;
        private System.Windows.Forms.Button btnThuPhi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLePhi;
        private System.Windows.Forms.Button btnDong;
    }
}
