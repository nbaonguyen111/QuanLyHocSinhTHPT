USE DOANQLHSTHPT;
GO

SET DATEFORMAT DMY;
GO

-- Thêm dữ liệu cho MONHOC
INSERT INTO MONHOC (MaMonHoc, TenMonHoc, SoTiet) VALUES
('MH001', N'Toán', 45),
('MH002', N'Ngữ Văn', 45),
('MH003', N'Tiếng Anh', 45),
('MH004', N'Vật Lý', 45),
('MH005', N'Hóa Học', 45),
('MH006', N'Sinh Học', 45),
('MH007', N'Lịch Sử', 45),
('MH008', N'Địa Lý', 45),
('MH009', N'Giáo Dục Công Dân', 45),
('MH010', N'Tin Học', 45);
GO

-- Thêm dữ liệu cho GIAOVIEN
INSERT INTO GIAOVIEN (MaGiaoVien, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, MaMonHoc) VALUES
('GV001', N'Nguyễn Văn An', '1978-03-12', N'Nam', N'Hà Nội', '0901234567', 'GiaovienA@example.com', 'MH001'),
('GV002', N'Lê Thị Hoa', '1985-06-15', N'Nữ', N'Hải Phòng', '0912345678', 'GiaovienB@example.com', 'MH002'),
('GV003', N'Trần Văn Minh', '1980-08-25', N'Nam', N'Đà Nẵng', '0923456789', 'GiaovienC@example.com', 'MH003'),
('GV004', N'Phạm Thị Lan', '1988-05-01', N'Nữ', N'Huế', '0934567890', 'GiaovienD@example.com', 'MH004'),
('GV005', N'Hoàng Văn Bình', '1973-12-18', N'Nam', N'Sài Gòn', '0945678901', 'GiaovienE@example.com', 'MH005'),
('GV006', N'Nguyễn Thị Mai', '1990-02-10', N'Nữ', N'Bắc Giang', '0908765432', 'GiaovienF@example.com', 'MH006'),
('GV007', N'Lê Hoàng Minh', '1985-11-25', N'Nam', N'Hải Phòng', '0911234567', 'GiaovienG@example.com', 'MH007'),
('GV008', N'Phan Thị Thanh', '1992-07-30', N'Nữ', N'Hà Nội', '0922334455', 'GiaovienH@example.com', 'MH008'),
('GV009', N'Trần Minh Tâm', '1980-01-18', N'Nam', N'Đà Nẵng', '0933445566', 'GiaovienI@example.com', 'MH009'),
('GV010', N'Hoàng Thị Lâm', '1987-09-05', N'Nữ', N'Sài Gòn', '0944556677', 'GiaovienJ@example.com', 'MH010');
GO

-- Thêm dữ liệu cho NAMHOC
INSERT INTO NAMHOC (MaNamHoc, TenNamHoc) VALUES
('NH2022', '2022-2023'),
('NH2023', '2023-2024'),
('NH2024', '2024-2025');
GO

-- Thêm dữ liệu cho HOCKY
INSERT INTO HOCKY (MaHocKy, TenHocKy) VALUES
('HK1', N'Học kỳ 1'),
('HK2', N'Học kỳ 2');
GO

-- Thêm dữ liệu cho LOP
INSERT INTO LOP (MaLop, TenLop, Khoi, MaGiaoVien) VALUES
('10A1', N'Lớp 10A1', 10, 'GV001'),
('10A2', N'Lớp 10A2', 10, 'GV002'),
('11B1', N'Lớp 11B1', 11, 'GV003'),
('11B2', N'Lớp 11B2', 11, 'GV004'),
('12C1', N'Lớp 12C1', 12, 'GV005');
GO

-- Thêm dữ liệu cho HOCSINH
INSERT INTO HOCSINH (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop) VALUES
('HS001', N'Nguyễn Văn Hùng', '2008-09-10', N'Nam', N'Hà Nội', '0987654321', '10A1'),
('HS002', N'Phạm Thị Mai', '2008-06-25', N'Nữ', N'Hải Phòng', '0976543210', '10A2'),
('HS003', N'Lê Thị Bích', '2007-11-20', N'Nữ', N'Đà Nẵng', '0965432109', '11B1'),
('HS004', N'Trần Văn Sơn', '2007-08-25', N'Nam', N'Huế', '0954321098', '11B2'),
('HS005', N'Hoàng Thị Vân', '2007-12-20', N'Nữ', N'Sài Gòn', '0943210987', '12C1');
GO

-- Thêm dữ liệu cho DIEM HK1
INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES
('HS001', 'MH001', 'HK1', 'NH2022', 7.5, 8.0, 8.0, 7.5),  -- Toán
('HS001', 'MH002', 'HK1', 'NH2022', 6.5, 7.0, 7.0, 7.0),  -- Ngữ Văn
('HS001', 'MH003', 'HK1', 'NH2022', 8.0, 7.5, 7.0, 8.0),  -- Tiếng Anh
('HS001', 'MH004', 'HK1', 'NH2022', 7.0, 7.0, 7.0, 8.0),  -- Vật Lý
('HS001', 'MH005', 'HK1', 'NH2022', 6.5, 7.5, 8.0, 7.5),  -- Hóa Học
('HS001', 'MH006', 'HK1', 'NH2022', 8.0, 8.5, 8.0, 8.5),  -- Sinh Học	
('HS001', 'MH007', 'HK1', 'NH2022', 7.5, 7.0, 8.0, 7.0),  -- Lịch Sử
('HS001', 'MH008', 'HK1', 'NH2022', 6.0, 7.5, 6.5, 7.5),  -- Địa Lý
('HS001', 'MH009', 'HK1', 'NH2022', 8.5, 8.0, 8.5, 9.0),  -- Giáo Dục Công Dân
('HS001', 'MH010', 'HK1', 'NH2022', 7.5, 8.0, 7.5, 8.0);  -- Tin Học
GO

