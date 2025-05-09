use DoAnQuanLyHocSinhTHPTs;
set dateformat dmy;
go
-- Thêm dữ liệu cho bảng GVCN
INSERT INTO GVCN (MaGiaoVien, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, MonGiangDay)
VALUES
(1, N'Nguyễn Văn A', '1980-05-15', N'Nam', N'123 Đường ABC', '0912345678', 'giaoVienA@example.com', N'Toán'),
(2, N'Trần Thị B', '1982-03-20', N'Nữ', N'456 Đường DEF', '0987654321', 'giaoVienB@example.com', N'Văn'),
(3, N'Lê Văn C', '1979-11-02', N'Nam', N'789 Đường GHI', '0938765432', 'giaoVienC@example.com', N'Anh Văn'),
(4, N'Phạm Thị D', '1983-07-11', N'Nữ', N'321 Đường UVW', '0912233445', 'giaoVienD@example.com', N'Lịch Sử'),
(5, N'Nguyễn Văn E', '1985-09-19', N'Nam', N'654 Đường XYZ', '0933445566', 'giaoVienE@example.com', N'Vật Lý'),
(6, N'Lê Thị F', '1986-01-02', N'Nữ', N'876 Đường ABC', '0977889900', 'giaoVienF@example.com', N'Hóa Học'),
(7, N'Trần Văn G', '1984-12-25', N'Nam', N'456 Đường DEF', '0911122233', 'giaoVienG@example.com', N'Sinh Học'),
(8, N'Hoàng Thị H', '1987-04-10', N'Nữ', N'789 Đường GHI', '0983344556', 'giaoVienH@example.com', N'Địa Lý'),
(9, N'Nguyễn Thị I', '1981-06-30', N'Nữ', N'123 Đường UVW', '0936677889', 'giaoVienI@example.com', N'Tin Học'),
(10, N'Phạm Văn K', '1980-08-20', N'Nam', N'321 Đường XYZ', '0902233445', 'giaoVienK@example.com', N'Thể Dục');

go
-- Thêm dữ liệu cho bảng MonHoc
INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
VALUES
(1, N'Toán'),
(2, N'Văn'),
(3, N'Anh Văn'),
(4, N'Lịch Sử'),
(5, N'Địa Lý'),
(6, N'Hóa Học'),
(7, N'Sinh Học'),
(8, N'Vật Lý'),
(9, N'Thể Dục'),
(10, N'Tin Học');

-- Thêm dữ liệu cho bảng Lop
INSERT INTO Lop (MaLop, TenLop, Khoi, MaGiaoVien)
VALUES
(101, N'10A1', 10, 1),
(102, N'10A2', 10, 2),
(201, N'11B1', 11, 3),
(202, N'11B2', 11, 4),
(301, N'12C1', 12, 5),
(302, N'12C2', 12, 6),
(103, N'10A3', 10, 7),
(203, N'11B3', 11, 8),
(303, N'12C3', 12, 9),
(104, N'10A4', 10, 10);

-- Thêm dữ liệu cho bảng HocSinh
INSERT INTO HocSinh (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaLop)
VALUES
(1, N'Nguyễn Thị D', '2008-05-15', N'Nữ', N'123 Đường UVW', '0911122233', 101),
(2, N'Trần Văn E', '2008-03-20', N'Nam', N'456 Đường UVW', '0983344556', 101),
(3, N'Lê Thị F', '2007-11-02', N'Nữ', N'789 Đường QRS', '0936677889', 102),
(4, N'Nguyễn Văn G', '2008-06-10', N'Nam', N'123 Đường UVW', '0977889900', 201),
(5, N'Trần Thị H', '2007-09-05', N'Nữ', N'321 Đường XYZ', '0912233445', 201),
(6, N'Lê Văn I', '2008-02-18', N'Nam', N'456 Đường DEF', '0933445566', 202),
(7, N'Hoàng Thị J', '2007-08-12', N'Nữ', N'789 Đường GHI', '0912345678', 301),
(8, N'Nguyễn Văn K', '2007-01-25', N'Nam', N'654 Đường ABC', '0987654321', 302),
(9, N'Trần Thị L', '2008-10-20', N'Nữ', N'876 Đường UVW', '0938765432', 303),
(10, N'Lê Văn M', '2007-03-15', N'Nam', N'321 Đường DEF', '0978123456', 104);

-- Thêm dữ liệu cho bảng Diem
INSERT INTO Diem (MaHocSinh, MaLop, MaMonHoc, HocKy, DiemMieng, Diem15Phut, Diem1Tiet, DiemHocKy, DiemTongKet, XepLoai)
VALUES
( 1, 101, 1, N'Học kỳ 1', 8.0, 7.5, 7.0, 8.0, 7.8, N'Khá'),
( 2, 101, 2, N'Học kỳ 1', 6.5, 7.0, 6.0, 6.5, 6.5, N'Trung bình'),
( 3, 102, 3, N'Học kỳ 1', 9.0, 8.5, 9.0, 9.5, 9.0, N'Giỏi'),
( 4, 201, 4, N'Học kỳ 1', 7.0, 6.5, 7.5, 8.0, 7.5, N'Khá'),
( 5, 201, 5, N'Học kỳ 1', 8.5, 8.0, 7.0, 8.5, 8.0, N'Khá'),
( 6, 202, 6, N'Học kỳ 1', 7.5, 8.0, 8.0, 8.5, 8.0, N'Khá'),
( 7, 301, 7, N'Học kỳ 1', 9.0, 9.5, 8.5, 9.0, 9.0, N'Giỏi'),
( 8, 302, 8, N'Học kỳ 1', 7.0, 7.5, 7.0, 8.0, 7.5, N'Khá'),
( 9, 303, 9, N'Học kỳ 1', 8.0, 8.0, 8.5, 9.0, 8.5, N'Giỏi'),
( 10, 104, 10, N'Học kỳ 1', 6.0, 6.5, 7.0, 6.5, 6.5, N'Trung bình');

-- Thêm điểm danh
INSERT INTO DiemDanh (MaHocSinh, MaLop, NgayDiemDanh, TrangThai)
VALUES (1, 101, '2024-12-13', N'Có mặt');  



