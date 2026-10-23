namespace QuanLyNhanSu.Forms
{
    partial class FrmChamCongPhuTroi
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPhuTroiChamCong = new System.Windows.Forms.TabControl();
            this.tabPhuTroi = new System.Windows.Forms.TabPage();
            this.dgvPhuTroi = new System.Windows.Forms.DataGridView();
            this.grpPhieuPhuTroi = new System.Windows.Forms.GroupBox();
            this.btnDuyetPhieu = new System.Windows.Forms.Button();
            this.btnThemPhuTroi = new System.Windows.Forms.Button();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSoGioOT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPhongBanOT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHinhThucOT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayOT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.btnCapNhatCong = new System.Windows.Forms.Button();
            this.btnXemChamCong = new System.Windows.Forms.Button();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabPhuTroiChamCong.SuspendLayout();
            this.tabPhuTroi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTroi)).BeginInit();
            this.grpPhieuPhuTroi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGioOT)).BeginInit();
            this.tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(320, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHẤM CÔNG & PHỤ TRỘI (OT)";
            // 
            // tabPhuTroiChamCong
            // 
            this.tabPhuTroiChamCong.Controls.Add(this.tabPhuTroi);
            this.tabPhuTroiChamCong.Controls.Add(this.tabChamCong);
            this.tabPhuTroiChamCong.Location = new System.Drawing.Point(12, 60);
            this.tabPhuTroiChamCong.Name = "tabPhuTroiChamCong";
            this.tabPhuTroiChamCong.SelectedIndex = 0;
            this.tabPhuTroiChamCong.Size = new System.Drawing.Size(1010, 520);
            this.tabPhuTroiChamCong.TabIndex = 1;
            // 
            // tabPhuTroi
            // 
            this.tabPhuTroi.Controls.Add(this.dgvPhuTroi);
            this.tabPhuTroi.Controls.Add(this.grpPhieuPhuTroi);
            this.tabPhuTroi.Location = new System.Drawing.Point(4, 29);
            this.tabPhuTroi.Name = "tabPhuTroi";
            this.tabPhuTroi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTroi.Size = new System.Drawing.Size(1002, 487);
            this.tabPhuTroi.TabIndex = 0;
            this.tabPhuTroi.Text = "Phiếu ghi nhận phụ trội";
            this.tabPhuTroi.UseVisualStyleBackColor = true;
            // 
            // dgvPhuTroi
            // 
            this.dgvPhuTroi.AllowUserToAddRows = false;
            this.dgvPhuTroi.AllowUserToDeleteRows = false;
            this.dgvPhuTroi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhuTroi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTroi.Location = new System.Drawing.Point(10, 220);
            this.dgvPhuTroi.MultiSelect = false;
            this.dgvPhuTroi.Name = "dgvPhuTroi";
            this.dgvPhuTroi.ReadOnly = true;
            this.dgvPhuTroi.RowHeadersWidth = 51;
            this.dgvPhuTroi.RowTemplate.Height = 24;
            this.dgvPhuTroi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuTroi.Size = new System.Drawing.Size(980, 250);
            this.dgvPhuTroi.TabIndex = 1;
            // 
            // grpPhieuPhuTroi
            // 
            this.grpPhieuPhuTroi.Controls.Add(this.btnDuyetPhieu);
            this.grpPhieuPhuTroi.Controls.Add(this.btnThemPhuTroi);
            this.grpPhieuPhuTroi.Controls.Add(this.txtLyDo);
            this.grpPhieuPhuTroi.Controls.Add(this.label7);
            this.grpPhieuPhuTroi.Controls.Add(this.numSoGioOT);
            this.grpPhieuPhuTroi.Controls.Add(this.label6);
            this.grpPhieuPhuTroi.Controls.Add(this.cboNhanVien);
            this.grpPhieuPhuTroi.Controls.Add(this.label5);
            this.grpPhieuPhuTroi.Controls.Add(this.cboPhongBanOT);
            this.grpPhieuPhuTroi.Controls.Add(this.label4);
            this.grpPhieuPhuTroi.Controls.Add(this.cboHinhThucOT);
            this.grpPhieuPhuTroi.Controls.Add(this.label3);
            this.grpPhieuPhuTroi.Controls.Add(this.dtpNgayOT);
            this.grpPhieuPhuTroi.Controls.Add(this.label2);
            this.grpPhieuPhuTroi.Controls.Add(this.txtSoPhieu);
            this.grpPhieuPhuTroi.Controls.Add(this.label1);
            this.grpPhieuPhuTroi.Location = new System.Drawing.Point(10, 10);
            this.grpPhieuPhuTroi.Name = "grpPhieuPhuTroi";
            this.grpPhieuPhuTroi.Size = new System.Drawing.Size(980, 195);
            this.grpPhieuPhuTroi.TabIndex = 0;
            this.grpPhieuPhuTroi.TabStop = false;
            this.grpPhieuPhuTroi.Text = "Lập & Duyệt phiếu phụ trội";
            // 
            // btnDuyetPhieu
            // 
            this.btnDuyetPhieu.Location = new System.Drawing.Point(760, 145);
            this.btnDuyetPhieu.Name = "btnDuyetPhieu";
            this.btnDuyetPhieu.Size = new System.Drawing.Size(200, 36);
            this.btnDuyetPhieu.TabIndex = 15;
            this.btnDuyetPhieu.Text = "Duyệt Phiếu";
            this.btnDuyetPhieu.UseVisualStyleBackColor = true;
            this.btnDuyetPhieu.Click += new System.EventHandler(this.btnDuyetPhieu_Click);
            // 
            // btnThemPhuTroi
            // 
            this.btnThemPhuTroi.Location = new System.Drawing.Point(540, 145);
            this.btnThemPhuTroi.Name = "btnThemPhuTroi";
            this.btnThemPhuTroi.Size = new System.Drawing.Size(180, 36);
            this.btnThemPhuTroi.TabIndex = 14;
            this.btnThemPhuTroi.Text = "Lưu Phiếu";
            this.btnThemPhuTroi.UseVisualStyleBackColor = true;
            this.btnThemPhuTroi.Click += new System.EventHandler(this.btnThemPhuTroi_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(120, 148);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(380, 27);
            this.txtLyDo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lý do:";
            // 
            // numSoGioOT
            // 
            this.numSoGioOT.DecimalPlaces = 1;
            this.numSoGioOT.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSoGioOT.Location = new System.Drawing.Point(820, 105);
            this.numSoGioOT.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSoGioOT.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSoGioOT.Name = "numSoGioOT";
            this.numSoGioOT.Size = new System.Drawing.Size(140, 27);
            this.numSoGioOT.TabIndex = 11;
            this.numSoGioOT.Value = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(730, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số giờ OT:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(120, 105);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(570, 28);
            this.cboNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhân viên:";
            // 
            // cboPhongBanOT
            // 
            this.cboPhongBanOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBanOT.FormattingEnabled = true;
            this.cboPhongBanOT.Location = new System.Drawing.Point(540, 68);
            this.cboPhongBanOT.Name = "cboPhongBanOT";
            this.cboPhongBanOT.Size = new System.Drawing.Size(420, 28);
            this.cboPhongBanOT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng ban:";
            // 
            // cboHinhThucOT
            // 
            this.cboHinhThucOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucOT.FormattingEnabled = true;
            this.cboHinhThucOT.Items.AddRange(new object[] {
            "Tăng ca ngày thường (Hệ số 1.5)",
            "Ngày nghỉ hàng tuần (Hệ số 2.0)",
            "Ngày lễ tết (Hệ số 3.0)"});
            this.cboHinhThucOT.Location = new System.Drawing.Point(120, 68);
            this.cboHinhThucOT.Name = "cboHinhThucOT";
            this.cboHinhThucOT.Size = new System.Drawing.Size(300, 28);
            this.cboHinhThucOT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hình thức:";
            // 
            // dtpNgayOT
            // 
            this.dtpNgayOT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayOT.Location = new System.Drawing.Point(540, 30);
            this.dtpNgayOT.Name = "dtpNgayOT";
            this.dtpNgayOT.Size = new System.Drawing.Size(420, 27);
            this.dtpNgayOT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày OT:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(120, 30);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(300, 27);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // tabChamCong
            // 
            this.tabChamCong.Controls.Add(this.btnCapNhatCong);
            this.tabChamCong.Controls.Add(this.btnXemChamCong);
            this.tabChamCong.Controls.Add(this.numNam);
            this.tabChamCong.Controls.Add(this.label9);
            this.tabChamCong.Controls.Add(this.cboThang);
            this.tabChamCong.Controls.Add(this.label8);
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Location = new System.Drawing.Point(4, 29);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamCong.Size = new System.Drawing.Size(1002, 487);
            this.tabChamCong.TabIndex = 1;
            this.tabChamCong.Text = "Bảng chấm công tháng";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatCong
            // 
            this.btnCapNhatCong.Location = new System.Drawing.Point(760, 15);
            this.btnCapNhatCong.Name = "btnCapNhatCong";
            this.btnCapNhatCong.Size = new System.Drawing.Size(220, 34);
            this.btnCapNhatCong.TabIndex = 6;
            this.btnCapNhatCong.Text = "Chốt Chấm Công";
            this.btnCapNhatCong.UseVisualStyleBackColor = true;
            this.btnCapNhatCong.Click += new System.EventHandler(this.btnCapNhatCong_Click);
            // 
            // btnXemChamCong
            // 
            this.btnXemChamCong.Location = new System.Drawing.Point(540, 15);
            this.btnXemChamCong.Name = "btnXemChamCong";
            this.btnXemChamCong.Size = new System.Drawing.Size(180, 34);
            this.btnXemChamCong.TabIndex = 5;
            this.btnXemChamCong.Text = "Tải Dữ Liệu";
            this.btnXemChamCong.UseVisualStyleBackColor = true;
            this.btnXemChamCong.Click += new System.EventHandler(this.btnXemChamCong_Click);
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(340, 20);
            this.numNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(120, 27);
            this.numNam.TabIndex = 4;
            this.numNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(120, 20);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(120, 28);
            this.cboThang.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tháng:";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(10, 65);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(980, 410);
            this.dgvChamCong.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(902, 590);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 36);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmChamCongPhuTroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 635);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabPhuTroiChamCong);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmChamCongPhuTroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chấm Công & Phụ Trội";
            this.Load += new System.EventHandler(this.FrmChamCongPhuTroi_Load);
            this.tabPhuTroiChamCong.ResumeLayout(false);
            this.tabPhuTroi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTroi)).EndInit();
            this.grpPhieuPhuTroi.ResumeLayout(false);
            this.grpPhieuPhuTroi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGioOT)).EndInit();
            this.tabChamCong.ResumeLayout(false);
            this.tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabPhuTroiChamCong;
        private System.Windows.Forms.TabPage tabPhuTroi;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.GroupBox grpPhieuPhuTroi;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayOT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHinhThucOT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhongBanOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSoGioOT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemPhuTroi;
        private System.Windows.Forms.Button btnDuyetPhieu;
        private System.Windows.Forms.DataGridView dgvPhuTroi;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXemChamCong;
        private System.Windows.Forms.Button btnCapNhatCong;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Button btnDong;
    }
}
