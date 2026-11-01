namespace HeThongeShopping.Forms
{
    partial class FrmDangNhap
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
            this.tabAuth = new System.Windows.Forms.TabControl();
            this.tabDangNhap = new System.Windows.Forms.TabPage();
            this.grpDN = new System.Windows.Forms.GroupBox();
            this.btnDongDN = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.grpDK = new System.Windows.Forms.GroupBox();
            this.btnDongDK = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtRegDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegCMND = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpRegNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegPass2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAuth.SuspendLayout();
            this.tabDangNhap.SuspendLayout();
            this.grpDN.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.grpDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.tabDangNhap);
            this.tabAuth.Controls.Add(this.tabDangKy);
            this.tabAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAuth.Location = new System.Drawing.Point(0, 0);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.SelectedIndex = 0;
            this.tabAuth.Size = new System.Drawing.Size(534, 491);
            this.tabAuth.TabIndex = 0;
            // 
            // tabDangNhap
            // 
            this.tabDangNhap.Controls.Add(this.grpDN);
            this.tabDangNhap.Location = new System.Drawing.Point(4, 26);
            this.tabDangNhap.Name = "tabDangNhap";
            this.tabDangNhap.Padding = new System.Windows.Forms.Padding(15);
            this.tabDangNhap.Size = new System.Drawing.Size(526, 461);
            this.tabDangNhap.TabIndex = 0;
            this.tabDangNhap.Text = "Đăng nhập hệ thống";
            this.tabDangNhap.UseVisualStyleBackColor = true;
            // 
            // grpDN
            // 
            this.grpDN.Controls.Add(this.btnDongDN);
            this.grpDN.Controls.Add(this.btnDangNhap);
            this.grpDN.Controls.Add(this.cboVaiTro);
            this.grpDN.Controls.Add(this.label3);
            this.grpDN.Controls.Add(this.txtMatKhau);
            this.grpDN.Controls.Add(this.label2);
            this.grpDN.Controls.Add(this.txtTenDangNhap);
            this.grpDN.Controls.Add(this.label1);
            this.grpDN.Location = new System.Drawing.Point(20, 20);
            this.grpDN.Name = "grpDN";
            this.grpDN.Size = new System.Drawing.Size(480, 380);
            this.grpDN.TabIndex = 0;
            this.grpDN.TabStop = false;
            this.grpDN.Text = "Xác thực tài khoản";
            // 
            // btnDongDN
            // 
            this.btnDongDN.Location = new System.Drawing.Point(310, 240);
            this.btnDongDN.Name = "btnDongDN";
            this.btnDongDN.Size = new System.Drawing.Size(120, 40);
            this.btnDongDN.TabIndex = 7;
            this.btnDongDN.Text = "Đóng";
            this.btnDongDN.UseVisualStyleBackColor = true;
            this.btnDongDN.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(150, 240);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(140, 40);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {
            "Khách hàng",
            "Nhân viên",
            "Quản trị viên (Admin)"});
            this.cboVaiTro.Location = new System.Drawing.Point(150, 160);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(280, 25);
            this.cboVaiTro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vai trò:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(150, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(280, 24);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(150, 60);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(280, 24);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.grpDK);
            this.tabDangKy.Location = new System.Drawing.Point(4, 26);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Padding = new System.Windows.Forms.Padding(15);
            this.tabDangKy.Size = new System.Drawing.Size(526, 461);
            this.tabDangKy.TabIndex = 1;
            this.tabDangKy.Text = "Đăng ký thành viên mới";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // grpDK
            // 
            this.grpDK.Controls.Add(this.btnDongDK);
            this.grpDK.Controls.Add(this.btnDangKy);
            this.grpDK.Controls.Add(this.txtRegDiaChi);
            this.grpDK.Controls.Add(this.label11);
            this.grpDK.Controls.Add(this.txtRegEmail);
            this.grpDK.Controls.Add(this.label10);
            this.grpDK.Controls.Add(this.txtRegSDT);
            this.grpDK.Controls.Add(this.label9);
            this.grpDK.Controls.Add(this.txtRegCMND);
            this.grpDK.Controls.Add(this.label8);
            this.grpDK.Controls.Add(this.dtpRegNgaySinh);
            this.grpDK.Controls.Add(this.label7);
            this.grpDK.Controls.Add(this.txtRegHoTen);
            this.grpDK.Controls.Add(this.label6);
            this.grpDK.Controls.Add(this.txtRegPass2);
            this.grpDK.Controls.Add(this.label5);
            this.grpDK.Controls.Add(this.txtRegPass);
            this.grpDK.Controls.Add(this.label4);
            this.grpDK.Controls.Add(this.txtRegUser);
            this.grpDK.Controls.Add(this.label12);
            this.grpDK.Location = new System.Drawing.Point(15, 10);
            this.grpDK.Name = "grpDK";
            this.grpDK.Size = new System.Drawing.Size(495, 435);
            this.grpDK.TabIndex = 0;
            this.grpDK.TabStop = false;
            this.grpDK.Text = "Thông tin đăng ký";
            // 
            // btnDongDK
            // 
            this.btnDongDK.Location = new System.Drawing.Point(340, 385);
            this.btnDongDK.Name = "btnDongDK";
            this.btnDongDK.Size = new System.Drawing.Size(120, 35);
            this.btnDongDK.TabIndex = 19;
            this.btnDongDK.Text = "Đóng";
            this.btnDongDK.UseVisualStyleBackColor = true;
            this.btnDongDK.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(170, 385);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 35);
            this.btnDangKy.TabIndex = 18;
            this.btnDangKy.Text = "Đăng ký ngay";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtRegDiaChi
            // 
            this.txtRegDiaChi.Location = new System.Drawing.Point(170, 345);
            this.txtRegDiaChi.Name = "txtRegDiaChi";
            this.txtRegDiaChi.Size = new System.Drawing.Size(290, 24);
            this.txtRegDiaChi.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Địa chỉ:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(170, 305);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(290, 24);
            this.txtRegEmail.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email:";
            // 
            // txtRegSDT
            // 
            this.txtRegSDT.Location = new System.Drawing.Point(170, 265);
            this.txtRegSDT.Name = "txtRegSDT";
            this.txtRegSDT.Size = new System.Drawing.Size(290, 24);
            this.txtRegSDT.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtRegCMND
            // 
            this.txtRegCMND.Location = new System.Drawing.Point(170, 225);
            this.txtRegCMND.Name = "txtRegCMND";
            this.txtRegCMND.Size = new System.Drawing.Size(290, 24);
            this.txtRegCMND.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số CMND/Passport:";
            // 
            // dtpRegNgaySinh
            // 
            this.dtpRegNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpRegNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegNgaySinh.Location = new System.Drawing.Point(170, 185);
            this.dtpRegNgaySinh.Name = "dtpRegNgaySinh";
            this.dtpRegNgaySinh.Size = new System.Drawing.Size(290, 24);
            this.dtpRegNgaySinh.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày sinh:";
            // 
            // txtRegHoTen
            // 
            this.txtRegHoTen.Location = new System.Drawing.Point(170, 145);
            this.txtRegHoTen.Name = "txtRegHoTen";
            this.txtRegHoTen.Size = new System.Drawing.Size(290, 24);
            this.txtRegHoTen.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ và tên:";
            // 
            // txtRegPass2
            // 
            this.txtRegPass2.Location = new System.Drawing.Point(170, 105);
            this.txtRegPass2.Name = "txtRegPass2";
            this.txtRegPass2.Size = new System.Drawing.Size(290, 24);
            this.txtRegPass2.TabIndex = 5;
            this.txtRegPass2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(170, 65);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(290, 24);
            this.txtRegPass.TabIndex = 3;
            this.txtRegPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtRegUser
            // 
            this.txtRegUser.Location = new System.Drawing.Point(170, 25);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(290, 24);
            this.txtRegUser.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên đăng nhập:";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 491);
            this.Controls.Add(this.tabAuth);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập / Đăng ký thành viên";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.tabAuth.ResumeLayout(false);
            this.tabDangNhap.ResumeLayout(false);
            this.grpDN.ResumeLayout(false);
            this.grpDN.PerformLayout();
            this.tabDangKy.ResumeLayout(false);
            this.grpDK.ResumeLayout(false);
            this.grpDK.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabAuth;
        private System.Windows.Forms.TabPage tabDangNhap;
        private System.Windows.Forms.GroupBox grpDN;
        private System.Windows.Forms.Button btnDongDN;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDangKy;
        private System.Windows.Forms.GroupBox grpDK;
        private System.Windows.Forms.Button btnDongDK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtRegDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRegNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.Label label12;
    }
}
