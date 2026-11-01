namespace HeThongeShopping.Forms
{
    partial class FrmQuanLyDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.colMaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThaoTac = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXemThanhToan = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.cboTrangThaiMoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDonDangChon = new System.Windows.Forms.Label();
            this.grpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.grpThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoc
            // 
            this.grpLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Controls.Add(this.btnTimKiem);
            this.grpLoc.Controls.Add(this.cboTrangThai);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.txtTimKiem);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Location = new System.Drawing.Point(12, 12);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(950, 65);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "Bộ lọc và tìm kiếm đơn hàng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(750, 23);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 30);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(645, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Chờ xử lý",
            "Đã xác nhận",
            "Đang giao hàng",
            "Hoàn tất",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(450, 26);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(180, 25);
            this.cboTrangThai.TabIndex = 3;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(130, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn/Tên/SĐT:";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDH,
            this.colNgayDat,
            this.colNguoiNhan,
            this.colSDT,
            this.colDiaChi,
            this.colLoaiPhieu,
            this.colTriGia,
            this.colPhiShip,
            this.colTongTien,
            this.colTrangThai});
            this.dgvDonHang.Location = new System.Drawing.Point(12, 85);
            this.dgvDonHang.MultiSelect = false;
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 35;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(950, 240);
            this.dgvDonHang.TabIndex = 1;
            this.dgvDonHang.SelectionChanged += new System.EventHandler(this.dgvDonHang_SelectionChanged);
            // 
            // colMaDH
            // 
            this.colMaDH.DataPropertyName = "MaDonHang";
            this.colMaDH.FillWeight = 15F;
            this.colMaDH.HeaderText = "Mã đơn";
            this.colMaDH.Name = "colMaDH";
            this.colMaDH.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "ThoiDiemDatHang";
            this.colNgayDat.FillWeight = 20F;
            this.colNgayDat.HeaderText = "Thời điểm đặt";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            // 
            // colNguoiNhan
            // 
            this.colNguoiNhan.DataPropertyName = "HoTenNguoiNhan";
            this.colNguoiNhan.FillWeight = 20F;
            this.colNguoiNhan.HeaderText = "Người nhận";
            this.colNguoiNhan.Name = "colNguoiNhan";
            this.colNguoiNhan.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "DienThoaiNhan";
            this.colSDT.FillWeight = 15F;
            this.colSDT.HeaderText = "Điện thoại";
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChiNhan";
            this.colDiaChi.FillWeight = 25F;
            this.colDiaChi.HeaderText = "Địa chỉ nhận";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colLoaiPhieu
            // 
            this.colLoaiPhieu.DataPropertyName = "LoaiPhieuDatHang";
            this.colLoaiPhieu.FillWeight = 15F;
            this.colLoaiPhieu.HeaderText = "Loại phiếu";
            this.colLoaiPhieu.Name = "colLoaiPhieu";
            this.colLoaiPhieu.ReadOnly = true;
            // 
            // colTriGia
            // 
            this.colTriGia.DataPropertyName = "TongTriGia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.colTriGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTriGia.FillWeight = 15F;
            this.colTriGia.HeaderText = "Trị giá";
            this.colTriGia.Name = "colTriGia";
            this.colTriGia.ReadOnly = true;
            // 
            // colPhiShip
            // 
            this.colPhiShip.DataPropertyName = "PhiGiaoHang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colPhiShip.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPhiShip.FillWeight = 12F;
            this.colPhiShip.HeaderText = "Phí ship";
            this.colPhiShip.Name = "colPhiShip";
            this.colPhiShip.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTienThanhToan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.Format = "N0";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTongTien.FillWeight = 18F;
            this.colTongTien.HeaderText = "Tổng thanh toán";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 18F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Location = new System.Drawing.Point(12, 335);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(580, 240);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Sản phẩm trong đơn hàng";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersWidth = 30;
            this.dgvChiTiet.Size = new System.Drawing.Size(574, 217);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSanPham";
            this.colMaSP.FillWeight = 20F;
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSanPham";
            this.colTenSP.FillWeight = 45F;
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDonGia.FillWeight = 20F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.FillWeight = 15F;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.colThanhTien.FillWeight = 25F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // grpThaoTac
            // 
            this.grpThaoTac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThaoTac.Controls.Add(this.btnDong);
            this.grpThaoTac.Controls.Add(this.btnXemThanhToan);
            this.grpThaoTac.Controls.Add(this.btnCapNhatTrangThai);
            this.grpThaoTac.Controls.Add(this.cboTrangThaiMoi);
            this.grpThaoTac.Controls.Add(this.label3);
            this.grpThaoTac.Controls.Add(this.lblDonDangChon);
            this.grpThaoTac.Location = new System.Drawing.Point(605, 335);
            this.grpThaoTac.Name = "grpThaoTac";
            this.grpThaoTac.Size = new System.Drawing.Size(355, 240);
            this.grpThaoTac.TabIndex = 3;
            this.grpThaoTac.TabStop = false;
            this.grpThaoTac.Text = "Thao tác đơn hàng";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(190, 185);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(145, 38);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXemThanhToan
            // 
            this.btnXemThanhToan.Location = new System.Drawing.Point(20, 185);
            this.btnXemThanhToan.Name = "btnXemThanhToan";
            this.btnXemThanhToan.Size = new System.Drawing.Size(155, 38);
            this.btnXemThanhToan.TabIndex = 4;
            this.btnXemThanhToan.Text = "Xem thanh toán thẻ";
            this.btnXemThanhToan.UseVisualStyleBackColor = true;
            this.btnXemThanhToan.Click += new System.EventHandler(this.btnXemThanhToan_Click);
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(20, 125);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(315, 40);
            this.btnCapNhatTrangThai.TabIndex = 3;
            this.btnCapNhatTrangThai.Text = "Lưu cập nhật trạng thái";
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = true;
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            // 
            // cboTrangThaiMoi
            // 
            this.cboTrangThaiMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiMoi.FormattingEnabled = true;
            this.cboTrangThaiMoi.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đã xác nhận",
            "Đang giao hàng",
            "Hoàn tất",
            "Đã hủy"});
            this.cboTrangThaiMoi.Location = new System.Drawing.Point(125, 75);
            this.cboTrangThaiMoi.Name = "cboTrangThaiMoi";
            this.cboTrangThaiMoi.Size = new System.Drawing.Size(210, 25);
            this.cboTrangThaiMoi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái mới:";
            // 
            // lblDonDangChon
            // 
            this.lblDonDangChon.AutoSize = true;
            this.lblDonDangChon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonDangChon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDonDangChon.Location = new System.Drawing.Point(20, 35);
            this.lblDonDangChon.Name = "lblDonDangChon";
            this.lblDonDangChon.Size = new System.Drawing.Size(161, 19);
            this.lblDonDangChon.TabIndex = 0;
            this.lblDonDangChon.Text = "Đơn hàng: [Chưa chọn]";
            // 
            // FrmQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 591);
            this.Controls.Add(this.grpThaoTac);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.grpLoc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmQuanLyDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Đơn đặt hàng & Vận chuyển e-Shopping";
            this.Load += new System.EventHandler(this.FrmQuanLyDonHang_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.grpThaoTac.ResumeLayout(false);
            this.grpThaoTac.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox grpThaoTac;
        private System.Windows.Forms.Label lblDonDangChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTrangThaiMoi;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Button btnXemThanhToan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}
