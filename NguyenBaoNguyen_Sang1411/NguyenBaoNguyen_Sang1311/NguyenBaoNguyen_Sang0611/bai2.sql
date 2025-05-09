-- Thêm khách hàng
create proc sp_themKhachHang
    @MaKH NVARCHAR(10),
    @TenCty NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @ThanhPho NVARCHAR(50),
    @DienThoai NVARCHAR(15)
AS
BEGIN
    INSERT INTO KhachHang (MaKH, TenCty, DiaChi, ThanhPho, DienThoai)
    VALUES (@MaKH, @TenCty, @DiaChi, @ThanhPho, @DienThoai);
END;
GO

-- Thêm nhân viên
create proc sp_themNhanVien
    @MaNV NVARCHAR(10),
    @Ho NVARCHAR(50),
    @Ten NVARCHAR(50),
    @GioiTinh NVARCHAR(10),
    @NgayNV DATE,
    @DiaChi NVARCHAR(100),
    @DienThoai NVARCHAR(15),
    @Hinh NVARCHAR(30)
AS
BEGIN
    INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgayNV, DiaChi, DienThoai, Hinh)
    VALUES (@MaNV, @Ho, @Ten, @GioiTinh, @NgayNV, @DiaChi, @DienThoai, @Hinh);
END;
GO

-- Thêm sản phẩm
create proc sp_themSanPham
    @MaSP NVARCHAR(10),
    @TenSP NVARCHAR(100),
    @DonViTinh NVARCHAR(50),
    @DonGia INT,
    @Hinh NVARCHAR(30)
AS
BEGIN
    INSERT INTO SanPham (MaSP, TenSP, DonViTinh, DonGia, Hinh)
    VALUES (@MaSP, @TenSP, @DonViTinh, @DonGia, @Hinh);
END;
GO

-- Thêm hóa đơn
create proc sp_themHoaDon
    @MaHD NVARCHAR(10),
    @MaKH NVARCHAR(10),
    @MaNV NVARCHAR(10),
    @NgayLapHD DATE,
    @NgayNhanHang DATE
AS
BEGIN
    INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayLapHD, NgayNhanHang)
    VALUES (@MaHD, @MaKH, @MaNV, @NgayLapHD, @NgayNhanHang);
END;
GO

-- Thêm chi tiết hóa đơn
create proc sp_themChiTietHoaDon
    @MaHD NVARCHAR(10),
    @MaSP NVARCHAR(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong)
    VALUES (@MaHD, @MaSP, @SoLuong);
END;
GO

-- Sửa thông tin khách hàng
create proc sp_suaKhachHang
    @MaKH NVARCHAR(10),
    @TenCty NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @ThanhPho NVARCHAR(50),
    @DienThoai NVARCHAR(15)
AS
BEGIN
    UPDATE KhachHang
    SET TenCty = @TenCty, DiaChi = @DiaChi, ThanhPho = @ThanhPho, DienThoai = @DienThoai
    WHERE MaKH = @MaKH;
END;
GO

-- Sửa thông tin nhân viên
create  proc sp_suaNhanVien
    @MaNV NVARCHAR(10),
    @Ho NVARCHAR(50),
    @Ten NVARCHAR(50),
    @GioiTinh NVARCHAR(10),
    @NgayNV DATE,
    @DiaChi NVARCHAR(100),
    @DienThoai NVARCHAR(15),
    @Hinh NVARCHAR(30)
AS
BEGIN
    UPDATE NhanVien
    SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgayNV = @NgayNV, DiaChi = @DiaChi, DienThoai = @DienThoai, Hinh = @Hinh
    WHERE MaNV = @MaNV;
END;
GO

-- Sửa thông tin sản phẩm
create proc sp_suaSanPham
    @MaSP NVARCHAR(10),
    @TenSP NVARCHAR(100),
    @DonViTinh NVARCHAR(50),
    @DonGia INT,
    @Hinh NVARCHAR(30)
AS
BEGIN
    UPDATE SanPham
    SET TenSP = @TenSP, DonViTinh = @DonViTinh, DonGia = @DonGia, Hinh = @Hinh
    WHERE MaSP = @MaSP;
END;
GO

-- Sửa hóa đơn
create proc sp_suaHoaDon
    @MaHD NVARCHAR(10),
    @MaKH NVARCHAR(10),
    @MaNV NVARCHAR(10),
    @NgayLapHD DATE,
    @NgayNhanHang DATE
AS
BEGIN
    UPDATE HoaDon
    SET MaKH = @MaKH, MaNV = @MaNV, NgayLapHD = @NgayLapHD, NgayNhanHang = @NgayNhanHang
    WHERE MaHD = @MaHD;
END;
GO

-- Sửa chi tiết hóa đơn
create proc sp_suaChiTietHoaDon
    @MaHD NVARCHAR(10),
    @MaSP NVARCHAR(10),
    @SoLuong INT
AS
BEGIN
    UPDATE ChiTietHoaDon
    SET SoLuong = @SoLuong
    WHERE MaHD = @MaHD AND MaSP = @MaSP;
END;
GO

-- Xóa khách hàng
create proc sp_xoaKhachHang
    @MaKH NVARCHAR(10)
AS
BEGIN
    DELETE FROM KhachHang WHERE MaKH = @MaKH;
END;
GO

-- Xóa nhân viên
create proc sp_xoaNhanVien
    @MaNV NVARCHAR(10)
