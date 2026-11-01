namespace HeThongeShopping.Forms
{
    partial class FrmCauHinh
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
            this.grpBieuPhi = new System.Windows.Forms.GroupBox();
            this.numPhiHoaToc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numPhiCPN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPhiThuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFreeship = new System.Windows.Forms.GroupBox();
            this.numMienPhiCPN = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMienPhiThuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.txtEmailAdmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numPhiAmexDiscover = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numPhiVisaMaster = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpBieuPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiHoaToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiCPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiThuong)).BeginInit();
            this.grpFreeship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMienPhiCPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMienPhiThuong)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiAmexDiscover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVisaMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBieuPhi
            // 
            this.grpBieuPhi.Controls.Add(this.numPhiHoaToc);
            this.grpBieuPhi.Controls.Add(this.label3);
            this.grpBieuPhi.Controls.Add(this.numPhiCPN);
            this.grpBieuPhi.Controls.Add(this.label2);
            this.grpBieuPhi.Controls.Add(this.numPhiThuong);
            this.grpBieuPhi.Controls.Add(this.label1);
            this.grpBieuPhi.Location = new System.Drawing.Point(15, 15);
            this.grpBieuPhi.Name = "grpBieuPhi";
            this.grpBieuPhi.Size = new System.Drawing.Size(700, 115);
            this.grpBieuPhi.TabIndex = 0;
            this.grpBieuPhi.TabStop = false;
            this.grpBieuPhi.Text = "Biểu phí 3 loại phiếu đặt hàng (Vận chuyển)";
            // 
            // numPhiHoaToc
            // 
            this.numPhiHoaToc.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPhiHoaToc.Location = new System.Drawing.Point(490, 68);
            this.numPhiHoaToc.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPhiHoaToc.Name = "numPhiHoaToc";
            this.numPhiHoaToc.Size = new System.Drawing.Size(180, 24);
            this.numPhiHoaToc.TabIndex = 5;
            this.numPhiHoaToc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CP Nhanh trong ngày (đ):";
            // 
            // numPhiCPN
            // 
            this.numPhiCPN.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPhiCPN.Location = new System.Drawing.Point(260, 68);
            this.numPhiCPN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPhiCPN.Name = "numPhiCPN";
            this.numPhiCPN.Size = new System.Drawing.Size(180, 24);
            this.numPhiCPN.TabIndex = 3;
            this.numPhiCPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyển phát nhanh (đ):";
            // 
            // numPhiThuong
            // 
            this.numPhiThuong.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPhiThuong.Location = new System.Drawing.Point(30, 68);
            this.numPhiThuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPhiThuong.Name = "numPhiThuong";
            this.numPhiThuong.Size = new System.Drawing.Size(180, 24);
            this.numPhiThuong.TabIndex = 1;
            this.numPhiThuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao hàng thường (đ):";
            // 
            // grpFreeship
            // 
            this.grpFreeship.Controls.Add(this.numMienPhiCPN);
            this.grpFreeship.Controls.Add(this.label4);
            this.grpFreeship.Controls.Add(this.numMienPhiThuong);
            this.grpFreeship.Controls.Add(this.label5);
            this.grpFreeship.Location = new System.Drawing.Point(15, 145);
            this.grpFreeship.Name = "grpFreeship";
            this.grpFreeship.Size = new System.Drawing.Size(700, 105);
            this.grpFreeship.TabIndex = 1;
            this.grpFreeship.TabStop = false;
            this.grpFreeship.Text = "Chính sách Miễn phí giao hàng (Freeship)";
            // 
            // numMienPhiCPN
            // 
            this.numMienPhiCPN.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMienPhiCPN.Location = new System.Drawing.Point(380, 58);
            this.numMienPhiCPN.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numMienPhiCPN.Name = "numMienPhiCPN";
            this.numMienPhiCPN.Size = new System.Drawing.Size(250, 24);
            this.numMienPhiCPN.TabIndex = 3;
            this.numMienPhiCPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn hàng tối thiểu miễn phí CPN (đ):";
            // 
            // numMienPhiThuong
            // 
            this.numMienPhiThuong.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMienPhiThuong.Location = new System.Drawing.Point(30, 58);
            this.numMienPhiThuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numMienPhiThuong.Name = "numMienPhiThuong";
            this.numMienPhiThuong.Size = new System.Drawing.Size(250, 24);
            this.numMienPhiThuong.TabIndex = 1;
            this.numMienPhiThuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn hàng tối thiểu miễn phí Thường (đ):";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.txtEmailAdmin);
            this.grpThanhToan.Controls.Add(this.label8);
            this.grpThanhToan.Controls.Add(this.numPhiAmexDiscover);
            this.grpThanhToan.Controls.Add(this.label6);
            this.grpThanhToan.Controls.Add(this.numPhiVisaMaster);
            this.grpThanhToan.Controls.Add(this.label7);
            this.grpThanhToan.Location = new System.Drawing.Point(15, 265);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(700, 140);
            this.grpThanhToan.TabIndex = 2;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Cổng thanh toán & Tỷ lệ lệ phí thẻ tín dụng";
            // 
            // txtEmailAdmin
            // 
            this.txtEmailAdmin.Location = new System.Drawing.Point(210, 95);
            this.txtEmailAdmin.Name = "txtEmailAdmin";
            this.txtEmailAdmin.Size = new System.Drawing.Size(460, 24);
            this.txtEmailAdmin.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email nhận thông báo hệ thống:";
            // 
            // numPhiAmexDiscover
            // 
            this.numPhiAmexDiscover.DecimalPlaces = 2;
            this.numPhiAmexDiscover.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPhiAmexDiscover.Location = new System.Drawing.Point(520, 48);
            this.numPhiAmexDiscover.Name = "numPhiAmexDiscover";
            this.numPhiAmexDiscover.Size = new System.Drawing.Size(150, 24);
            this.numPhiAmexDiscover.TabIndex = 3;
            this.numPhiAmexDiscover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tỷ lệ Amex/Disc (%):";
            // 
            // numPhiVisaMaster
            // 
            this.numPhiVisaMaster.DecimalPlaces = 2;
            this.numPhiVisaMaster.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPhiVisaMaster.Location = new System.Drawing.Point(210, 48);
            this.numPhiVisaMaster.Name = "numPhiVisaMaster";
            this.numPhiVisaMaster.Size = new System.Drawing.Size(150, 24);
            this.numPhiVisaMaster.TabIndex = 1;
            this.numPhiVisaMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tỷ lệ phí VISA/Mastercard (%):";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(220, 425);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu cấu hình";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(400, 425);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(160, 40);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Khôi phục mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(580, 425);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 40);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.grpFreeship);
            this.Controls.Add(this.grpBieuPhi);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình Phí vận chuyển & Khuyến mãi e-Shopping";
            this.Load += new System.EventHandler(this.FrmCauHinh_Load);
            this.grpBieuPhi.ResumeLayout(false);
            this.grpBieuPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiHoaToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiCPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiThuong)).EndInit();
            this.grpFreeship.ResumeLayout(false);
            this.grpFreeship.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMienPhiCPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMienPhiThuong)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiAmexDiscover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVisaMaster)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpBieuPhi;
        private System.Windows.Forms.NumericUpDown numPhiHoaToc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPhiCPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPhiThuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFreeship;
        private System.Windows.Forms.NumericUpDown numMienPhiCPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMienPhiThuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.TextBox txtEmailAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPhiAmexDiscover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPhiVisaMaster;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnDong;
    }
}
