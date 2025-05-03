CREATE DATABASE BakeryMS
USE BakeryMS

CREATE TABLE TAIKHOAN
(
TaiKhoan NVARCHAR (100) PRIMARY KEY,
MatKhau NVARCHAR (100) not null DEFAULT 0, 
LoaiTaiKhoan NVARCHAR (20) DEFAULT N'Nhân viên'
);

INSERT INTO TAIKHOAN(TaiKhoan, MatKhau, LoaiTaiKhoan)
VALUES (N'User1','123', N'Nhân viên'),
	   (N'User2','123', N'Nhân viên'),
	   (N'Admin','123', N'Quản lý')
--------------------------------------------------------
CREATE TABLE BAN
(
MaBan INT IDENTITY PRIMARY KEY,
TenBan NVARCHAR (20) not null DEFAULT N'Bàn chưa có tên',
TrangThai NVARCHAR (20) not null DEFAULT N'Bàn trống' -- Trống || Có Khách
);
INSERT INTO BAN (TenBan, TrangThai)
VALUES	(N'Bàn 1', N'Bàn Trống'),
		(N'Bàn 2', N'Có Khách'),
		(N'Bàn 3', N'Bàn Trống'),	
		(N'Bàn 4', N'Bàn Trống'),
		(N'Bàn 5', N'Bàn Trống'),	
		(N'Bàn 6', N'Bàn Trống'),
		(N'Bàn 7', N'Bàn Trống'),	
		(N'Bàn 8', N'Bàn Trống'),
		(N'Bàn 9', N'Có người'), 
		(N'Bàn 10', N'Bàn Trống')
--------------------------------------------------------
CREATE TABLE DANHMUCSANPHAM
(
MaDanhMuc INT IDENTITY PRIMARY KEY,
TenDanhMuc NVARCHAR (100) not null DEFAULT N'Chưa đặt tên'
);
INSERT INTO DANHMUCSANPHAM(TenDanhMuc)
VALUES (N'Bánh Ngọt'),
	   (N'Bánh Mặn'),
	   (N'Bánh Mì'),
	   (N'Bánh Cookies')
--------------------------------------------------------
CREATE TABLE NHACUNGCAP
(
MaNCC NVARCHAR (100) PRIMARY KEY,
TenNCC NVARCHAR (100) not null DEFAULT N'Chưa đặt tên',
DiaChi NVARCHAR (100) not null,
SDT int not null, 
);
INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SDT)
VALUES (N'Sundo', N'Sundo Bakery', N'103 Trường Chinh, P. Tân Thới Nhất, Q.12, TP.HCM', 0283815387),
	   (N'Girval', N'Girval Bakekry', N'331 Hai Bà Trưng, P.8, Q.3, TP.HCM', 0283820688),
	   (N'BreadTalk', N'BreadTalk Vietnam', N'145 - 147 Nguyễn Thị Minh Khai, Q.1, TP.HCM', 0283930017)
--------------------------------------------------------
CREATE TABLE SANPHAM
(
MaSanPham NVARCHAR (100) PRIMARY KEY,
TenSanPham NVARCHAR (100) not null DEFAULT N'Chưa đặt tên', 
GiaTien INT not null DEFAULT 0,
MaNCC NVARCHAR (100),
MaDanhMuc INT not null,
FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP(MaNCC),
FOREIGN KEY (MaDanhMuc) REFERENCES DANHMUCSANPHAM(MaDanhMuc)
);
INSERT INTO SANPHAM(MaSanPham, TenSanPham, GiaTien, MaNCC, MaDanhMuc)
VALUES (N'TIRAMISU', N'Bánh Tiramisu', 49000, N'Girval', 1),
	   (N'CROISSANT', N'Bánh Croisant', 29000, N'Sundo', 2),
	   (N'SANDWICH', N'Bánh Sandwich', 39000, N'BreadTalk', 3),
	   (N'MACARON', N'Bánh Macaron', 39000, N'Girval', 4)
--------------------------------------------------------
CREATE TABLE KHUYENMAI
(
MaKhuyenMai NVARCHAR(50) PRIMARY KEY,
TenKhuyenMai NVARCHAR(100),
SoTienGiam INT,
NgayBatDau DATE,
NgayKetThuc DATE
);
INSERT INTO KHUYENMAI(MaKhuyenMai, TenKhuyenMai, SoTienGiam, NgayBatDau, NgayKetThuc)
VALUES (N'GIAM10KBILL60K', N'Giảm 10K cho hoá đơn từ 60K', 10000, '2025-05-01', '2025-05-31'),
	   (N'GIAM40KBILL160K', N'Giảm 40K cho hoá đơn từ 160K', 40000, '2025-05-01', '2025-05-31')
