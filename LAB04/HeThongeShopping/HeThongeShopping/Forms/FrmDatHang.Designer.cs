namespace HeThongeShopping.Forms
{
    partial class FrmDatHang
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
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienThoaiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChuThe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoaiThe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXacNhanDatHang = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 12);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(760, 150);
            this.dgvGioHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiPhieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDienThoaiNhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChiNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTenNhan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao hàng";
            // 
            // cboLoaiPhieu
            // 
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.FormattingEnabled = true;
            this.cboLoaiPhieu.Items.AddRange(new object[] {
            "Thường",
            "CP Nhanh",
            "CP Nhanh trong ngày"});
            this.cboLoaiPhieu.Location = new System.Drawing.Point(100, 115);
            this.cboLoaiPhieu.Name = "cboLoaiPhieu";
            this.cboLoaiPhieu.Size = new System.Drawing.Size(250, 21);
            this.cboLoaiPhieu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại phiếu:";
            // 
            // txtDienThoaiNhan
            // 
            this.txtDienThoaiNhan.Location = new System.Drawing.Point(100, 85);
            this.txtDienThoaiNhan.Name = "txtDienThoaiNhan";
            this.txtDienThoaiNhan.Size = new System.Drawing.Size(250, 20);
            this.txtDienThoaiNhan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điện thoại:";
            // 
            // txtDiaChiNhan
            // 
            this.txtDiaChiNhan.Location = new System.Drawing.Point(100, 55);
            this.txtDiaChiNhan.Name = "txtDiaChiNhan";
            this.txtDiaChiNhan.Size = new System.Drawing.Size(250, 20);
            this.txtDiaChiNhan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ:";
            // 
            // txtHoTenNhan
            // 
            this.txtHoTenNhan.Location = new System.Drawing.Point(100, 25);
            this.txtHoTenNhan.Name = "txtHoTenNhan";
            this.txtHoTenNhan.Size = new System.Drawing.Size(250, 20);
            this.txtHoTenNhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người nhận:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChuThe);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoThe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboLoaiThe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(402, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán Thẻ tín dụng";
            // 
            // txtChuThe
            // 
            this.txtChuThe.Location = new System.Drawing.Point(100, 85);
            this.txtChuThe.Name = "txtChuThe";
            this.txtChuThe.Size = new System.Drawing.Size(250, 20);
            this.txtChuThe.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên chủ thẻ:";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(100, 55);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(250, 20);
            this.txtSoThe.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số thẻ:";
            // 
            // cboLoaiThe
            // 
            this.cboLoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThe.FormattingEnabled = true;
            this.cboLoaiThe.Items.AddRange(new object[] {
            "VISA",
            "Master",
            "Discover",
            "American Express"});
            this.cboLoaiThe.Location = new System.Drawing.Point(100, 25);
            this.cboLoaiThe.Name = "cboLoaiThe";
            this.cboLoaiThe.Size = new System.Drawing.Size(250, 21);
            this.cboLoaiThe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại thẻ:";
            // 
            // btnXacNhanDatHang
            // 
            this.btnXacNhanDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDatHang.Location = new System.Drawing.Point(582, 303);
            this.btnXacNhanDatHang.Name = "btnXacNhanDatHang";
            this.btnXacNhanDatHang.Size = new System.Drawing.Size(190, 40);
            this.btnXacNhanDatHang.TabIndex = 3;
            this.btnXacNhanDatHang.Text = "Xác nhận Đặt hàng";
            this.btnXacNhanDatHang.UseVisualStyleBackColor = true;
            this.btnXacNhanDatHang.Click += new System.EventHandler(this.btnXacNhanDatHang_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(402, 315);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(91, 17);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnXacNhanDatHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGioHang);
            this.Name = "FrmDatHang";
            this.Text = "Màn hình Đặt Hàng & Thanh Toán";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoaiNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChiNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChuThe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiThe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacNhanDatHang;
        private System.Windows.Forms.Label lblTongTien;
    }
}
