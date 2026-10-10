USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyDuLichDB')
BEGIN
    ALTER DATABASE QuanLyDuLichDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyDuLichDB;
END
GO

CREATE DATABASE QuanLyDuLichDB;
GO
USE QuanLyDuLichDB;
GO

-- 1. Bảng Tour du lịch
CREATE TABLE Tour (
    MaTour VARCHAR(20) NOT NULL PRIMARY KEY,
    TenTour NVARCHAR(150) NOT NULL,
    SoNgay INT NOT NULL CHECK(SoNgay > 0),
    SoDem INT NOT NULL CHECK(SoDem >= 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK(DonGia >= 0),
    DiemXuatPhat NVARCHAR(100) NOT NULL DEFAULT N'TP.HCM'
);
GO

-- 2. Bảng Nơi dừng chân
CREATE TABLE NoiDungChan (
    MaNoiDungChan VARCHAR(20) NOT NULL PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    ThuTu INT NOT NULL,
    TenDiaDiem NVARCHAR(150) NOT NULL,
    DoiPhuongTien BIT NOT NULL DEFAULT 0,
    PhuongTienDiChuyen NVARCHAR(50) NULL,
    CoNoiAn BIT NOT NULL DEFAULT 1,
    CoKhachSan BIT NOT NULL DEFAULT 1,
    LoaiKhachSan INT NULL CHECK(LoaiKhachSan BETWEEN 2 AND 5),
    CONSTRAINT FK_NoiDungChan_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour)
);
GO

-- 3. Bảng Điểm tham quan & Chi tiết tham quan theo Tour
CREATE TABLE DiemThamQuan (
    MaDiemTQ VARCHAR(20) NOT NULL PRIMARY KEY,
    TenDiemTQ NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    NoiDung NVARCHAR(500) NULL,
    YNghia NVARCHAR(500) NULL
);
GO

CREATE TABLE Tour_DiemThamQuan (
    MaTour VARCHAR(20) NOT NULL,
    MaDiemTQ VARCHAR(20) NOT NULL,
    PRIMARY KEY(MaTour, MaDiemTQ),
    CONSTRAINT FK_TourTQ_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour),
    CONSTRAINT FK_TourTQ_Diem FOREIGN KEY (MaDiemTQ) REFERENCES DiemThamQuan(MaDiemTQ)
);
GO

-- 4. Bảng Khách hàng theo đoàn (Cơ quan / Đại diện gia đình)
CREATE TABLE KhachDoan (
    MaDoan VARCHAR(20) NOT NULL PRIMARY KEY,
    TenCoQuan NVARCHAR(150) NOT NULL,
    DiaChiCoQuan NVARCHAR(250) NOT NULL,
    DienThoaiCoQuan VARCHAR(20) NOT NULL,
    NguoiDaiDien NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NULL
);
GO

-- 5. Bảng Phiếu đăng ký tour theo đoàn (Yêu cầu >= 12 người, chọn ngày đi tùy ý, cọc trước 30%)
CREATE TABLE PhieuDangKyTourDoan (
    SoPhieuDK VARCHAR(30) NOT NULL PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    MaDoan VARCHAR(20) NOT NULL,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    NgayDi DATE NOT NULL,
    DiemDon NVARCHAR(250) NOT NULL,
    SoNguoi INT NOT NULL CHECK(SoNguoi >= 12), -- BR: Khách đoàn phải từ 12 người trở lên
    TongKinhPhi DECIMAL(18,2) NOT NULL CHECK(TongKinhPhi >= 0),
    TienCoc DECIMAL(18,2) NOT NULL CHECK(TienCoc >= 0),
    CoMuaBaoHiem BIT NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã đặt cọc',
    CONSTRAINT CK_PDK_TrangThai CHECK(TrangThai IN (N'Đã đặt cọc', N'Đang thực hiện', N'Đã kết thúc', N'Hủy tour - Mất cọc')),
    CONSTRAINT FK_PDK_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour),
    CONSTRAINT FK_PDK_Doan FOREIGN KEY (MaDoan) REFERENCES KhachDoan(MaDoan)
);
GO

-- 6. Bảng Danh sách thành viên cùng đi mua bảo hiểm
CREATE TABLE ThanhVienBaoHiem (
    MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
    SoPhieuDK VARCHAR(30) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    CCCD VARCHAR(20) NOT NULL,
    CONSTRAINT FK_TVBH_PhieuDK FOREIGN KEY (SoPhieuDK) REFERENCES PhieuDangKyTourDoan(SoPhieuDK)
);
GO

