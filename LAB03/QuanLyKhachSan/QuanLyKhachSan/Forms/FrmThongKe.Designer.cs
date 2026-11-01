namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(120, 23);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(150, 31);
            this.dtTu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(395, 23);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(150, 31);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(570, 21);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(130, 35);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhieuDat.Location = new System.Drawing.Point(40, 80);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(117, 30);
            this.lblPhieuDat.TabIndex = 5;
            this.lblPhieuDat.Text = "Phiếu đặt: 0";
            // 
            // lblDangO
            // 
            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangO.Location = new System.Drawing.Point(500, 80);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(107, 30);
            this.lblDangO.TabIndex = 6;
            this.lblDangO.Text = "Đang ở: 0";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoaDon.Location = new System.Drawing.Point(40, 128);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(120, 30);
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Hóa đơn: 0";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.Location = new System.Drawing.Point(500, 128);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(199, 30);
            this.lblDoanhThu.TabIndex = 8;
            this.lblDoanhThu.Text = "Doanh thu HĐ: 0 đ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDenBu.Location = new System.Drawing.Point(40, 176);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(192, 30);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Tổng đền bù: 0 đ";
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDichVu.Location = new System.Drawing.Point(30, 230);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(161, 28);
            this.lblDichVu.TabIndex = 10;
            this.lblDichVu.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDV,
            this.colTenDV,
            this.colSoLuong,
            this.colTongTien});
            this.dgvDV.Location = new System.Drawing.Point(30, 265);
            this.dgvDV.MultiSelect = false;
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 28;
            this.dgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.Size = new System.Drawing.Size(920, 340);
            this.dgvDV.TabIndex = 11;
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MaDV";
            this.colMaDV.FillWeight = 20F;
            this.colMaDV.HeaderText = "Mã DV";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            // 
            // colTenDV
            // 
            this.colTenDV.DataPropertyName = "TenDV";
            this.colTenDV.FillWeight = 40F;
            this.colTenDV.HeaderText = "Tên dịch vụ";
            this.colTenDV.MinimumWidth = 6;
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "TongSoLuong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSoLuong.FillWeight = 20F;
            this.colSoLuong.HeaderText = "Tổng số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTongTien.FillWeight = 20F;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(0, 0);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.Size = new System.Drawing.Size(1, 1);
            this.dgvTongHop.TabIndex = 12;
            this.dgvTongHop.Visible = false;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 650);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTongHop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê khách sạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.Label lblDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridView dgvTongHop;
    }
}