--------------------------------------------------------
CREATE TABLE DONHANG
(
MaDonHang INT IDENTITY PRIMARY KEY,
ThoiGian DATE not null DEFAULT GETDATE(),
MaBan INT not null,
MaKhuyenMai NVARCHAR(50) NULL,
TrangThai NVARCHAR (20) DEFAULT N'Đang chuẩn bị',
FOREIGN KEY (MaBan) REFERENCES BAN(MaBan),
FOREIGN KEY (MaKhuyenMai) REFERENCES KHUYENMAI(MaKhuyenMai)
);
INSERT INTO DONHANG(MaBan, MaKhuyenMai, TrangThai)
VALUES (2, N'GIAM10KBILL60K', N'Đang chuẩn bị'),
	   (4, N'GIAM40KBILL160K', N'Hoàn thành'),
	   (6, N'GIAM10KBILL60K', N'Đang chuẩn bị')
--------------------------------------------------------
CREATE TABLE CHITIETDONHANG
(
MaDonHang INT not null,
MaSanPham NVARCHAR (100),
SoLuong INT not null DEFAULT 1,
PRIMARY KEY (MaDonHang, MaSanPham)
);
INSERT INTO CHITIETDONHANG(MaDonHang, MaSanPham, SoLuong)
VALUES (1, 'TIRAMISU', 1),
	   (1, 'MACARON', 1),
	   (1, 'CROISSANT', 2),
	   (2, 'TIRAMISU', 3),
	   (2, 'SANDWICH', 1),
	   (3, 'TIRAMISU', 2),
	   (3, 'MACARON', 3)
--------------------------------------------------------
CREATE TABLE THANHTOAN
(
MaThanhToan INT IDENTITY PRIMARY KEY,
MaDonHang INT not null,
NgayThanhToan DATETIME not null DEFAULT GETDATE(),
SoTien INT not null,
HinhThuc NVARCHAR (20), -- Tiền Mặt || Chuyển Khoản
FOREIGN KEY (MaDonHang) REFERENCES DONHANG(MaDonHang)
);
INSERT INTO THANHTOAN(MaDonHang, HinhThuc, SoTien)
VALUES (1, N'Tiền Mặt', 58000),
	   (2, N'MoMo', 295000),
	   (3, N'VNPay', 87000)
--------------------------------------------------------
CREATE TABLE GIAOHANG
(
MaGiaoHang INT IDENTITY PRIMARY KEY,
MaDonHang INT not null,
DiaChi NVARCHAR(100),
SDT int not null, 
TrangThai NVARCHAR(20) DEFAULT N'Đang xử lý',
FOREIGN KEY (MaDonHang) REFERENCES DONHANG(MaDonHang)
);
INSERT INTO GIAOHANG(MaDonHang, DiaChi, SDT)
VALUES (1, N'134 Tạ Uyên, P.4, Q.11', 0983475126),
	   (2, N'8 Trường Sơn, P.15, Q.10', 0747812154),
	   (3, N'641/5 Trần Hưng Đạo, P.1, Q.5', 056345649)
----------------------------------------------------------------------------
SELECT 
    CONVERT(DATE, NgayThanhToan) AS Ngay,
    SUM(SoTien) AS TongDoanhThu
FROM THANHTOAN
GROUP BY CONVERT(DATE, NgayThanhToan)
ORDER BY Ngay;

SELECT 
    TrangThai,
    COUNT(*) AS SoLuongDon
FROM DONHANG
GROUP BY TrangThai;

SELECT 
    HinhThuc,
    SUM(SoTien) AS DoanhThu
FROM THANHTOAN
GROUP BY HinhThuc;
----------------------------------------------------------------------------
-- Stored Procedure cho KHUYENMAI
CREATE PROCEDURE sp_ThemKhuyenMai
    @MaKhuyenMai NVARCHAR(50),
    @TenKhuyenMai NVARCHAR(100),
    @SoTienGiam INT,
    @NgayBatDau DATE,
    @NgayKetThuc DATE