-- 7. Bảng Chuyến du lịch cố định (Khách lẻ dưới 12 người)
CREATE TABLE ChuyenDuLich (
    MaChuyen VARCHAR(20) NOT NULL PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    NgayDi DATE NOT NULL,
    NgayVe DATE NOT NULL,
    SoVeToiDa INT NOT NULL CHECK(SoVeToiDa > 0),
    SoVeDaBan INT NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang mở bán',
    CONSTRAINT CK_Chuyen_Ngay CHECK(NgayVe >= NgayDi),
    CONSTRAINT FK_Chuyen_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour)
);
GO

-- 8. Bảng Khách lẻ & Phiếu đăng ký theo chuyến
CREATE TABLE KhachLe (
    MaKhachLe VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoCMND VARCHAR(20) NOT NULL UNIQUE,
    DienThoai VARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(250) NULL
);
GO

CREATE TABLE PhieuDangKyChuyen (
    SoPhieuChuyen VARCHAR(30) NOT NULL PRIMARY KEY,
    MaChuyen VARCHAR(20) NOT NULL,
    MaKhachLe VARCHAR(20) NOT NULL,
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
    SoLuongVe INT NOT NULL CHECK(SoLuongVe > 0 AND SoLuongVe < 12),
    DiemDonQuyDinh NVARCHAR(250) NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL CHECK(TongTien >= 0),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã thanh toán',
    CONSTRAINT FK_PDC_Chuyen FOREIGN KEY (MaChuyen) REFERENCES ChuyenDuLich(MaChuyen),
    CONSTRAINT FK_PDC_KhachLe FOREIGN KEY (MaKhachLe) REFERENCES KhachLe(MaKhachLe)
);
GO

-- 9. Bảng Hướng dẫn viên & Phân công
CREATE TABLE NhanVienHDV (
    MaNV VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    LuongCoBan DECIMAL(18,2) NOT NULL CHECK(LuongCoBan >= 0),
    ThuLaoMoiTour DECIMAL(18,2) NOT NULL CHECK(ThuLaoMoiTour >= 0)
);
GO

CREATE TABLE PhanCongHDV (
    MaPhanCong VARCHAR(30) NOT NULL PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL,
    SoPhieuDK VARCHAR(30) NULL,
    MaChuyen VARCHAR(20) NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    CONSTRAINT CK_PhanCong_Ngay CHECK(NgayKetThuc >= NgayBatDau),
    CONSTRAINT FK_PhanCong_NV FOREIGN KEY (MaNV) REFERENCES NhanVienHDV(MaNV),
    CONSTRAINT FK_PhanCong_PDK FOREIGN KEY (SoPhieuDK) REFERENCES PhieuDangKyTourDoan(SoPhieuDK),
    CONSTRAINT FK_PhanCong_Chuyen FOREIGN KEY (MaChuyen) REFERENCES ChuyenDuLich(MaChuyen)
);
GO

-- 10. Bảng Biên nhận thu tiền cọc (Cam kết mất cọc nếu hủy)
CREATE TABLE BienNhanThuCoc (
    MaBienNhan VARCHAR(30) NOT NULL PRIMARY KEY,
    SoPhieuDK VARCHAR(30) NOT NULL,
    NgayThu DATETIME NOT NULL DEFAULT GETDATE(),
    SoTienCoc DECIMAL(18,2) NOT NULL CHECK(SoTienCoc > 0),
    HinhThuc NVARCHAR(50) NOT NULL DEFAULT N'Chuyển khoản',
    CamKetMatCoc BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_ThuCoc_PDK FOREIGN KEY (SoPhieuDK) REFERENCES PhieuDangKyTourDoan(SoPhieuDK)
);
GO

-- ===================================================================
-- DỮ LIỆU MẪU (SEED DATA)
-- ===================================================================
INSERT INTO Tour(MaTour, TenTour, SoNgay, SoDem, DonGia) VALUES
('TOUR_NT', N'Tour TP.HCM - Nha Trang Biển Hát', 3, 2, 2800000),
('TOUR_DL', N'Tour TP.HCM - Đà Lạt Xứ Sở Ngàn Hoa', 4, 3, 3200000),
('TOUR_PQ', N'Tour TP.HCM - Phú Quốc Thiên Đường Đảo Ngọc', 3, 2, 4500000);

