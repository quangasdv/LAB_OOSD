namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(433, 23);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(164, 33);
            this.cboNV.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nhân viên lập phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Số tiền:";
            // 
            // numDenBu
            // 
            this.numDenBu.Location = new System.Drawing.Point(670, 290);
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(102, 31);
            this.numDenBu.TabIndex = 45;
            // 
            // cboDat
            // 
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(135, 26);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(98, 33);
            this.cboDat.TabIndex = 42;
            // 
            // btnThemDB
            // 
            this.btnThemDB.Location = new System.Drawing.Point(835, 363);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(131, 32);
            this.btnThemDB.TabIndex = 39;
            this.btnThemDB.Text = "Thêm đền bù";
            this.btnThemDB.UseVisualStyleBackColor = true;
            // 
            // txtMucDo
            // 
            this.txtMucDo.Location = new System.Drawing.Point(415, 290);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.ReadOnly = true;
            this.txtMucDo.Size = new System.Drawing.Size(134, 31);
            this.txtMucDo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mức độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số hóa đơn:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(18, 79);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 56;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(287, 195);
            this.dgvPhong.TabIndex = 35;
            // 
            // cboNV2
            // 
            this.cboNV2.FormattingEnabled = true;
            this.cboNV2.Location = new System.Drawing.Point(813, 26);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(164, 33);
            this.cboNV2.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Nhân viên thanh toán:";
            // 
            // dgvTN
            // 
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(356, 79);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 56;
            this.dgvTN.RowTemplate.Height = 24;
            this.dgvTN.Size = new System.Drawing.Size(287, 195);
            this.dgvTN.TabIndex = 51;
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Location = new System.Drawing.Point(690, 79);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.RowHeadersWidth = 56;
            this.dgvDBChon.RowTemplate.Height = 24;
            this.dgvDBChon.Size = new System.Drawing.Size(287, 195);
            this.dgvDBChon.TabIndex = 52;
            // 
            // txtSoDB
            // 
            this.txtSoDB.AllowDrop = true;
            this.txtSoDB.Location = new System.Drawing.Point(159, 293);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.ReadOnly = true;
            this.txtSoDB.Size = new System.Drawing.Size(134, 31);
            this.txtSoDB.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Số phiếu đền bù:";
            // 
            // btnLapDB
            // 
            this.btnLapDB.Location = new System.Drawing.Point(798, 290);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(192, 32);
            this.btnLapDB.TabIndex = 55;
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Số ngày tính tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Số hóa đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.AllowDrop = true;
            this.txtSoHD.Location = new System.Drawing.Point(159, 360);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(134, 31);
            this.txtSoHD.TabIndex = 62;
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(487, 360);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(134, 31);
            this.numSoNgay.TabIndex = 63;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(670, 363);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(131, 32);
            this.btnLapHD.TabIndex = 64;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(18, 414);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 56;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(959, 263);
            this.dgvHD.TabIndex = 65;
            // 
            // txtMaTT
            // 
            this.txtMaTT.AllowDrop = true;
            this.txtMaTT.Location = new System.Drawing.Point(155, 707);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.ReadOnly = true;
            this.txtMaTT.Size = new System.Drawing.Size(134, 31);
            this.txtMaTT.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã thanh toán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 710);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 68;
            this.label10.Text = "Số tiền thanh toán:";
            // 
            // numTienTT
            // 
            this.numTienTT.Location = new System.Drawing.Point(782, 707);
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(124, 31);
            this.numTienTT.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 70;
            this.label11.Text = "Hình thức:";
            // 
            // cboHT
            // 
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(433, 705);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(137, 33);
            this.cboHT.TabIndex = 71;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(598, 757);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(131, 32);
            this.btnThanhToan.TabIndex = 73;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(766, 758);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(200, 32);
            this.btnTraPhong.TabIndex = 74;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            // 
            // txtHDChon
            // 
            this.txtHDChon.AllowDrop = true;
            this.txtHDChon.Location = new System.Drawing.Point(155, 758);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.ReadOnly = true;
            this.txtHDChon.Size = new System.Drawing.Size(134, 31);
            this.txtHDChon.TabIndex = 75;
            this.txtHDChon.Visible = false;
            // 
            // txtPhong
            // 
            this.txtPhong.AllowDrop = true;
            this.txtPhong.Location = new System.Drawing.Point(339, 757);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(134, 31);
            this.txtPhong.TabIndex = 76;
            this.txtPhong.Visible = false;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 1053);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.cboNV2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTraPhong";
            this.Text = "FrmTraPhong";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.TextBox txtPhong;
    }
}