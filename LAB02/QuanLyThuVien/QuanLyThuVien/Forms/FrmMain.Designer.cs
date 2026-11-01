namespace QuanLyThuVien.Forms
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTittle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTittle.Location = new System.Drawing.Point(135, 25);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(512, 46);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhMuc.Location = new System.Drawing.Point(105, 105);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(260, 65);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục / Nhân viên";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnSach
            // 
            this.btnSach.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.Location = new System.Drawing.Point(415, 105);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(260, 65);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "Quản lý đầu sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocGia.Location = new System.Drawing.Point(105, 195);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(260, 65);
            this.btnDocGia.TabIndex = 3;
            this.btnDocGia.Text = "Độc giả và thẻ";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonTra.Location = new System.Drawing.Point(415, 195);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(260, 65);
            this.btnMuonTra.TabIndex = 4;
            this.btnMuonTra.Text = "Mượn - Trả sách";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(105, 285);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(260, 65);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(415, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(260, 65);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTittle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKe;
    }
}