INSERT INTO NoiDungChan(MaNoiDungChan, MaTour, ThuTu, TenDiaDiem, DoiPhuongTien, PhuongTienDiChuyen, CoNoiAn, CoKhachSan, LoaiKhachSan) VALUES
('DC01', 'TOUR_NT', 1, N'Phan Thiết (Mũi Né)', 0, N'Xe ô tô du lịch', 1, 0, NULL),
('DC02', 'TOUR_NT', 2, N'TP. Nha Trang', 0, N'Xe ô tô du lịch', 1, 1, 4),
('DC03', 'TOUR_DL', 1, N'Bảo Lộc', 0, N'Xe ô tô du lịch', 1, 0, NULL),
('DC04', 'TOUR_DL', 2, N'TP. Đà Lạt', 0, N'Xe ô tô du lịch', 1, 1, 3);

INSERT INTO DiemThamQuan(MaDiemTQ, TenDiemTQ, DiaChi, NoiDung, YNghia) VALUES
('TQ01', N'Tháp Bà Ponagar', N'Đường 2/4, Vĩnh Phước, Nha Trang', N'Quần thể đền tháp Chăm Pa cổ kính', N'Di tích văn hóa tín ngưỡng lịch sử'),
('TQ02', N'Viện Hải Dương Học', N'Số 1 Cầu Đá, Nha Trang', N'Bảo tàng sinh vật biển lớn nhất', N'Nghiên cứu và bảo tồn sinh vật biển'),
('TQ03', N'Thung Lũng Tình Yêu', N'Số 3 Mai Anh Đào, Đà Lạt', N'Thắng cảnh hồ Đa Thiện và đồi thông', N'Biểu tượng du lịch lãng mạn xứ hoa');

INSERT INTO Tour_DiemThamQuan(MaTour, MaDiemTQ) VALUES
('TOUR_NT', 'TQ01'),
('TOUR_NT', 'TQ02'),
('TOUR_DL', 'TQ03');

INSERT INTO KhachDoan(MaDoan, TenCoQuan, DiaChiCoQuan, DienThoaiCoQuan, NguoiDaiDien, Email) VALUES
('DOAN01', N'Công ty Cổ phần Công nghệ FPT', N'Quận 9, TP.HCM', '02873000999', N'Trần Văn Bình', 'binhtv@fpt.com'),
('DOAN02', N'Trường THPT Lê Hồng Phong (Công đoàn)', N'Quận 5, TP.HCM', '02838398506', N'Nguyễn Thị Thu Hằng', 'congdoan@lhp.edu.vn'),
('DOAN03', N'Gia đình Bác sĩ Hoàng Kim', N'Quận 1, TP.HCM', '0903112233', N'Hoàng Kim Long', 'long.hk@gmail.com');

INSERT INTO NhanVienHDV(MaNV, HoTen, DienThoai, LuongCoBan, ThuLaoMoiTour) VALUES
('HDV01', N'Lê Minh Trí', '0901234567', 8000000, 1500000),
('HDV02', N'Phạm Thảo My', '0912345678', 8500000, 1800000),
('HDV03', N'Đỗ Quốc Bảo', '0987654321', 7500000, 1200000);

-- Thêm 1 phiếu đăng ký đoàn mẫu
INSERT INTO PhieuDangKyTourDoan(SoPhieuDK, MaTour, MaDoan, NgayLap, NgayDi, DiemDon, SoNguoi, TongKinhPhi, TienCoc, CoMuaBaoHiem, TrangThai) VALUES
('PDK20261010001', 'TOUR_NT', 'DOAN01', GETDATE(), '2026-10-25', N'Khu Công nghệ cao, TP. Thủ Đức', 15, 42000000, 12600000, 1, N'Đã đặt cọc');

INSERT INTO ThanhVienBaoHiem(SoPhieuDK, HoTen, NgaySinh, CCCD) VALUES
('PDK20261010001', N'Trần Văn Bình', '1985-04-12', '079085001234'),
('PDK20261010001', N'Lê Thị Hương', '1990-08-20', '079190005678'),
('PDK20261010001', N'Nguyễn Hoàng Long', '1992-12-05', '079192009012');

INSERT INTO BienNhanThuCoc(MaBienNhan, SoPhieuDK, NgayThu, SoTienCoc, HinhThuc, CamKetMatCoc) VALUES
('BN20261010001', 'PDK20261010001', GETDATE(), 12600000, N'Chuyển khoản Vietcombank', 1);
GO