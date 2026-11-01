using System;
using System.Collections.Generic;
using System.Linq;

namespace HeThongeShopping.Services
{
    public class SanPhamService
    {
        private static List<SanPham> _dsSanPham = new List<SanPham>
        {
            new SanPham { MaSanPham = "SP001", TenSanPham = "Cây thông Noel mini để bàn", NhomSanPham = "Quà tặng Giáng sinh", DonGia = 300000, TonKho = 50, MoTa = "Cây thông trang trí cao 45cm kèm đèn LED nhấp nháy" },
            new SanPham { MaSanPham = "SP002", TenSanPham = "Hộp quà Giáng Sinh Premium", NhomSanPham = "Quà tặng Giáng sinh", DonGia = 450000, TonKho = 30, MoTa = "Hộp quà bánh kẹo ngoại nhập và thiệp chúc mừng thiết kế thủ công" },
            new SanPham { MaSanPham = "SP003", TenSanPham = "Máy ảnh kỹ thuật số Canon IXUS", NhomSanPham = "Thiết bị công nghệ", DonGia = 5500000, TonKho = 12, MoTa = "Độ phân giải 20MP, zoom quang học 8x, quay video HD" },
            new SanPham { MaSanPham = "SP004", TenSanPham = "Bộ đồ chơi trẻ em Lego Lâu đài tuyết", NhomSanPham = "Đồ chơi & Trẻ em", DonGia = 800000, TonKho = 25, MoTa = "Chất liệu nhựa ABS an toàn cho bé từ 6 tuổi, 480 mảnh ghép" },
            new SanPham { MaSanPham = "SP005", TenSanPham = "Đèn ngủ LED hình tuần lộc 3D", NhomSanPham = "Quà tặng Giáng sinh", DonGia = 180000, TonKho = 40, MoTa = "Ánh sáng vàng ấm cúng, đổi 7 màu, sạc USB" },
            new SanPham { MaSanPham = "SP006", TenSanPham = "Đồng hồ thông minh Smartwatch Pro", NhomSanPham = "Thiết bị công nghệ", DonGia = 1250000, TonKho = 18, MoTa = "Theo dõi nhịp tim, thông báo cuộc gọi, pin sử dụng 7 ngày" },
            new SanPham { MaSanPham = "SP007", TenSanPham = "Khăn choàng len Cashmere đỏ đô", NhomSanPham = "Phụ kiện thời trang", DonGia = 350000, TonKho = 35, MoTa = "Chất liệu len cao cấp giữ ấm mùa đông, phong cách thanh lịch" },
            new SanPham { MaSanPham = "SP008", TenSanPham = "Gấu bông Ông già Noel 60cm", NhomSanPham = "Đồ chơi & Trẻ em", DonGia = 220000, TonKho = 45, MoTa = "Lông mềm mịn, không rụng lông, quà tặng ý nghĩa cho bé" }
        };

        public List<string> LayDanhSachNhom()
        {
            List<string> nhom = new List<string> { "Tất cả" };
            foreach (var sp in _dsSanPham)
            {
                if (!nhom.Contains(sp.NhomSanPham))
                    nhom.Add(sp.NhomSanPham);
            }
            return nhom;
        }

        public List<SanPham> LayDanhSachSanPham(string nhom = "Tất cả", string tuKhoa = "")
        {
            var query = _dsSanPham.AsEnumerable();

            if (!string.IsNullOrEmpty(nhom) && nhom != "Tất cả")
            {
                query = query.Where(sp => sp.NhomSanPham == nhom);
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                string kw = tuKhoa.Trim().ToLower();
                query = query.Where(sp => sp.TenSanPham.ToLower().Contains(kw) || sp.MaSanPham.ToLower().Contains(kw));
            }

            return query.ToList();
        }
    }
}
