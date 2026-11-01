namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmHoSoBenhAn
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
            this.grpTraCuu = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.grpBiaHoSo = new System.Windows.Forms.GroupBox();
            this.lblDiUng = new System.Windows.Forms.Label();
            this.txtDiUngThuoc = new System.Windows.Forms.TextBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboNhomMau = new System.Windows.Forms.ComboBox();
            this.lblNhomMau = new System.Windows.Forms.Label();
            this.txtThongTinBN = new System.Windows.Forms.TextBox();
            this.lblThongTinBN = new System.Windows.Forms.Label();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.grpLyLich = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtThuocDaDung = new System.Windows.Forms.TextBox();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.txtBenhManTinh = new System.Windows.Forms.TextBox();
            this.lblBenhManTinh = new System.Windows.Forms.Label();
            this.txtTienSuBenh = new System.Windows.Forms.TextBox();
            this.lblTienSu = new System.Windows.Forms.Label();
            this.grpLichSuKham = new System.Windows.Forms.GroupBox();
            this.dgvLichSuKham = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpTraCuu.SuspendLayout();
            this.grpBiaHoSo.SuspendLayout();
            this.grpLyLich.SuspendLayout();
            this.grpLichSuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(976, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN & LÝ LỊCH BỆNH DÀI HẠN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTraCuu
            // 
            this.grpTraCuu.Controls.Add(this.btnLamMoi);
            this.grpTraCuu.Controls.Add(this.btnTimKiem);
            this.grpTraCuu.Controls.Add(this.txtTimKiem);
            this.grpTraCuu.Controls.Add(this.lblTimKiem);
            this.grpTraCuu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpTraCuu.Location = new System.Drawing.Point(12, 47);
            this.grpTraCuu.Name = "grpTraCuu";
            this.grpTraCuu.Size = new System.Drawing.Size(976, 52);
            this.grpTraCuu.TabIndex = 1;
            this.grpTraCuu.TabStop = false;
            this.grpTraCuu.Text = "Tra cứu nhanh hồ sơ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(540, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 26);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tra cứu";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(220, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(310, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 22);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(194, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Nhập Mã HS / Mã BN / Tên / SĐT:";
            // 
            // grpBiaHoSo
            // 
            this.grpBiaHoSo.Controls.Add(this.lblDiUng);
            this.grpBiaHoSo.Controls.Add(this.txtDiUngThuoc);
            this.grpBiaHoSo.Controls.Add(this.cboTinhTrang);
            this.grpBiaHoSo.Controls.Add(this.lblTinhTrang);
            this.grpBiaHoSo.Controls.Add(this.cboNhomMau);
            this.grpBiaHoSo.Controls.Add(this.lblNhomMau);
            this.grpBiaHoSo.Controls.Add(this.txtThongTinBN);
            this.grpBiaHoSo.Controls.Add(this.lblThongTinBN);
            this.grpBiaHoSo.Controls.Add(this.dtpNgayCap);
            this.grpBiaHoSo.Controls.Add(this.lblNgayCap);
            this.grpBiaHoSo.Controls.Add(this.txtMaHoSo);
            this.grpBiaHoSo.Controls.Add(this.lblMaHoSo);
            this.grpBiaHoSo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpBiaHoSo.Location = new System.Drawing.Point(12, 105);
            this.grpBiaHoSo.Name = "grpBiaHoSo";
            this.grpBiaHoSo.Size = new System.Drawing.Size(976, 140);
            this.grpBiaHoSo.TabIndex = 2;
            this.grpBiaHoSo.TabStop = false;
            this.grpBiaHoSo.Text = "Trang bìa Hồ sơ bệnh án";
            // 
            // lblDiUng
            // 
            this.lblDiUng.AutoSize = true;
            this.lblDiUng.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiUng.ForeColor = System.Drawing.Color.Red;
            this.lblDiUng.Location = new System.Drawing.Point(20, 102);
            this.lblDiUng.Name = "lblDiUng";
            this.lblDiUng.Size = new System.Drawing.Size(186, 17);
            this.lblDiUng.TabIndex = 11;
            this.lblDiUng.Text = "CẢNH BÁO DỊ ỨNG THUỐC:";
            // 
            // txtDiUngThuoc
            // 
            this.txtDiUngThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtDiUngThuoc.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDiUngThuoc.Location = new System.Drawing.Point(215, 99);
            this.txtDiUngThuoc.Name = "txtDiUngThuoc";
            this.txtDiUngThuoc.Size = new System.Drawing.Size(745, 24);
            this.txtDiUngThuoc.TabIndex = 10;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Đang theo dõi",
            "Đã kết thúc",
            "Lưu trữ"});
            this.cboTinhTrang.Location = new System.Drawing.Point(825, 63);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(135, 24);
            this.cboTinhTrang.TabIndex = 9;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(750, 66);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(70, 17);
            this.lblTinhTrang.TabIndex = 8;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // cboNhomMau
            // 
            this.cboNhomMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomMau.FormattingEnabled = true;
            this.cboNhomMau.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cboNhomMau.Location = new System.Drawing.Point(650, 63);
            this.cboNhomMau.Name = "cboNhomMau";
            this.cboNhomMau.Size = new System.Drawing.Size(80, 24);
            this.cboNhomMau.TabIndex = 7;
            // 
            // lblNhomMau
            // 
            this.lblNhomMau.AutoSize = true;
            this.lblNhomMau.Location = new System.Drawing.Point(565, 66);
            this.lblNhomMau.Name = "lblNhomMau";
            this.lblNhomMau.Size = new System.Drawing.Size(76, 17);
            this.lblNhomMau.TabIndex = 6;
            this.lblNhomMau.Text = "Nhóm máu:";
            // 
            // txtThongTinBN
            // 
            this.txtThongTinBN.Location = new System.Drawing.Point(115, 63);
            this.txtThongTinBN.Name = "txtThongTinBN";
            this.txtThongTinBN.ReadOnly = true;
            this.txtThongTinBN.Size = new System.Drawing.Size(435, 24);
            this.txtThongTinBN.TabIndex = 5;
            // 
            // lblThongTinBN
            // 
            this.lblThongTinBN.AutoSize = true;
            this.lblThongTinBN.Location = new System.Drawing.Point(20, 66);
            this.lblThongTinBN.Name = "lblThongTinBN";
            this.lblThongTinBN.Size = new System.Drawing.Size(73, 17);
            this.lblThongTinBN.TabIndex = 4;
            this.lblThongTinBN.Text = "Bệnh nhân:";
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCap.Location = new System.Drawing.Point(365, 25);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayCap.TabIndex = 3;
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(290, 28);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(67, 17);
            this.lblNgayCap.TabIndex = 2;
            this.lblNgayCap.Text = "Ngày cấp:";
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtMaHoSo.Location = new System.Drawing.Point(115, 25);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.ReadOnly = true;
            this.txtMaHoSo.Size = new System.Drawing.Size(150, 24);
            this.txtMaHoSo.TabIndex = 1;
            // 
            // lblMaHoSo
            // 
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Location = new System.Drawing.Point(20, 28);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Size = new System.Drawing.Size(67, 17);
            this.lblMaHoSo.TabIndex = 0;
            this.lblMaHoSo.Text = "Mã hồ sơ:";
            // 
            // grpLyLich
            // 
            this.grpLyLich.Controls.Add(this.btnLuu);
            this.grpLyLich.Controls.Add(this.txtThuocDaDung);
            this.grpLyLich.Controls.Add(this.lblThuoc);
            this.grpLyLich.Controls.Add(this.txtBenhManTinh);
            this.grpLyLich.Controls.Add(this.lblBenhManTinh);
            this.grpLyLich.Controls.Add(this.txtTienSuBenh);
            this.grpLyLich.Controls.Add(this.lblTienSu);
            this.grpLyLich.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpLyLich.Location = new System.Drawing.Point(12, 251);
            this.grpLyLich.Name = "grpLyLich";
            this.grpLyLich.Size = new System.Drawing.Size(976, 155);
            this.grpLyLich.TabIndex = 3;
            this.grpLyLich.TabStop = false;
            this.grpLyLich.Text = "Lý lịch bệnh lý bản thân & gia đình";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(795, 115);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(165, 30);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Cập nhật Hồ Sơ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtThuocDaDung
            // 
            this.txtThuocDaDung.Location = new System.Drawing.Point(155, 85);
            this.txtThuocDaDung.Name = "txtThuocDaDung";
            this.txtThuocDaDung.Size = new System.Drawing.Size(805, 24);
            this.txtThuocDaDung.TabIndex = 5;
            // 
            // lblThuoc
            // 
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Location = new System.Drawing.Point(20, 88);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(127, 17);
            this.lblThuoc.TabIndex = 4;
            this.lblThuoc.Text = "Thuốc từng điều trị:";
            // 
            // txtBenhManTinh
            // 
            this.txtBenhManTinh.Location = new System.Drawing.Point(155, 55);
            this.txtBenhManTinh.Name = "txtBenhManTinh";
            this.txtBenhManTinh.Size = new System.Drawing.Size(805, 24);
            this.txtBenhManTinh.TabIndex = 3;
            // 
            // lblBenhManTinh
            // 
            this.lblBenhManTinh.AutoSize = true;
            this.lblBenhManTinh.Location = new System.Drawing.Point(20, 58);
            this.lblBenhManTinh.Name = "lblBenhManTinh";
            this.lblBenhManTinh.Size = new System.Drawing.Size(95, 17);
            this.lblBenhManTinh.TabIndex = 2;
            this.lblBenhManTinh.Text = "Bệnh mạn tính:";
            // 
            // txtTienSuBenh
            // 
            this.txtTienSuBenh.Location = new System.Drawing.Point(155, 25);
            this.txtTienSuBenh.Name = "txtTienSuBenh";
            this.txtTienSuBenh.Size = new System.Drawing.Size(805, 24);
            this.txtTienSuBenh.TabIndex = 1;
            // 
            // lblTienSu
            // 
            this.lblTienSu.AutoSize = true;
            this.lblTienSu.Location = new System.Drawing.Point(20, 28);
            this.lblTienSu.Name = "lblTienSu";
            this.lblTienSu.Size = new System.Drawing.Size(128, 17);
            this.lblTienSu.TabIndex = 0;
            this.lblTienSu.Text = "Tiền sử bệnh lý (BT):";
            // 
            // grpLichSuKham
            // 
            this.grpLichSuKham.Controls.Add(this.dgvLichSuKham);
            this.grpLichSuKham.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpLichSuKham.Location = new System.Drawing.Point(12, 412);
            this.grpLichSuKham.Name = "grpLichSuKham";
            this.grpLichSuKham.Size = new System.Drawing.Size(976, 215);
            this.grpLichSuKham.TabIndex = 4;
            this.grpLichSuKham.TabStop = false;
            this.grpLichSuKham.Text = "Chuỗi lịch sử các đợt khám / điều trị (Các trang trong của Hồ sơ bệnh án)";
            // 
            // dgvLichSuKham
            // 
            this.dgvLichSuKham.AllowUserToAddRows = false;
            this.dgvLichSuKham.AllowUserToDeleteRows = false;
            this.dgvLichSuKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuKham.Location = new System.Drawing.Point(3, 20);
            this.dgvLichSuKham.MultiSelect = false;
            this.dgvLichSuKham.Name = "dgvLichSuKham";
            this.dgvLichSuKham.ReadOnly = true;
            this.dgvLichSuKham.RowHeadersWidth = 30;
            this.dgvLichSuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuKham.Size = new System.Drawing.Size(970, 192);
            this.dgvLichSuKham.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDong.Location = new System.Drawing.Point(888, 635);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(640, 18);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 26);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FrmHoSoBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpLichSuKham);
            this.Controls.Add(this.grpLyLich);
            this.Controls.Add(this.grpBiaHoSo);
            this.Controls.Add(this.grpTraCuu);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmHoSoBenhAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hồ sơ Bệnh án & Lý lịch bệnh nhân - Bệnh viện Đa khoa Quốc tế";
            this.Load += new System.EventHandler(this.FrmHoSoBenhAn_Load);
            this.grpTraCuu.ResumeLayout(false);
            this.grpTraCuu.PerformLayout();
            this.grpBiaHoSo.ResumeLayout(false);
            this.grpBiaHoSo.PerformLayout();
            this.grpLyLich.ResumeLayout(false);
            this.grpLyLich.PerformLayout();
            this.grpLichSuKham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpTraCuu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpBiaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.TextBox txtThongTinBN;
        private System.Windows.Forms.Label lblThongTinBN;
        private System.Windows.Forms.ComboBox cboNhomMau;
        private System.Windows.Forms.Label lblNhomMau;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtDiUngThuoc;
        private System.Windows.Forms.Label lblDiUng;
        private System.Windows.Forms.GroupBox grpLyLich;
        private System.Windows.Forms.TextBox txtTienSuBenh;
        private System.Windows.Forms.Label lblTienSu;
        private System.Windows.Forms.TextBox txtBenhManTinh;
        private System.Windows.Forms.Label lblBenhManTinh;
        private System.Windows.Forms.TextBox txtThuocDaDung;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grpLichSuKham;
        private System.Windows.Forms.DataGridView dgvLichSuKham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
