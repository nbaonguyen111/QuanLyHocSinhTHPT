CREATE DATABASE DoAnQuanLyHocSinhTHPTs;
GO
USE DoAnQuanLyHocSinhTHPTs;
GO

SET DATEFORMAT DMY;
GO

-- Bảng GVCN (Giáo viên chủ nhiệm)
CREATE TABLE GVCN (
    MaGiaoVien INT PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(15) CHECK (DienThoai LIKE '[0-9]%'),
    Email NVARCHAR(100) UNIQUE NOT NULL,
    MonGiangDay NVARCHAR(100) NOT NULL,
    HinhAnh IMAGE
);

-- Bảng Môn Học
CREATE TABLE MonHoc (
    MaMonHoc INT PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
);

-- Bảng Lớp
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    Khoi INT CHECK (Khoi BETWEEN 10 AND 12),
    MaGiaoVien INT UNIQUE, -- Mỗi giáo viên chỉ chủ nhiệm một lớp
    CONSTRAINT FK_Lop_GVCN FOREIGN KEY (MaGiaoVien) REFERENCES GVCN(MaGiaoVien) ON DELETE SET NULL
);

-- Bảng Học Sinh
CREATE TABLE HocSinh (
    MaHocSinh INT PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(15) CHECK (DienThoai LIKE '[0-9]%'),
    MaLop INT NOT NULL,
    HinhAnh IMAGE,
    CONSTRAINT FK_HocSinh_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE
);

-- Bảng Điểm
CREATE TABLE Diem (
    MaHocSinh INT NOT NULL,
    MaLop INT NOT NULL,
    MaMonHoc INT NOT NULL,
    HocKy NVARCHAR(50) CHECK (HocKy IN (N'Học kỳ 1', N'Học kỳ 2')),
    DiemMieng DECIMAL(5, 2) CHECK (DiemMieng BETWEEN 0 AND 10),
    Diem15Phut DECIMAL(5, 2) CHECK (Diem15Phut BETWEEN 0 AND 10),
    Diem1Tiet DECIMAL(5, 2) CHECK (Diem1Tiet BETWEEN 0 AND 10),
    DiemHocKy DECIMAL(5, 2) CHECK (DiemHocKy BETWEEN 0 AND 10),
    DiemTongKet DECIMAL(5, 2) CHECK (DiemTongKet BETWEEN 0 AND 10),
    XepLoai NVARCHAR(50) CHECK (XepLoai IN (N'Giỏi', N'Khá', N'Trung bình', N'Yếu')),
    CONSTRAINT FK_Diem_HocSinh FOREIGN KEY (MaHocSinh) REFERENCES HocSinh(MaHocSinh) ON DELETE CASCADE,
    CONSTRAINT FK_Diem_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE No Action,
    CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) ON DELETE CASCADE
);
-- Bảng Điểm Danh
CREATE TABLE DiemDanh (
    MaHocSinh INT NOT NULL,
    MaLop INT NOT NULL,
    NgayDiemDanh DATE NOT NULL,
    TrangThai NVARCHAR(50) CHECK (TrangThai IN (N'Có mặt', N'Vắng mặt', N'Muộn')),
    CONSTRAINT FK_DiemDanh_HocSinh FOREIGN KEY (MaHocSinh) REFERENCES HocSinh(MaHocSinh) ON DELETE CASCADE,
    CONSTRAINT FK_DiemDanh_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE NO ACTION,
    PRIMARY KEY (MaHocSinh, NgayDiemDanh)  -- Khóa chính chỉ cần MaHocSinh và NgayDiemDanh, không cần MaLop nữa
);






	

---- Xóa ràng buộc khóa ngoại cũ
--ALTER TABLE Lop DROP CONSTRAINT FK_Lop_GVCN;
--ALTER TABLE HocSinh DROP CONSTRAINT FK_HocSinh_Lop;
--ALTER TABLE Diem DROP CONSTRAINT FK_Diem_HocSinh;
--ALTER TABLE Diem DROP CONSTRAINT FK_Diem_Lop;
--ALTER TABLE Diem DROP CONSTRAINT FK_Diem_MonHoc;
--ALTER TABLE DiemDanh DROP CONSTRAINT FK_DiemDanh_HocSinh;
--ALTER TABLE DiemDanh DROP CONSTRAINT FK_DiemDanh_Lop;

---- Bảng Lop
--ALTER TABLE Lop
--ADD CONSTRAINT FK_Lop_GVCN
--FOREIGN KEY (MaGiaoVien) REFERENCES GVCN(MaGiaoVien) ON DELETE SET NULL;

---- Bảng HocSinh
--ALTER TABLE HocSinh
--ADD CONSTRAINT FK_HocSinh_Lop
--FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE;

---- Bảng Diem
--ALTER TABLE Diem
--ADD CONSTRAINT FK_Diem_HocSinh
--FOREIGN KEY (MaHocSinh) REFERENCES HocSinh(MaHocSinh) ON DELETE CASCADE;

--ALTER TABLE Diem
--ADD CONSTRAINT FK_Diem_Lop
--FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE SET NULL;


--ALTER TABLE Diem
--ADD CONSTRAINT FK_Diem_MonHoc
--FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) ON DELETE CASCADE;

---- Bảng DiemDanh
--ALTER TABLE DiemDanh
--ADD CONSTRAINT FK_DiemDanh_HocSinh
--FOREIGN KEY (MaHocSinh) REFERENCES HocSinh(MaHocSinh) ON DELETE CASCADE;

--ALTER TABLE DiemDanh
--ADD CONSTRAINT FK_DiemDanh_Lop
--FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE;
go

