namespace HeThongeShopping.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.grpTongHop = new System.Windows.Forms.GroupBox();
            this.lblDonHuy = new System.Windows.Forms.Label();
            this.lblDonCho = new System.Windows.Forms.Label();
            this.lblDonThanhCong = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.tabChiTiet = new System.Windows.Forms.TabControl();
            this.tabSP = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabThe = new System.Windows.Forms.TabPage();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.colLoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTienThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLePhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpTongHop.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            this.tabSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabThe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(95, 22);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(150, 24);
            this.dtTu.TabIndex = 1;
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(340, 22);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(150, 24);
            this.dtDen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(520, 18);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 32);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Xem Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // grpTongHop
            // 
            this.grpTongHop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTongHop.Controls.Add(this.lblDonHuy);
            this.grpTongHop.Controls.Add(this.lblDonCho);
            this.grpTongHop.Controls.Add(this.lblDonThanhCong);
            this.grpTongHop.Controls.Add(this.lblTongDoanhThu);
            this.grpTongHop.Controls.Add(this.lblTongDon);
            this.grpTongHop.Location = new System.Drawing.Point(15, 60);
            this.grpTongHop.Name = "grpTongHop";
            this.grpTongHop.Size = new System.Drawing.Size(875, 115);
            this.grpTongHop.TabIndex = 5;
            this.grpTongHop.TabStop = false;
            this.grpTongHop.Text = "Chỉ số tổng hợp kinh doanh";
            // 
            // lblDonHuy
            // 
            this.lblDonHuy.AutoSize = true;
            this.lblDonHuy.Location = new System.Drawing.Point(580, 75);
            this.lblDonHuy.Name = "lblDonHuy";
            this.lblDonHuy.Size = new System.Drawing.Size(107, 17);
            this.lblDonHuy.TabIndex = 4;
            this.lblDonHuy.Text = "Đơn đã hủy: 0";
            // 
            // lblDonCho
            // 
            this.lblDonCho.AutoSize = true;
            this.lblDonCho.Location = new System.Drawing.Point(580, 35);
            this.lblDonCho.Name = "lblDonCho";
            this.lblDonCho.Size = new System.Drawing.Size(117, 17);
            this.lblDonCho.TabIndex = 3;
            this.lblDonCho.Text = "Đơn chờ xử lý: 0";
            // 
            // lblDonThanhCong
            // 
            this.lblDonThanhCong.AutoSize = true;
            this.lblDonThanhCong.Location = new System.Drawing.Point(280, 35);
            this.lblDonThanhCong.Name = "lblDonThanhCong";
            this.lblDonThanhCong.Size = new System.Drawing.Size(175, 17);
            this.lblDonThanhCong.TabIndex = 2;
            this.lblDonThanhCong.Text = "Đơn xác nhận / hoàn tất: 0";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(25, 72);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(169, 20);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0 đ";
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDon.Location = new System.Drawing.Point(25, 33);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(155, 19);
            this.lblTongDon.TabIndex = 0;
            this.lblTongDon.Text = "Tổng số đơn hàng: 0";
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabChiTiet.Controls.Add(this.tabSP);
            this.tabChiTiet.Controls.Add(this.tabThe);
            this.tabChiTiet.Location = new System.Drawing.Point(15, 190);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.SelectedIndex = 0;
            this.tabChiTiet.Size = new System.Drawing.Size(875, 310);
            this.tabChiTiet.TabIndex = 6;
            // 
            // tabSP
            // 
            this.tabSP.Controls.Add(this.dgvSanPham);
            this.tabSP.Location = new System.Drawing.Point(4, 26);
            this.tabSP.Name = "tabSP";
            this.tabSP.Padding = new System.Windows.Forms.Padding(10);
            this.tabSP.Size = new System.Drawing.Size(867, 280);
            this.tabSP.TabIndex = 0;
            this.tabSP.Text = "Sản phẩm bán chạy nhất";
            this.tabSP.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colSL,
            this.colDoanhThu});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 10);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 35;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(847, 260);
            this.dgvSanPham.TabIndex = 0;
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
            // colSL
            // 
            this.colSL.DataPropertyName = "TongSoLuong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSL.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSL.FillWeight = 15F;
            this.colSL.HeaderText = "Số lượng đã bán";
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.DataPropertyName = "TongDoanhThu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colDoanhThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDoanhThu.FillWeight = 20F;
            this.colDoanhThu.HeaderText = "Doanh thu (đ)";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // tabThe
            // 
            this.tabThe.Controls.Add(this.dgvThe);
            this.tabThe.Location = new System.Drawing.Point(4, 26);
            this.tabThe.Name = "tabThe";
            this.tabThe.Padding = new System.Windows.Forms.Padding(10);
            this.tabThe.Size = new System.Drawing.Size(867, 280);
            this.tabThe.TabIndex = 1;
            this.tabThe.Text = "Thống kê thanh toán thẻ tín dụng";
            this.tabThe.UseVisualStyleBackColor = true;
            // 
            // dgvThe
            // 
            this.dgvThe.AllowUserToAddRows = false;
            this.dgvThe.AllowUserToDeleteRows = false;
            this.dgvThe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoaiThe,
            this.colSoGD,
            this.colTongTienThe,
            this.colLePhi});
            this.dgvThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThe.Location = new System.Drawing.Point(10, 10);
            this.dgvThe.MultiSelect = false;
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.ReadOnly = true;
            this.dgvThe.RowHeadersWidth = 35;
            this.dgvThe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThe.Size = new System.Drawing.Size(847, 260);
            this.dgvThe.TabIndex = 0;
            // 
            // colLoaiThe
            // 
            this.colLoaiThe.DataPropertyName = "LoaiThe";
            this.colLoaiThe.FillWeight = 25F;
            this.colLoaiThe.HeaderText = "Loại thẻ thanh toán";
            this.colLoaiThe.Name = "colLoaiThe";
            this.colLoaiThe.ReadOnly = true;
            // 
            // colSoGD
            // 
            this.colSoGD.DataPropertyName = "SoGiaoDich";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoGD.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSoGD.FillWeight = 20F;
            this.colSoGD.HeaderText = "Số lượt thanh toán";
            this.colSoGD.Name = "colSoGD";
            this.colSoGD.ReadOnly = true;
            // 
            // colTongTienThe
            // 
            this.colTongTienThe.DataPropertyName = "TongGiaTri";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colTongTienThe.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTongTienThe.FillWeight = 30F;
            this.colTongTienThe.HeaderText = "Tổng giá trị (đ)";
            this.colTongTienThe.Name = "colTongTienThe";
            this.colTongTienThe.ReadOnly = true;
            // 
            // colLePhi
            // 
            this.colLePhi.DataPropertyName = "TongLePhi";
            this.colLePhi.FillWeight = 25F;
            this.colLePhi.HeaderText = "Lệ phí thẻ thu được (đ)";
            this.colLePhi.Name = "colLePhi";
            this.colLePhi.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(770, 510);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 38);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabChiTiet);
            this.Controls.Add(this.grpTongHop);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo Thống kê Đơn hàng & Doanh thu e-Shopping";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.grpTongHop.ResumeLayout(false);
            this.grpTongHop.PerformLayout();
            this.tabChiTiet.ResumeLayout(false);
            this.tabSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabThe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grpTongHop;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblDonThanhCong;
        private System.Windows.Forms.Label lblDonCho;
        private System.Windows.Forms.Label lblDonHuy;
        private System.Windows.Forms.TabControl tabChiTiet;
        private System.Windows.Forms.TabPage tabSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TabPage tabThe;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTienThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLePhi;
    }
}
