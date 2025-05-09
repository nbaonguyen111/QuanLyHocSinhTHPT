CREATE DATABASE DOANQLHSTHPT;
GO

USE DOANQLHSTHPT;
GO

SET DATEFORMAT DMY;
GO

-- 1. Bảng MONHOC (Thông tin môn học) - Đảm bảo tạo trước
CREATE TABLE MONHOC (
    MaMonHoc NVARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL,
    SoTiet INT NOT NULL CHECK (SoTiet > 0)
);
GO

-- 2. Bảng GIAOVIEN (Thông tin giáo viên)
CREATE TABLE GIAOVIEN (
    MaGiaoVien NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15) CHECK (SoDienThoai LIKE '[0-9]%'),
    Email NVARCHAR(100) UNIQUE NOT NULL,
    MaMonHoc NVARCHAR(10) NOT NULL,
    FOREIGN KEY (MaMonHoc) REFERENCES MONHOC(MaMonHoc)
);
GO

-- 3. Bảng LOP (Thông tin lớp học)
CREATE TABLE LOP (
    MaLop NVARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    Khoi INT CHECK (Khoi BETWEEN 10 AND 12),
    MaGiaoVien NVARCHAR(10) NOT NULL,
    FOREIGN KEY (MaGiaoVien) REFERENCES GIAOVIEN(MaGiaoVien)
);
GO

-- 4. Bảng HOCSINH (Thông tin học sinh)
CREATE TABLE HOCSINH (
    MaHocSinh NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15) CHECK (SoDienThoai LIKE '[0-9]%'),
    MaLop NVARCHAR(10) NOT NULL,
    FOREIGN KEY (MaLop) REFERENCES LOP(MaLop)
);
GO

-- 5. Bảng HOCKY (Thông tin học kỳ)
CREATE TABLE HOCKY (
    MaHocKy NVARCHAR(10) PRIMARY KEY,
    TenHocKy NVARCHAR(50) NOT NULL
);
GO

-- 6. Bảng NAMHOC (Thông tin năm học)
CREATE TABLE NAMHOC (
    MaNamHoc NVARCHAR(10) PRIMARY KEY,
    TenNamHoc NVARCHAR(50) NOT NULL
);
GO

-- 7. Bảng DIEM (Điểm của học sinh)
CREATE TABLE DIEM (
    MaHocSinh NVARCHAR(10),
    MaMonHoc NVARCHAR(10),
    MaHocKy NVARCHAR(10),
    MaNamHoc NVARCHAR(10),
    DiemMieng DECIMAL(4, 2),
    Diem15Phut DECIMAL(4, 2),
    Diem1Tiet DECIMAL(4, 2),
    DiemThi DECIMAL(4, 2),
    PRIMARY KEY (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc),
    FOREIGN KEY (MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
    FOREIGN KEY (MaMonHoc) REFERENCES MONHOC(MaMonHoc),
    FOREIGN KEY (MaHocKy) REFERENCES HOCKY(MaHocKy),
    FOREIGN KEY (MaNamHoc) REFERENCES NAMHOC(MaNamHoc)
);
GO

-- 8. Bảng DIEMDANH (Thông tin điểm danh)
CREATE TABLE DIEMDANH (
    MaDiemDanh INT PRIMARY KEY IDENTITY(1,1),
    MaHocSinh NVARCHAR(10),
    NgayDiemDanh DATE NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL CHECK (TrangThai IN (N'Có mặt', N'Vắng mặt', N'Muộn')),
    FOREIGN KEY (MaHocSinh) REFERENCES HOCSINH(MaHocSinh)
);
GO

--DROP DATABASE DOANQLHSTHPT

