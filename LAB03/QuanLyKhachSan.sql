CREATE DATABASE QuanLyKhachSan;
GO
USE QuanLyKhachSan;
GO

CREATE TABLE NhanVien(
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    VaiTro nvarchar(50) NOT NULL,
    SoDienThoai varchar(20) NULL
);

CREATE TABLE KhuVuc(
    MaKhuVuc varchar(20) NOT NULL PRIMARY KEY,
    TenKhuVuc nvarchar(100) NOT NULL UNIQUE
);

CREATE TABLE Phong(
    SoPhong varchar(20) NOT NULL PRIMARY KEY,
    MaKhuVuc varchar(20) NOT NULL,
    SoNguoiToiDa int NOT NULL CHECK(SoNguoiToiDa > 0),
    DonGiaNgay decimal(18,2) NOT NULL CHECK(DonGiaNgay >= 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Trống',
    CONSTRAINT CK_Phong_TrangThai CHECK(TrangThai IN (N'Trống', N'Đã đặt', N'Đang ở', N'Bảo trì')),
    CONSTRAINT FK_Phong_KhuVuc FOREIGN KEY(MaKhuVuc) REFERENCES KhuVuc(MaKhuVuc)
);

CREATE TABLE LoaiTienNghi(
    MaLoaiTN varchar(20) NOT NULL PRIMARY KEY,
    TenLoaiTN nvarchar(100) NOT NULL UNIQUE
);

CREATE TABLE TienNghi(
    MaTienNghi varchar(30) NOT NULL PRIMARY KEY,
    MaLoaiTN varchar(20) NOT NULL,
    SoThuTu int NOT NULL,
    TinhTrangHienTai nvarchar(100) NULL,
    CONSTRAINT UQ_TienNghi_Loai_STT UNIQUE(MaLoaiTN, SoThuTu),
    CONSTRAINT FK_TienNghi_Loai FOREIGN KEY(MaLoaiTN) REFERENCES LoaiTienNghi(MaLoaiTN)
);

CREATE TABLE PhieuLapDat(
    SoPhieuLapDat varchar(30) NOT NULL PRIMARY KEY,
    MaTienNghi varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    TinhTrang nvarchar(100) NOT NULL,
    MaNV varchar(20) NOT NULL,
    GhiChu nvarchar(250) NULL,
    CONSTRAINT UQ_PhieuLapDat_ThietBi_Ngay UNIQUE(MaTienNghi, NgayLap),
    CONSTRAINT FK_PhieuLapDat_TienNghi FOREIGN KEY(MaTienNghi) REFERENCES TienNghi(MaTienNghi),
    CONSTRAINT FK_PhieuLapDat_Phong FOREIGN KEY(SoPhong) REFERENCES Phong(SoPhong),
    CONSTRAINT FK_PhieuLapDat_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE KhachHang(
    MaKhach varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    SoCMND varchar(30) NOT NULL UNIQUE,
    QuocTich nvarchar(80) NOT NULL,
    SoDienThoai varchar(20) NULL
);

CREATE TABLE PhieuDatPhong(
    SoPhieuDat varchar(30) NOT NULL PRIMARY KEY,
    MaKhach varchar(20) NOT NULL,
    MaNVLeTan varchar(20) NOT NULL,
    NgayLap datetime NOT NULL,
    NgayNhan date NOT NULL,
    NgayTraDuKien date NOT NULL,
    TienCoc decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienCoc >= 0),
    KenhDat nvarchar(20) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã đặt',
    NgayNhanThucTe datetime NULL,
    NgayTraThucTe datetime NULL,
    CONSTRAINT CK_PhieuDat_Ngay CHECK(NgayTraDuKien >= NgayNhan),
    CONSTRAINT CK_PhieuDat_Kenh CHECK(KenhDat IN (N'Điện thoại', N'Website',N'Trực tiếp')),
    CONSTRAINT CK_PhieuDat_TrangThai CHECK(TrangThai IN (N'Đã đặt', N'Đang ở', N'Đã trả', N'No-show', N'Hủy')),
    CONSTRAINT FK_PhieuDat_Khach FOREIGN KEY(MaKhach) REFERENCES KhachHang(MaKhach),
    CONSTRAINT FK_PhieuDat_NV FOREIGN KEY(MaNVLeTan) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietDatPhong(
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    SoNguoi int NOT NULL CHECK(SoNguoi > 0),
    PRIMARY KEY (SoPhieuDat, SoPhong),
    CONSTRAINT FK_CTDat_Phieu FOREIGN KEY(SoPhieuDat) REFERENCES PhieuDatPhong(SoPhieuDat),
    CONSTRAINT FK_CTDat_Phong FOREIGN KEY(SoPhong) REFERENCES Phong(SoPhong)
);

CREATE TABLE NguoiLuuTru(
    MaNguoiLT int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    HoTen nvarchar(120) NOT NULL,
    SoCMND varchar(30) NOT NULL,
    QuocTich nvarchar(80) NOT NULL,
    CONSTRAINT FK_NguoiLT_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong)
);

CREATE TABLE DichVu(
    MaDV varchar(20) NOT NULL PRIMARY KEY,
    TenDV nvarchar(120) NOT NULL,
    DonViTinh nvarchar(40) NOT NULL,
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0)
);

