namespace QuanLyThuVien.Forms
{
    partial class FrmMain
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTittle.ForeColor = System.Drawing.Color.Black;
            this.lblTittle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTittle.Location = new System.Drawing.Point(162, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(550, 48);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(105, 77);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(240, 55);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục / Nhân viên";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnDocGia
            // 
            this.btnDocGia.Location = new System.Drawing.Point(105, 171);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(240, 55);
            this.btnDocGia.TabIndex = 2;
            this.btnDocGia.Text = "Độc giả và thẻ";
            this.btnDocGia.UseVisualStyleBackColor = true;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Location = new System.Drawing.Point(453, 171);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(240, 55);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.Text = "Mượn - Trả sách";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(453, 77);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(240, 55);
            this.btnSach.TabIndex = 4;
            this.btnSach.Text = "Quản lý đầu sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(453, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(240, 55);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTittle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button2;
    }
}