-- Thêm dữ liệu cho DIEM HK2
INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES
('HS001', 'MH001', 'HK2', 'NH2022', 7.0, 6.5, 7.0, 7.5),  -- Toán
('HS001', 'MH002', 'HK2', 'NH2022', 7.0, 7.5, 7.0, 8.0),  -- Ngữ Văn
('HS001', 'MH003', 'HK2', 'NH2022', 8.0, 7.0, 8.0, 8.0),  -- Tiếng Anh
('HS001', 'MH004', 'HK2', 'NH2022', 7.5, 8.0, 8.5, 7.0),  -- Vật Lý
('HS001', 'MH005', 'HK2', 'NH2022', 7.0, 7.5, 7.0, 8.5),  -- Hóa Học
('HS001', 'MH006', 'HK2', 'NH2022', 8.0, 7.5, 8.5, 8.0),  -- Sinh Học
('HS001', 'MH007', 'HK2', 'NH2022', 6.5, 7.0, 7.0, 7.5),  -- Lịch Sử
('HS001', 'MH008', 'HK2', 'NH2022', 7.5, 7.0, 6.5, 7.0),  -- Địa Lý
('HS001', 'MH009', 'HK2', 'NH2022', 8.5, 8.0, 7.5, 8.5),  -- Giáo Dục Công Dân
('HS001', 'MH010', 'HK2', 'NH2022', 7.0, 7.5, 7.5, 8.0);  -- Tin Học
GO

-- Thêm dữ liệu cho DIEMDANH
INSERT INTO DIEMDANH (MaHocSinh, NgayDiemDanh, TrangThai) VALUES
('HS001', '2023/09/05', N'Có mặt'),
('HS002', '2023/09/06', N'Có mặt'),
('HS003', '2023/09/07', N'Vắng mặt'),
('HS004', '2023/09/08', N'Muộn'),
('HS005', '2023/09/09', N'Có mặt');
GO


--DELETE FROM DIEMDANH;
--DELETE FROM DIEM;
--DELETE FROM HOCSINH;
--DELETE FROM GIAOVIEN;
--DELETE FROM MONHOC;
--DELETE FROM LOP;
--DELETE FROM HOCKY;
--DELETE FROM NAMHOC;
--GO

INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES
('HS006', 'MH001', 'HK1', 'NH2022', 7.5, 8.0, 8.0, 7.5),  -- Toán
('HS006', 'MH002', 'HK1', 'NH2022', 6.5, 7.0, 7.0, 7.0),  -- Ngữ Văn
('HS006', 'MH003', 'HK1', 'NH2022', 8.0, 7.5, 7.0, 8.0),  -- Tiếng Anh
('HS006', 'MH004', 'HK1', 'NH2022', 7.0, 7.0, 7.0, 8.0),  -- Vật Lý
('HS006', 'MH005', 'HK1', 'NH2022', 6.5, 7.5, 8.0, 7.5),  -- Hóa Học
('HS006', 'MH006', 'HK1', 'NH2022', 8.0, 8.5, 8.0, 8.5),  -- Sinh Học	
('HS006', 'MH007', 'HK1', 'NH2022', 7.5, 7.0, 8.0, 7.0),  -- Lịch Sử
('HS006', 'MH008', 'HK1', 'NH2022', 6.0, 7.5, 6.5, 7.5),  -- Địa Lý
('HS006', 'MH009', 'HK1', 'NH2022', 8.5, 8.0, 8.5, 9.0),  -- Giáo Dục Công Dân
('HS006', 'MH010', 'HK1', 'NH2022', 7.5, 8.0, 7.5, 8.0);  -- Tin Học
GO

INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES
('HS006', 'MH001', 'HK2', 'NH2022', 7.5, 8.0, 8.0, 7.5),  -- Toán
('HS006', 'MH002', 'HK2', 'NH2022', 6.5, 7.0, 7.0, 7.0),  -- Ngữ Văn
('HS006', 'MH003', 'HK2', 'NH2022', 8.0, 7.5, 7.0, 8.0),  -- Tiếng Anh
('HS006', 'MH004', 'HK2', 'NH2022', 7.0, 7.0, 7.0, 8.0),  -- Vật Lý
('HS006', 'MH005', 'HK2', 'NH2022', 6.5, 7.5, 8.0, 7.5),  -- Hóa Học
('HS006', 'MH006', 'HK2', 'NH2022', 8.0, 8.5, 8.0, 8.5),  -- Sinh Học	
('HS006', 'MH007', 'HK2', 'NH2022', 7.5, 7.0, 8.0, 7.0),  -- Lịch Sử
('HS006', 'MH008', 'HK2', 'NH2022', 6.0, 7.5, 6.5, 7.5),  -- Địa Lý
('HS006', 'MH009', 'HK2', 'NH2022', 8.5, 8.0, 8.5, 9.0),  -- Giáo Dục Công Dân
('HS006', 'MH010', 'HK2', 'NH2022', 7.5, 8.0, 7.5, 8.0);  -- Tin Học
GO