CREATE TABLE PhieuSuDungDV(
    SoPhieuSDDV varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgaySuDung date NOT NULL,
    MaNV varchar(20) NOT NULL,
    CONSTRAINT UQ_PhieuSDDV_PhongNgay UNIQUE(SoPhieuDat, SoPhong, NgaySuDung),
    CONSTRAINT FK_PhieuSDDV_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),
    CONSTRAINT FK_PhieuSDDV_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietPhieuSuDungDV(
    SoPhieuSDDV varchar(30) NOT NULL,
    MaDV varchar(20) NOT NULL,
    SoLuong int NOT NULL CHECK(SoLuong > 0),
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ThanhTien AS (CONVERT(decimal(18,2), SoLuong * DonGia)) PERSISTED,
    PRIMARY KEY (SoPhieuSDDV,MaDV),
    CONSTRAINT FK_CTSDDV_Phieu FOREIGN KEY (SoPhieuSDDV) REFERENCES PhieuSuDungDV(SoPhieuSDDV),
    CONSTRAINT FK_CTSDDV_DV FOREIGN KEY(MaDV) REFERENCES DichVu(MaDV)
);

CREATE TABLE QuyDinhDenBu(
    MaQuyDinh varchar(30) NOT NULL PRIMARY KEY,
    MaLoaiTN varchar(20) NOT NULL,
    MucDoThietHai nvarchar(80) NOT NULL,
    MucDenBu decimal(18,2) NOT NULL CHECK(MucDenBu >= 0),
    CONSTRAINT UQ_QDDB_Loai_MucDo UNIQUE(MaLoaiTN, MucDoThietHai),
    CONSTRAINT FK_QDDB_Loai FOREIGN KEY(MaLoaiTN) REFERENCES LoaiTienNghi(MaLoaiTN)
);

CREATE TABLE PhieuDenBu(
    SoPhieuDenBu varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL,
    SoPhong varchar(20) NOT NULL,
    NgayLap datetime NOT NULL,
    MaNV varchar(20) NOT NULL,
    TongTien decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTien >= 0),
    CONSTRAINT FK_PhieuDB_CTDat FOREIGN KEY(SoPhieuDat, SoPhong) REFERENCES ChiTietDatPhong(SoPhieuDat, SoPhong),
    CONSTRAINT FK_PhieuDB_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietPhieuDenBu(
    SoPhieuDenBu varchar(30) NOT NULL,
    MaTienNghi varchar(30) NOT NULL,
    MucDoThietHai nvarchar(80) NOT NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien >= 0),
    PRIMARY KEY (SoPhieuDenBu, MaTienNghi),
    CONSTRAINT FK_CTDB_Phieu FOREIGN KEY (SoPhieuDenBu) REFERENCES PhieuDenBu(SoPhieuDenBu),
    CONSTRAINT FK_CTDB_TienNghi FOREIGN KEY(MaTienNghi) REFERENCES TienNghi(MaTienNghi)
);

