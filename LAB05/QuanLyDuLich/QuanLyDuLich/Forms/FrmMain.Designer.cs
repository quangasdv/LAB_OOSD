namespace QuanLyDuLich.Forms
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnQuanLyTour = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 105);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblSubTitle.Location = new System.Drawing.Point(170, 60);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(465, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "HỆ THỐNG QUẢN LÝ TOUR DU LỊCH";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(120, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM";
            // 
            // btnDangKyDoan
            // 
            this.btnDangKyDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDangKyDoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKyDoan.FlatAppearance.BorderSize = 0;
            this.btnDangKyDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyDoan.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnDangKyDoan.ForeColor = System.Drawing.Color.White;
            this.btnDangKyDoan.Location = new System.Drawing.Point(170, 130);
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Size = new System.Drawing.Size(460, 68);
            this.btnDangKyDoan.TabIndex = 1;
            this.btnDangKyDoan.Text = "ĐĂNG KÝ TOUR THEO ĐOÀN";
            this.btnDangKyDoan.UseVisualStyleBackColor = false;
            this.btnDangKyDoan.Click += new System.EventHandler(this.btnDangKyDoan_Click);
            // 
            // btnQuanLyTour
            // 
            this.btnQuanLyTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnQuanLyTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyTour.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTour.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyTour.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTour.Location = new System.Drawing.Point(170, 215);
            this.btnQuanLyTour.Name = "btnQuanLyTour";
            this.btnQuanLyTour.Size = new System.Drawing.Size(460, 48);
            this.btnQuanLyTour.TabIndex = 2;
            this.btnQuanLyTour.Text = "QUẢN LÝ DANH MỤC TOUR";
            this.btnQuanLyTour.UseVisualStyleBackColor = false;
            this.btnQuanLyTour.Click += new System.EventHandler(this.btnQuanLyTour_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.White;
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThongTin.Location = new System.Drawing.Point(170, 278);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(460, 44);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Chính sách & Quy định Tour";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.Location = new System.Drawing.Point(170, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(460, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblDatabase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(127, 20);
            this.lblStatus.Text = "Sẵn sàng làm việc";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(248, 20);
            this.lblDatabase.Text = "  |  Database: QuanLyDuLichDB";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnQuanLyTour);
            this.Controls.Add(this.btnDangKyDoan);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Ty Du Lịch Văn Hóa Việt TP.HCM - Quản Lý Tour";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDangKyDoan;
        private System.Windows.Forms.Button btnQuanLyTour;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblDatabase;
    }
}
