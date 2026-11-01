namespace QuanLyThuVien.Forms
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblMuon = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblTu = new System.Windows.Forms.Label();
            this.dgvPhat = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnDong);
            this.pnlTop.Controls.Add(this.lblPhiPhat);
            this.pnlTop.Controls.Add(this.lblHuHong);
            this.pnlTop.Controls.Add(this.lblMat);
            this.pnlTop.Controls.Add(this.lblQuaHan);
            this.pnlTop.Controls.Add(this.lblMuon);
            this.pnlTop.Controls.Add(this.btnThongKe);
            this.pnlTop.Controls.Add(this.dtDen);
            this.pnlTop.Controls.Add(this.lblDen);
            this.pnlTop.Controls.Add(this.dtTu);
            this.pnlTop.Controls.Add(this.lblTu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1070, 160);
            this.pnlTop.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(920, 20);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhiPhat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhiPhat.Location = new System.Drawing.Point(620, 115);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(147, 25);
            this.lblPhiPhat.TabIndex = 9;
            this.lblPhiPhat.Text = "Tổng phí phạt: 0 đ";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHuHong.Location = new System.Drawing.Point(340, 115);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(130, 21);
            this.lblHuHong.TabIndex = 8;
            this.lblHuHong.Text = "Sách hư hỏng: 0";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMat.Location = new System.Drawing.Point(40, 115);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(95, 21);
            this.lblMat.TabIndex = 7;
            this.lblMat.Text = "Sách mất: 0";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuaHan.Location = new System.Drawing.Point(340, 75);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(127, 21);
            this.lblQuaHan.TabIndex = 6;
            this.lblQuaHan.Text = "Sách quá hạn: 0";
            // 
            // lblMuon
            // 
            this.lblMuon.AutoSize = true;
            this.lblMuon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMuon.Location = new System.Drawing.Point(40, 75);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(161, 21);
            this.lblMuon.TabIndex = 5;
            this.lblMuon.Text = "Lượt sách mượn: 0";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(620, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 40);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(390, 25);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(180, 29);
            this.dtDen.TabIndex = 3;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(310, 28);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(79, 21);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(100, 25);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(180, 29);
            this.dtTu.TabIndex = 1;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(20, 28);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(68, 21);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dgvPhat
            // 
            this.dgvPhat.AllowUserToAddRows = false;
            this.dgvPhat.AllowUserToDeleteRows = false;
            this.dgvPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhat.Location = new System.Drawing.Point(0, 160);
            this.dgvPhat.MultiSelect = false;
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.ReadOnly = true;
            this.dgvPhat.RowHeadersWidth = 51;
            this.dgvPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhat.Size = new System.Drawing.Size(1070, 540);
            this.dgvPhat.TabIndex = 1;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvPhat;
    }
}