CREATE TABLE HoaDon(
    SoHoaDon varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDat varchar(30) NOT NULL UNIQUE,
    NgayLap datetime NOT NULL,
    MaNV varchar(20) NOT NULL,
    SoNgayTinhTien int NOT NULL CHECK(SoNgayTinhTien > 0),
    TienPhong decimal(18,2) NOT NULL CHECK(TienPhong >= 0),
    TienDichVu decimal(18,2) NOT NULL CHECK(TienDichVu >= 0),
    TongTien AS (CONVERT(decimal(18,2), TienPhong + TienDichVu)) PERSISTED,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chưa thanh toán',
    CONSTRAINT CK_HoaDon_TrangThai CHECK(TrangThai IN (N'Chưa thanh toán', N'Đã thanh toán')),
    CONSTRAINT FK_HoaDon_PhieuDat FOREIGN KEY(SoPhieuDat) REFERENCES PhieuDatPhong(SoPhieuDat),
    CONSTRAINT FK_HoaDon_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ThanhToan(
    MaThanhToan varchar(30) NOT NULL PRIMARY KEY,
    SoHoaDon varchar(30) NOT NULL,
    NgayThanhToan datetime NOT NULL,
    HinhThuc nvarchar(30) NOT NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
    CONSTRAINT CK_ThanhToan_HinhThuc CHECK(HinhThuc IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ', N'Ví điện tử')),
    CONSTRAINT FK_ThanhToan_HoaDon FOREIGN KEY(SoHoaDon) REFERENCES HoaDon(SoHoaDon)
);


-- Thêm dữ liệu mẫu
USE QuanLyKhachSan;
GO

-- 1. Thêm Nhân viên
INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES
('NV01', N'Nguyễn Thu Hà', N'Lễ tân', '0901000001'),
('NV02', N'Trần Minh An', N'Phục vụ phòng', '0901000002'),
('NV03', N'Lê Hoàng Nam', N'Thanh toán', '0901000003'),
('NV04', N'Phạm Mai Anh', N'Lễ tân', '0901000004'),
('NV05', N'Đỗ Thành Đạt', N'Quản lý', '0901000005');

-- 2. Thêm Khu vực
INSERT INTO KhuVuc(MaKhuVuc, TenKhuVuc) VALUES 
('A', N'Khu A (Tiêu chuẩn)'), 
('B', N'Khu B (Cao cấp)'),
('C', N'Khu C (VIP)');

-- 3. Thêm Phòng
INSERT INTO Phong(SoPhong, MaKhuVuc, SoNguoiToiDa, DonGiaNgay, TrangThai) VALUES
('A101', 'A', 2, 600000, N'Trống'), 
('A102', 'A', 3, 800000, N'Trống'),
('A103', 'A', 2, 600000, N'Bảo trì'),
('B201', 'B', 4, 1200000, N'Trống'),
('B202', 'B', 2, 1000000, N'Trống'),
('C301', 'C', 2, 2500000, N'Trống');

-- 4. Thêm Loại Tiện Nghi
INSERT INTO LoaiTienNghi (MaLoaiTN, TenLoaiTN) VALUES 
('TV', N'Ti vi'), 
('TL', N'Tủ lạnh'), 
('DT', N'Điện thoại'),
('ML', N'Máy lạnh'),
('MS', N'Máy sấy tóc');

-- 5. Thêm Tiện Nghi (Thiết bị cụ thể)
INSERT INTO TienNghi(MaTienNghi, MaLoaiTN, SoThuTu, TinhTrangHienTai) VALUES
('TV01', 'TV', 1, N'Tốt'),
('TV02', 'TV', 2, N'Tốt'),
('TV03', 'TV', 3, N'Đang sửa chữa'),
('TL01', 'TL', 1, N'Tốt'),
('TL02', 'TL', 2, N'Tốt'),
('ML01', 'ML', 1, N'Tốt'),
('ML02', 'ML', 2, N'Tốt');

-- 6. Thêm Lịch sử Lắp đặt
INSERT INTO PhieuLapDat(SoPhieuLapDat, MaTienNghi, SoPhong, NgayLap, TinhTrang, MaNV, GhiChu) VALUES
('LD001', 'TV01', 'A101', '2023-10-01', N'Lắp mới', 'NV02', N'Lắp đặt lần đầu'),
('LD002', 'TL01', 'A101', '2023-10-01', N'Lắp mới', 'NV02', N''),
('LD003', 'TV02', 'B201', '2023-10-02', N'Lắp mới', 'NV02', N''),
('LD004', 'ML01', 'C301', '2023-10-05', N'Lắp mới', 'NV02', N'Lắp cho phòng VIP');

-- 7. Thêm Khách hàng
INSERT INTO KhachHang(MaKhach, HoTen, SoCMND, QuocTich, SoDienThoai) VALUES
('KH01', N'Nguyễn Văn A', '0123456789', N'Việt Nam', '0912345678'),
('KH02', N'Trần Thị B', '0987654321', N'Việt Nam', '0987654321'),
('KH03', N'John Smith', 'US9876543', N'Mỹ', '+19876543210');

-- 8. Thêm Dịch vụ
INSERT INTO DichVu(MaDV, TenDV, DonViTinh, DonGia) VALUES
('DV01', N'Ăn sáng buffet', N'Suất', 120000),
('DV02', N'Tắm hơi', N'Lượt', 250000), 
('DV03', N'Karaoke', N'Giờ', 300000),
('DV04', N'Giặt ủi', N'Kg', 30000),
('DV05', N'Thuê xe máy', N'Ngày', 150000);

-- 9. Thêm Quy định Đền bù
INSERT INTO QuyDinhDenBu(MaQuyDinh, MaLoaiTN, MucDoThietHai, MucDenBu) VALUES
('QD01', 'TV', N'Hư hỏng nhẹ', 500000), 
('QD02', 'TV', N'Mất hoặc Hỏng nặng', 5000000), 
('QD03', 'TL', N'Hư hỏng nhẹ', 400000), 
('QD04', 'TL', N'Mất', 4000000),
('QD05', 'ML', N'Hư hỏng remote', 200000);

-- Xong phần dữ liệu danh mục tĩnh --
-- Dưới đây là phần giả lập một luồng khách hàng thuê phòng, dùng dịch vụ và thanh toán --

-- 10. Giả lập Phiếu Đặt Phòng (1 phòng đã đặt, 1 phòng đang ở, 1 phòng đã trả)
INSERT INTO PhieuDatPhong(SoPhieuDat, MaKhach, MaNVLeTan, NgayLap, NgayNhan, NgayTraDuKien, TienCoc, KenhDat, TrangThai, NgayNhanThucTe, NgayTraThucTe) VALUES
('DP001', 'KH01', 'NV01', '2023-11-01 08:00:00', '2023-11-05', '2023-11-07', 500000, N'Website', N'Đã trả', '2023-11-05 14:00:00', '2023-11-07 12:00:00'),
('DP002', 'KH02', 'NV04', '2023-11-10 09:30:00', '2023-11-15', '2023-11-18', 1000000, N'Trực tiếp', N'Đang ở', '2023-11-15 14:15:00', NULL),
('DP003', 'KH03', 'NV01', '2023-11-20 15:00:00', '2023-11-25', '2023-11-26', 0, N'Điện thoại', N'Đã đặt', NULL, NULL);

-- Cập nhật lại trạng thái phòng thực tế cho khớp
UPDATE Phong SET TrangThai = N'Đang ở' WHERE SoPhong = 'B201';

-- 11. Chi tiết đặt phòng
INSERT INTO ChiTietDatPhong(SoPhieuDat, SoPhong, SoNguoi) VALUES
('DP001', 'A101', 2),
('DP002', 'B201', 3),
('DP003', 'C301', 1);

-- 12. Nguời lưu trú
INSERT INTO NguoiLuuTru(SoPhieuDat, SoPhong, HoTen, SoCMND, QuocTich) VALUES
('DP001', 'A101', N'Nguyễn Văn A', '0123456789', N'Việt Nam'),
('DP001', 'A101', N'Nguyễn Thị C', '0123456788', N'Việt Nam'),
('DP002', 'B201', N'Trần Thị B', '0987654321', N'Việt Nam');

-- 13. Sử dụng dịch vụ (Cho phiếu DP001 đã trả phòng)
INSERT INTO PhieuSuDungDV(SoPhieuSDDV, SoPhieuDat, SoPhong, NgaySuDung, MaNV) VALUES
('SD001', 'DP001', 'A101', '2023-11-06', 'NV01');

INSERT INTO ChiTietPhieuSuDungDV(SoPhieuSDDV, MaDV, SoLuong, DonGia) VALUES
('SD001', 'DV01', 2, 120000), -- 2 suất ăn sáng
('SD001', 'DV04', 3, 30000);  -- 3 kg giặt ủi

-- 14. Đền bù (Khách ở DP001 làm hỏng remote máy lạnh)
INSERT INTO PhieuDenBu(SoPhieuDenBu, SoPhieuDat, SoPhong, NgayLap, MaNV, TongTien) VALUES
('DB001', 'DP001', 'A101', '2023-11-07 11:30:00', 'NV02', 200000);

-- Chi tiết đền bù (Giả sử A101 có lắp máy lạnh, dù bảng PhieuLapDat mẫu mình chưa ghi)
INSERT INTO ChiTietPhieuDenBu(SoPhieuDenBu, MaTienNghi, MucDoThietHai, SoTien) VALUES
('DB001', 'TV01', N'Hư hỏng nhẹ', 200000);

-- 15. Hóa đơn (Cho phiếu DP001)
-- Tiền phòng: 600,000 x 2 ngày = 1,200,000
-- Tiền dịch vụ: (120,000 * 2) + (30,000 * 3) = 330,000
INSERT INTO HoaDon(SoHoaDon, SoPhieuDat, NgayLap, MaNV, SoNgayTinhTien, TienPhong, TienDichVu, TrangThai) VALUES
('HD001', 'DP001', '2023-11-07 11:45:00', 'NV03', 2, 1200000, 330000, N'Đã thanh toán');

-- 16. Thanh toán
-- Tổng thanh toán: 1,530,000. Khách cọc 500,000, trả thêm 1,030,000
INSERT INTO ThanhToan(MaThanhToan, SoHoaDon, NgayThanhToan, HinhThuc, SoTien) VALUES
('TT001', 'HD001', '2023-11-07 11:50:00', N'Chuyển khoản', 1530000);