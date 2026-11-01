using System;

namespace HeThongeShopping.Services
{
    public static class CauHinhService
    {
        public static CauHinhHeThong Current = new CauHinhHeThong
        {
            PhiThuong = 30000m,
            PhiCPN = 50000m,
            PhiHoaToc = 80000m,
            MienPhiThuong = 1000000m,
            MienPhiCPN = 5000000m,
            TiLePhiVisaMaster = 1.0m,
            TiLePhiAmexDiscover = 1.5m,
            EmailAdmin = "admin.eshopping@abcstore.com"
        };

        public static decimal TinhPhiGiaoHang(string loaiPhieu, decimal tongTriGia)
        {
            if (string.IsNullOrEmpty(loaiPhieu)) loaiPhieu = "Thường";

            if (loaiPhieu.Contains("ngày") || loaiPhieu.Contains("tốc"))
            {
                return Current.PhiHoaToc;
            }
            else if (loaiPhieu.Contains("Nhanh") || loaiPhieu.Contains("CPN"))
            {
                if (tongTriGia >= Current.MienPhiCPN) return 0;
                return Current.PhiCPN;
            }
            else
            {
                if (tongTriGia >= Current.MienPhiThuong) return 0;
                return Current.PhiThuong;
            }
        }

        public static decimal TinhLePhiThe(string loaiThe, decimal tongTien)
        {
            if (string.IsNullOrEmpty(loaiThe)) return 0;

            if (loaiThe.IndexOf("VISA", StringComparison.OrdinalIgnoreCase) >= 0 ||
                loaiThe.IndexOf("Master", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return tongTien * (Current.TiLePhiVisaMaster / 100m);
            }
            return tongTien * (Current.TiLePhiAmexDiscover / 100m);
        }
    }
}
