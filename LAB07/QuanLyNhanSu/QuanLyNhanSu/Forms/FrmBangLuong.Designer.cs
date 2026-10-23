namespace QuanLyNhanSu.Forms
{
    partial class FrmBangLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.btnTaiBangLuong = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnXuatPaySlip = new System.Windows.Forms.Button();
            this.btnKhoaSo = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.lblTongDocHai = new System.Windows.Forms.Label();
            this.lblTongBH = new System.Windows.Forms.Label();
            this.lblTongThucLinh = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(380, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BẢNG THANH TOÁN TIỀN LƯƠNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng:";
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
            this.cboThang.Location = new System.Drawing.Point(80, 67);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(70, 28);
            this.cboThang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm:";
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(215, 68);
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
            this.numNam.Size = new System.Drawing.Size(80, 27);
            this.numNam.TabIndex = 4;
            this.numNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // btnTaiBangLuong
            // 
            this.btnTaiBangLuong.Location = new System.Drawing.Point(315, 63);
            this.btnTaiBangLuong.Name = "btnTaiBangLuong";
            this.btnTaiBangLuong.Size = new System.Drawing.Size(120, 34);
            this.btnTaiBangLuong.TabIndex = 5;
            this.btnTaiBangLuong.Text = "Xem Bảng";
            this.btnTaiBangLuong.UseVisualStyleBackColor = true;
            this.btnTaiBangLuong.Click += new System.EventHandler(this.btnTaiBangLuong_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(450, 63);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(200, 34);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "Tính Lương Tự Động";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnXuatPaySlip
            // 
            this.btnXuatPaySlip.Location = new System.Drawing.Point(665, 63);
            this.btnXuatPaySlip.Name = "btnXuatPaySlip";
            this.btnXuatPaySlip.Size = new System.Drawing.Size(200, 34);
            this.btnXuatPaySlip.TabIndex = 7;
            this.btnXuatPaySlip.Text = "In Phiếu Lương (Pay Slip)";
            this.btnXuatPaySlip.UseVisualStyleBackColor = true;
            this.btnXuatPaySlip.Click += new System.EventHandler(this.btnXuatPaySlip_Click);
            // 
            // btnKhoaSo
            // 
            this.btnKhoaSo.Location = new System.Drawing.Point(880, 63);
            this.btnKhoaSo.Name = "btnKhoaSo";
            this.btnKhoaSo.Size = new System.Drawing.Size(160, 34);
            this.btnKhoaSo.TabIndex = 8;
            this.btnKhoaSo.Text = "Duyệt Bảng Lương";
            this.btnKhoaSo.UseVisualStyleBackColor = true;
            this.btnKhoaSo.Click += new System.EventHandler(this.btnKhoaSo_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(12, 115);
            this.dgvBangLuong.MultiSelect = false;
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1176, 460);
            this.dgvBangLuong.TabIndex = 9;
            // 
            // lblTongDocHai
            // 
            this.lblTongDocHai.AutoSize = true;
            this.lblTongDocHai.Location = new System.Drawing.Point(15, 595);
            this.lblTongDocHai.Name = "lblTongDocHai";
            this.lblTongDocHai.Size = new System.Drawing.Size(217, 20);
            this.lblTongDocHai.TabIndex = 10;
            this.lblTongDocHai.Text = "Tổng PC Độc Hại Xưởng Sơn: 0 đ";
            // 
            // lblTongBH
            // 
            this.lblTongBH.AutoSize = true;
            this.lblTongBH.Location = new System.Drawing.Point(340, 595);
            this.lblTongBH.Name = "lblTongBH";
            this.lblTongBH.Size = new System.Drawing.Size(193, 20);
            this.lblTongBH.TabIndex = 11;
            this.lblTongBH.Text = "Tổng trích BH (10.5%): 0 đ";
            // 
            // lblTongThucLinh
            // 
            this.lblTongThucLinh.AutoSize = true;
            this.lblTongThucLinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThucLinh.Location = new System.Drawing.Point(640, 593);
            this.lblTongThucLinh.Name = "lblTongThucLinh";
            this.lblTongThucLinh.Size = new System.Drawing.Size(232, 23);
            this.lblTongThucLinh.TabIndex = 12;
            this.lblTongThucLinh.Text = "TỔNG THỰC LĨNH: 0 VNĐ";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1068, 588);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 34);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 635);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblTongThucLinh);
            this.Controls.Add(this.lblTongBH);
            this.Controls.Add(this.lblTongDocHai);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.btnKhoaSo);
            this.Controls.Add(this.btnXuatPaySlip);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnTaiBangLuong);
            this.Controls.Add(this.numNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Thanh Toán Tiền Lương";
            this.Load += new System.EventHandler(this.FrmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnTaiBangLuong;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnXuatPaySlip;
        private System.Windows.Forms.Button btnKhoaSo;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Label lblTongDocHai;
        private System.Windows.Forms.Label lblTongBH;
        private System.Windows.Forms.Label lblTongThucLinh;
        private System.Windows.Forms.Button btnDong;
    }
}