AS
BEGIN
    INSERT INTO KHUYENMAI (MaKhuyenMai, TenKhuyenMai, SoTienGiam, NgayBatDau, NgayKetThuc)
    VALUES (@MaKhuyenMai, @TenKhuyenMai, @SoTienGiam, @NgayBatDau, @NgayKetThuc);
END;
GO
--DROP PROCEDURE sp_ThemKhuyenMai;
CREATE PROCEDURE sp_LayDanhSachKhuyenMai
AS
BEGIN
    SELECT MaKhuyenMai, TenKhuyenMai, SoTienGiam, NgayBatDau, NgayKetThuc
    FROM KHUYENMAI;
END;
GO

CREATE PROCEDURE sp_XoaKhuyenMai
    @MaKhuyenMai NVARCHAR(50)
AS
BEGIN
    DELETE FROM KHUYENMAI
    WHERE MaKhuyenMai = @MaKhuyenMai;
END;
GO

CREATE PROCEDURE sp_SuaKhuyenMai
    @MaKhuyenMai NVARCHAR(50),
    @TenKhuyenMai NVARCHAR(100),
    @SoTienGiam INT,
    @NgayBatDau DATE,
    @NgayKetThuc DATE
AS
BEGIN
    UPDATE KHUYENMAI
    SET TenKhuyenMai = @TenKhuyenMai,
        SoTienGiam = @SoTienGiam,
        NgayBatDau = @NgayBatDau,
        NgayKetThuc = @NgayKetThuc
    WHERE MaKhuyenMai = @MaKhuyenMai;
END;
GO

-- Stored Procedure cho THANHTOAN
CREATE PROCEDURE sp_ThemThanhToan
    @MaDonHang INT,
    @SoTien INT,
    @HinhThuc NVARCHAR(20)
AS
BEGIN
    INSERT INTO THANHTOAN (MaDonHang, NgayThanhToan, SoTien, HinhThuc)
    VALUES (@MaDonHang, GETDATE(), @SoTien, @HinhThuc);
END;
GO
CREATE PROCEDURE sp_LayDanhSachThanhToan
AS
BEGIN
    SELECT MaThanhToan, MaDonHang, NgayThanhToan, SoTien, HinhThuc
    FROM THANHTOAN;
END;
GO

CREATE PROCEDURE sp_XoaThanhToan
    @MaThanhToan INT
AS
BEGIN
    DELETE FROM THANHTOAN
    WHERE MaThanhToan = @MaThanhToan;
END;
GO

CREATE PROCEDURE sp_SuaThanhToan
    @MaThanhToan INT,
    @MaDonHang INT,
    @SoTien INT,
    @HinhThuc NVARCHAR(20)
AS
BEGIN
    UPDATE THANHTOAN
    SET MaDonHang = @MaDonHang,
        SoTien = @SoTien,
        HinhThuc = @HinhThuc
    WHERE MaThanhToan = @MaThanhToan;
END;
GO
DROP PROCEDURE IF EXISTS sp_ThemDonHang;

-- Stored Procedure cho DONHANG (thêm đơn hàng)
CREATE PROCEDURE sp_ThemDonHang
    @MaBan INT,
    @MaKhuyenMai NVARCHAR(50) = NULL,
	@TrangThai NVARCHAR(20) = N'Đang chuẩn bị'
AS
BEGIN
    INSERT INTO DONHANG (MaBan, ThoiGian, MaKhuyenMai, TrangThai)
    VALUES (@MaBan, GETDATE(), @MaKhuyenMai, @TrangThai);
END;
GO
--DROP PROCEDURE IF EXISTS sp_ThemDonHang;

CREATE PROCEDURE sp_LayDanhSachDonHang
AS
BEGIN
    SELECT MaDonHang, ThoiGian, MaBan, TrangThai, MaKhuyenMai
    FROM DONHANG;
END;
GO

CREATE PROCEDURE sp_XoaDonHang
    @MaDonHang INT
AS
BEGIN
    DELETE FROM DONHANG
    WHERE MaDonHang = @MaDonHang;
END;
GO

CREATE PROCEDURE sp_SuaDonHang
    @MaDonHang INT,
    @MaBan INT,
    @TrangThai NVARCHAR(20),
    @MaKhuyenMai NVARCHAR(50) = NULL
AS
BEGIN
    UPDATE DONHANG
    SET MaBan = @MaBan,
        TrangThai = @TrangThai,
        MaKhuyenMai = @MaKhuyenMai
    WHERE MaDonHang = @MaDonHang;
END;
GO