AS
BEGIN
    DELETE FROM NhanVien WHERE MaNV = @MaNV;
END;
GO

-- Xóa sản phẩm
create proc sp_xoaSanPham
    @MaSP NVARCHAR(10)
AS
BEGIN
    DELETE FROM SanPham WHERE MaSP = @MaSP;
END;
GO

-- Xóa hóa đơn
create proc sp_xoaHoaDon
    @MaHD NVARCHAR(10)
AS
BEGIN
    DELETE FROM HoaDon WHERE MaHD = @MaHD;
END;
GO


create proc sp_xoaChiTietHoaDon
    @MaHD NVARCHAR(10),
    @MaSP NVARCHAR(10)
AS
BEGIN
    DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP;
END;
GO


create proc sp_getAllKhachHang
AS
BEGIN
    SELECT * FROM KhachHang;
END;
GO


create proc sp_getAllNhanVien
AS
BEGIN
    SELECT * FROM NhanVien;
END;
GO


create proc sp_getAllSanPham
AS
BEGIN
    SELECT * FROM SanPham;
END;
GO


create proc sp_getAllHoaDon
AS
BEGIN
    SELECT * FROM HoaDon;
END;
GO


create proc sp_getChiTietHoaDon
    @MaHD NVARCHAR(10)
AS
BEGIN
    SELECT * FROM ChiTietHoaDon WHERE MaHD = @MaHD;
END;
GO


create function dbo.fn_getKhachHangCountByThanhPho (@ThanhPho NVARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(*) FROM KhachHang WHERE ThanhPho = @ThanhPho;
    RETURN @Count;
END;
GO


create function dbo.fn_getTenKhachHangByMaKH (@MaKH NVARCHAR(10))
RETURNS NVARCHAR(100)
AS
BEGIN
    DECLARE @TenCty NVARCHAR(100);
    SELECT @TenCty = TenCty FROM KhachHang WHERE MaKH = @MaKH;
    RETURN @TenCty;
END;
GO

exec sp_themKhachHang 
    @MaKH = 'KH0010',
    @TenCty = N'Công Ty ABC',
    @DiaChi = N'123 Đường XYZ',
    @ThanhPho = 'HN',
    @DienThoai = '0123456789';
	select * from KhachHang

	EXEC sp_themNhanVien 
    @MaNV = 'NV001',
    @Ho = 'Nguyễn Văn',
    @Ten = 'A',
    @GioiTinh = 'Nam',
    @NgayNV = '2022-01-01',
    @DiaChi = '456 Đường LMN',
    @DienThoai = '0987654321',
    @Hinh = 'nhanvien001';

	EXEC sp_themSanPham 
    @MaSP = 'SP001',
    @TenSP = 'Máy tính xách tay',
    @DonViTinh = 'Cái',
    @DonGia = 15000000,
    @Hinh = 'maytinh.jpg';

	EXEC sp_themHoaDon 
    @MaHD = 'HD001',
    @MaKH = 'KH001',
    @MaNV = 'NV001',
    @NgayLapHD = '2024-11-01',
    @NgayNhanHang = '2024-11-05';

	EXEC sp_themChiTietHoaDon 
    @MaHD = 'HD001',
    @MaSP = 'SP001',
    @SoLuong = 2;

	EXEC sp_suaKhachHang 
    @MaKH = 'KH001',
    @TenCty = 'Công Ty XYZ',
    @DiaChi = '789 Đường ABC',
    @ThanhPho = 'Hồ Chí Minh',
    @DienThoai = '0123456789';

	EXEC sp_suaNhanVien 
    @MaNV = 'NV001',
    @Ho = 'Trần Quang',
    @Ten = 'B',
    @GioiTinh = 'Nam',
    @NgayNV = '2023-01-01',
    @DiaChi = '123 Đường QWE',
    @DienThoai = '0987654321',
    @Hinh = 'nhanvien002.jpg';

	EXEC sp_suaSanPham 
    @MaSP = 'SP001',
    @TenSP = 'Máy tính để bàn',
    @DonViTinh = 'Cái',
    @DonGia = 12000000,
    @Hinh = 'maytinhdeban.jpg';

	EXEC sp_suaSanPham 
    @MaSP = 'SP001',
    @TenSP = 'Máy tính để bàn',
    @DonViTinh = 'Cái',
    @DonGia = 12000000,
    @Hinh = 'maytinhdeban.jpg';

	EXEC sp_suaHoaDon 
    @MaHD = 'HD001',
    @MaKH = 'KH002',
    @MaNV = 'NV002',
    @NgayLapHD = '2024-11-02',
    @NgayNhanHang = '2024-11-06';

	EXEC sp_suaChiTietHoaDon 
    @MaHD = 'HD001',
    @MaSP = 'SP001',
    @SoLuong = 3;

	EXEC sp_xoaKhachHang @MaKH = 'KH001';

	EXEC sp_xoaNhanVien @MaNV = 'NV001';

	EXEC sp_xoaSanPham @MaSP = 'SP001';

	EXEC sp_xoaHoaDon @MaHD = 'HD001';

	EXEC sp_xoaChiTietHoaDon @MaHD = 'HD001', @MaSP = 'SP001';

	EXEC sp_getAllKhachHang;

	EXEC sp_getAllNhanVien;

	EXEC sp_getAllSanPham;

	EXEC sp_getAllHoaDon;

	EXEC sp_getChiTietHoaDon @MaHD = 'HD001';

	


