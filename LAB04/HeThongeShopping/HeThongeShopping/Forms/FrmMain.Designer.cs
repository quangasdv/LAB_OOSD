namespace HeThongeShopping.Forms
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnMuaSam = new System.Windows.Forms.Button();
            this.btnQuanLyDonHang = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnCauHinh = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG CỬA HÀNG ONLINE E-SHOPPING";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(130, 110);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(240, 50);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập / Đăng ký";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnMuaSam
            // 
            this.btnMuaSam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaSam.Location = new System.Drawing.Point(130, 180);
            this.btnMuaSam.Name = "btnMuaSam";
            this.btnMuaSam.Size = new System.Drawing.Size(240, 50);
            this.btnMuaSam.TabIndex = 4;
            this.btnMuaSam.Text = "Duyệt SP & Giỏ hàng";
            this.btnMuaSam.UseVisualStyleBackColor = true;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(130, 250);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(240, 50);
            this.btnDatHang.TabIndex = 1;
            this.btnDatHang.Text = "Đặt Mua Hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnQuanLyDonHang
            // 
            this.btnQuanLyDonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDonHang.Location = new System.Drawing.Point(410, 110);
            this.btnQuanLyDonHang.Name = "btnQuanLyDonHang";
            this.btnQuanLyDonHang.Size = new System.Drawing.Size(240, 50);
            this.btnQuanLyDonHang.TabIndex = 5;
            this.btnQuanLyDonHang.Text = "Quản lý Đơn hàng";
            this.btnQuanLyDonHang.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(410, 180);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(240, 50);
            this.btnQuanLyTaiKhoan.TabIndex = 6;
            this.btnQuanLyTaiKhoan.Text = "Quản lý Tài khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHinh.Location = new System.Drawing.Point(410, 250);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(240, 50);
            this.btnCauHinh.TabIndex = 7;
            this.btnCauHinh.Text = "Cấu hình Hệ thống";
            this.btnCauHinh.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(410, 320);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(240, 50);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Báo cáo Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(270, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(240, 50);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnCauHinh);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Controls.Add(this.btnQuanLyDonHang);
            this.Controls.Add(this.btnMuaSam);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ Admin e-Shopping";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnMuaSam;
        private System.Windows.Forms.Button btnQuanLyDonHang;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnCauHinh;
        private System.Windows.Forms.Button btnThongKe;
    }
}
