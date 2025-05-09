
INSERT INTO ThanhPho (ThanhPho, TenThanhPho)
VALUES 
('HCM', 'Ho Chi Minh City'),
('HN', 'Hanoi'),
('DN', 'Da Nang'),
('HP', 'Hai Phong'),
('BL', 'Bac Lieu'),
('CT', 'Can Tho'),
('NT', 'Nha Trang');
GO
--delete from ThanhPho
--delete from KhachHang
--delete from NhanVien
--delete from HoaDon
--delete from SanPham
--delete from ChiTietHoaDon

INSERT INTO KhachHang (MaKH, TenCty, DiaChi, ThanhPho, DienThoai)
VALUES 
('KH001', 'Công ty ABC', N'123 Đường ABC, Quận 1', 'HCM', '0901234567'),
('KH002', 'Công ty XYZ', N'456 Đường XYZ, Quận 3', 'HN', '0912345678'),
('KH003', 'Công ty DEF', N'789 Đường DEF, Quận 5', 'DN', '0923456789'),
('KH004', 'Công ty GHI', N'321 Đường GHI, Quận 6', 'HP', '0934567890'),
('KH005', 'Công ty JKL', N'654 Đường JKL, Quận 7', 'BL', '0945678901'),
('KH006', 'Công ty MNO', N'987 Đường MNO, Quận 8', 'CT', '0956789012'),
('KH007', 'Công ty PQR', N'135 Đường PQR, Quận 9', 'NT', '0967890123');
GO


INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgayNV, DiaChi, DienThoai, Hinh)
VALUES 
('NV001', 'Nguyen', 'An', 'Nam', '2020-05-01', N'15 Đường A', '0987123456', 'HinhA'),
('NV002', 'Tran', 'Bich', 'Nữ', '2021-06-12', N'20 Đường B', '0987654321', 'HinhB'),
('NV003', 'Le', 'Duy', 'Nam', '2022-07-23', N'25 Đường C', '0976345678', 'HinhC'),
('NV004', 'Pham', 'Tuan', 'Nam', '2019-03-11', N'30 Đường D', '0912345678', 'HinhD'),
('NV005', 'Nguyen', 'Thu', 'Nữ', '2021-09-14', N'35 Đường E', '0909876543', 'HinhE'),
('NV006', 'Hoang', 'Hieu', 'Nam', '2020-11-20', N'40 Đường F', '0913456789', 'HinhF'),
('NV007', 'Viet', 'Hoa', 'Nữ', '2019-01-25', N'45 Đường G', '0922345678', 'HinhG');
GO


INSERT INTO SanPham (MaSP, TenSP, DonViTinh, DonGia, Hinh)
VALUES 
('SP001', N'Điện thoại Samsung', 'Cái', 10000000, 'HinhSP1'),
('SP002', N'Laptop Dell', 'Cái', 15000000, 'HinhSP2'),
('SP003', N'Máy tính bảng iPad', 'Cái', 8000000, 'HinhSP3'),
('SP004', N'Tai nghe AirPods', 'Cái', 3000000, 'HinhSP4'),
('SP005', N'Chuột Logitech', 'Cái', 500000, 'HinhSP5'),
('SP006', N'Bàn phím cơ', 'Cái', 700000, 'HinhSP6'),
('SP007', N'Màn hình LG', 'Cái', 5000000, 'HinhSP7');
GO


INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayLapHD, NgayNhanHang)
VALUES 
('HD001', 'KH001', 'NV001', '2023-10-15', '2023-10-20'),
('HD002', 'KH002', 'NV002', '2023-10-16', '2023-10-22'),
('HD003', 'KH003', 'NV003', '2023-10-17', '2023-10-23'),
('HD004', 'KH004', 'NV004', '2023-10-18', '2023-10-24'),
('HD005', 'KH005', 'NV005', '2023-10-19', '2023-10-25'),
('HD006', 'KH006', 'NV006', '2023-10-20', '2023-10-26'),
('HD007', 'KH007', 'NV007', '2023-10-21', '2023-10-27');
GO


INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong)
VALUES 
('HD001', 'SP001', 2),
('HD001', 'SP002', 1),
('HD002', 'SP003', 3),
('HD003', 'SP004', 1),
('HD004', 'SP005', 5),
('HD005', 'SP006', 2),
('HD006', 'SP007', 1);
GO
