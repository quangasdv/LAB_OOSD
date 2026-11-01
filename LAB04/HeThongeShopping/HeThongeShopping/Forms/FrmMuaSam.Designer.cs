namespace HeThongeShopping.Forms
{
    partial class FrmMuaSam
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
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhomSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhomSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTienHanhDatHang = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.btnXoaItem = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colMaSPGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSPGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSanPham
            // 
            this.grpSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSanPham.Controls.Add(this.btnThemVaoGio);
            this.grpSanPham.Controls.Add(this.numSoLuong);
            this.grpSanPham.Controls.Add(this.label3);
            this.grpSanPham.Controls.Add(this.dgvSanPham);
            this.grpSanPham.Controls.Add(this.btnTatCa);
            this.grpSanPham.Controls.Add(this.btnTimKiem);
            this.grpSanPham.Controls.Add(this.txtTimKiem);
            this.grpSanPham.Controls.Add(this.label2);
            this.grpSanPham.Controls.Add(this.cboNhomSP);
            this.grpSanPham.Controls.Add(this.label1);
            this.grpSanPham.Location = new System.Drawing.Point(12, 12);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Size = new System.Drawing.Size(910, 280);
            this.grpSanPham.TabIndex = 0;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "Danh mục sản phẩm e-Shopping";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGio.Location = new System.Drawing.Point(730, 235);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(160, 35);
            this.btnThemVaoGio.TabIndex = 9;
            this.btnThemVaoGio.Text = "+ Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(640, 241);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(70, 24);
            this.numSoLuong.TabIndex = 8;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng mua:";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colNhomSP,
            this.colDonGia,
            this.colTonKho,
            this.colMoTa});
            this.dgvSanPham.Location = new System.Drawing.Point(15, 65);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 35;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(875, 160);
            this.dgvSanPham.TabIndex = 6;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSanPham";
            this.colMaSP.FillWeight = 15F;
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSanPham";
            this.colTenSP.FillWeight = 35F;
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colNhomSP
            // 
            this.colNhomSP.DataPropertyName = "NhomSanPham";
            this.colNhomSP.FillWeight = 25F;
            this.colNhomSP.HeaderText = "Nhóm hàng";
            this.colNhomSP.Name = "colNhomSP";
            this.colNhomSP.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDonGia.FillWeight = 20F;
            this.colDonGia.HeaderText = "Đơn giá (đ)";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colTonKho
            // 
            this.colTonKho.DataPropertyName = "TonKho";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTonKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTonKho.FillWeight = 15F;
            this.colTonKho.HeaderText = "Tồn kho";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.FillWeight = 30F;
            this.colMoTa.HeaderText = "Mô tả sản phẩm";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(680, 24);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(90, 30);
            this.btnTatCa.TabIndex = 5;
            this.btnTatCa.Text = "Xem tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(580, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(380, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(185, 24);
            this.txtTimKiem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa:";
            // 
            // cboNhomSP
            // 
            this.cboNhomSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomSP.FormattingEnabled = true;
            this.cboNhomSP.Location = new System.Drawing.Point(100, 27);
            this.cboNhomSP.Name = "cboNhomSP";
            this.cboNhomSP.Size = new System.Drawing.Size(200, 25);
            this.cboNhomSP.TabIndex = 1;
            this.cboNhomSP.SelectedIndexChanged += new System.EventHandler(this.cboNhomSP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm hàng:";
            // 
            // grpGioHang
            // 
            this.grpGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGioHang.Controls.Add(this.btnDong);
            this.grpGioHang.Controls.Add(this.btnTienHanhDatHang);
            this.grpGioHang.Controls.Add(this.lblTongTien);
            this.grpGioHang.Controls.Add(this.btnXoaHet);
            this.grpGioHang.Controls.Add(this.btnXoaItem);
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Location = new System.Drawing.Point(12, 305);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Size = new System.Drawing.Size(910, 270);
            this.grpGioHang.TabIndex = 1;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "Giỏ hàng hiện tại của bạn";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(795, 220);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 38);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTienHanhDatHang
            // 
            this.btnTienHanhDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTienHanhDatHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienHanhDatHang.Location = new System.Drawing.Point(565, 220);
            this.btnTienHanhDatHang.Name = "btnTienHanhDatHang";
            this.btnTienHanhDatHang.Size = new System.Drawing.Size(220, 38);
            this.btnTienHanhDatHang.TabIndex = 4;
            this.btnTienHanhDatHang.Text = "Tiến hành Đặt Hàng >>";
            this.btnTienHanhDatHang.UseVisualStyleBackColor = true;
            this.btnTienHanhDatHang.Click += new System.EventHandler(this.btnTienHanhDatHang_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(260, 228);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(155, 21);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tạm tính: 0 đ";
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaHet.Location = new System.Drawing.Point(135, 222);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(100, 35);
            this.btnXoaHet.TabIndex = 2;
            this.btnXoaHet.Text = "Xóa tất cả";
            this.btnXoaHet.UseVisualStyleBackColor = true;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaItem.Location = new System.Drawing.Point(15, 222);
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(110, 35);
            this.btnXoaItem.TabIndex = 1;
            this.btnXoaItem.Text = "Xóa sản phẩm";
            this.btnXoaItem.UseVisualStyleBackColor = true;
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSPGio,
            this.colTenSPGio,
            this.colDonGiaGio,
            this.colSoLuongGio,
            this.colThanhTienGio});
            this.dgvGioHang.Location = new System.Drawing.Point(15, 30);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersWidth = 35;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(875, 180);
            this.dgvGioHang.TabIndex = 0;
            // 
            // colMaSPGio
            // 
            this.colMaSPGio.DataPropertyName = "MaSanPham";
            this.colMaSPGio.FillWeight = 20F;
            this.colMaSPGio.HeaderText = "Mã SP";
            this.colMaSPGio.Name = "colMaSPGio";
            this.colMaSPGio.ReadOnly = true;
            // 
            // colTenSPGio
            // 
            this.colTenSPGio.DataPropertyName = "TenSanPham";
            this.colTenSPGio.FillWeight = 45F;
            this.colTenSPGio.HeaderText = "Tên sản phẩm";
            this.colTenSPGio.Name = "colTenSPGio";
            this.colTenSPGio.ReadOnly = true;
            // 
            // colDonGiaGio
            // 
            this.colDonGiaGio.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colDonGiaGio.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGiaGio.FillWeight = 20F;
            this.colDonGiaGio.HeaderText = "Đơn giá (đ)";
            this.colDonGiaGio.Name = "colDonGiaGio";
            this.colDonGiaGio.ReadOnly = true;
            // 
            // colSoLuongGio
            // 
            this.colSoLuongGio.DataPropertyName = "SoLuong";
            this.colSoLuongGio.FillWeight = 15F;
            this.colSoLuongGio.HeaderText = "Số lượng";
            this.colSoLuongGio.Name = "colSoLuongGio";
            this.colSoLuongGio.ReadOnly = true;
            // 
            // colThanhTienGio
            // 
            this.colThanhTienGio.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colThanhTienGio.DefaultCellStyle = dataGridViewCellStyle4;
            this.colThanhTienGio.FillWeight = 25F;
            this.colThanhTienGio.HeaderText = "Thành tiền (đ)";
            this.colThanhTienGio.Name = "colThanhTienGio";
            this.colThanhTienGio.ReadOnly = true;
            // 
            // FrmMuaSam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 591);
            this.Controls.Add(this.grpGioHang);
            this.Controls.Add(this.grpSanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMuaSam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duyệt sản phẩm & Quản lý giỏ hàng e-Shopping";
            this.Load += new System.EventHandler(this.FrmMuaSam_Load);
            this.grpSanPham.ResumeLayout(false);
            this.grpSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpGioHang.ResumeLayout(false);
            this.grpGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.ComboBox cboNhomSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaItem;
        private System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTienHanhDatHang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhomSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSPGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSPGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienGio;
    }
}
