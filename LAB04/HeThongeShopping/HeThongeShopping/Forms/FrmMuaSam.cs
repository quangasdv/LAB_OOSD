using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using HeThongeShopping.Services;

namespace HeThongeShopping.Forms
{
    public partial class FrmMuaSam : Form
    {
        private readonly SanPhamService _spService = new SanPhamService();
        public static List<ChiTietDonHang> CurrentCart = new List<ChiTietDonHang>();
        private readonly CultureInfo _viVn = new CultureInfo("vi-VN");

        public FrmMuaSam()
        {
            InitializeComponent();
        }

        private void FrmMuaSam_Load(object sender, EventArgs e)
        {
            // Load nhóm sản phẩm
            cboNhomSP.DataSource = _spService.LayDanhSachNhom();

            // Nếu giỏ hàng trống, khởi tạo mặc định 2 món mẫu
            if (CurrentCart.Count == 0)
            {
                CurrentCart.Add(new ChiTietDonHang { MaSanPham = "SP001", TenSanPham = "Cây thông Noel mini để bàn", DonGia = 300000, SoLuong = 2, ThanhTien = 600000 });
                CurrentCart.Add(new ChiTietDonHang { MaSanPham = "SP002", TenSanPham = "Hộp quà Giáng Sinh Premium", DonGia = 450000, SoLuong = 1, ThanhTien = 450000 });
            }

            TaiDanhSachSanPham();
            CapNhatHienThiGioHang();
        }

        private void TaiDanhSachSanPham()
        {
            string nhom = cboNhomSP.SelectedItem != null ? cboNhomSP.SelectedItem.ToString() : "Tất cả";
            string kw = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = _spService.LayDanhSachSanPham(nhom, kw);
        }

        private void CapNhatHienThiGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = CurrentCart;

            decimal tong = 0;
            foreach (var item in CurrentCart)
            {
                item.ThanhTien = item.DonGia * item.SoLuong;
                tong += item.ThanhTien;
            }

            lblTongTien.Text = string.Format(_viVn, "Tổng tạm tính: {0:N0} đ", tong);
        }

        private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDanhSachSanPham();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachSanPham();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            cboNhomSP.SelectedIndex = 0;
            txtTimKiem.Text = "";
            TaiDanhSachSanPham();
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm vào giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maSP = Convert.ToString(dgvSanPham.CurrentRow.Cells["colMaSP"].Value);
            string tenSP = Convert.ToString(dgvSanPham.CurrentRow.Cells["colTenSP"].Value);
            decimal donGia = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["colDonGia"].Value);
            int sl = (int)numSoLuong.Value;

            // Kiểm tra xem đã có trong giỏ chưa
            var existing = CurrentCart.Find(x => x.MaSanPham == maSP);
            if (existing != null)
            {
                existing.SoLuong += sl;
                existing.ThanhTien = existing.SoLuong * existing.DonGia;
            }
            else
            {
                CurrentCart.Add(new ChiTietDonHang
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    SoLuong = sl,
                    ThanhTien = donGia * sl
                });
            }

            CapNhatHienThiGioHang();
            MessageBox.Show("Đã thêm [" + tenSP + "] vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            string maSP = Convert.ToString(dgvGioHang.CurrentRow.Cells["colMaSPGio"].Value);
            CurrentCart.RemoveAll(x => x.MaSanPham == maSP);
            CapNhatHienThiGioHang();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (CurrentCart.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sạch giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CurrentCart.Clear();
                    CapNhatHienThiGioHang();
                }
            }
        }

        private void btnTienHanhDatHang_Click(object sender, EventArgs e)
        {
            if (CurrentCart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống! Hãy chọn sản phẩm trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FrmDatHang f = new FrmDatHang(CurrentCart))
            {
                f.ShowDialog(this);
                CapNhatHienThiGioHang();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
