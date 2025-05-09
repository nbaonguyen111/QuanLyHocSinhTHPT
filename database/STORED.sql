USE DOANQLHSTHPT;
GO

--TABLE LOP
CREATE PROC sp_LayDSLop
AS
SELECT * FROM LOP
GO

CREATE PROC sp_ThemLop
    @MaLop VARCHAR(10),
    @TenLop NVARCHAR(50),
    @Khoi INT,
    @MaGiaoVien VARCHAR(10)
AS
BEGIN
    INSERT INTO LOP (MaLop, TenLop, Khoi, MaGiaoVien)
    VALUES (@MaLop, @TenLop, @Khoi, @MaGiaoVien);
END;
GO
CREATE PROC sp_XoaLop
    @MaLop VARCHAR(10)
AS
BEGIN
    DELETE FROM LOP WHERE MaLop = @MaLop;
END;
GO
CREATE PROCEDURE sp_SuaLop
    @malop NVARCHAR(10),
    @tenlop NVARCHAR(100),
    @Khoi NVARCHAR(10),
    @magiaovien NVARCHAR(10)
AS
BEGIN
    UPDATE LOP
    SET MaLop = @malop, -- C?p nh?t MaLop
        TenLop = @tenlop,
        Khoi = @Khoi,
        MaGiaoVien = @magiaovien
    WHERE MaLop = @malop;
END;
GO
CREATE PROC sp_TimLopTheoKhoi
    @Khoi INT
AS
BEGIN
    SELECT * FROM LOP WHERE Khoi = @Khoi;
END;
GO



--TABLE MONHOC
CREATE PROC sp_LayDSMonHoc
AS
SELECT * FROM MONHOC
GO

CREATE PROC sp_ThemMonHoc
    @MaMonHoc VARCHAR(10),
    @TenMonHoc NVARCHAR(100),
    @SoTiet INT
AS
BEGIN
    INSERT INTO MONHOC (MaMonHoc, TenMonHoc, SoTiet)
    VALUES (@MaMonHoc, @TenMonHoc, @SoTiet);
END;
GO
CREATE PROC sp_XoaMonHoc
    @MaMonHoc VARCHAR(10)
AS
BEGIN
    DELETE FROM MONHOC WHERE MaMonHoc = @MaMonHoc;
END;
GO
CREATE PROC sp_SuaMonHoc
    @MaMonHoc VARCHAR(10),
    @TenMonHoc NVARCHAR(100),
    @SoTiet INT
AS
BEGIN
    UPDATE MONHOC
    SET TenMonHoc = @TenMonHoc, SoTiet = @SoTiet
    WHERE MaMonHoc = @MaMonHoc;
END;
GO
CREATE PROC sp_TimMonHocTheoTen
    @TenMonHoc NVARCHAR(100)
AS
BEGIN
    SELECT * FROM MONHOC WHERE TenMonHoc LIKE '%' + @TenMonHoc + '%';
END;
GO



--TABLE GIAOVIEN
CREATE PROC sp_LayDSGiaoVien
AS
SELECT * FROM GIAOVIEN
GO

CREATE PROC sp_ThemGiaoVien
    @MaGiaoVien VARCHAR(10),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai VARCHAR(15),
    @Email NVARCHAR(100),
    @MaMonHoc VARCHAR(10)
AS
BEGIN
    INSERT INTO GIAOVIEN (MaGiaoVien, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, MaMonHoc)
    VALUES (@MaGiaoVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @Email, @MaMonHoc);
END;
GO
CREATE PROC sp_XoaGiaoVien
    @MaGiaoVien VARCHAR(10)
AS
BEGIN
    DELETE FROM GIAOVIEN WHERE MaGiaoVien = @MaGiaoVien;
END;
GO
CREATE PROC sp_SuaGiaoVien
    @MaGiaoVien VARCHAR(10),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai VARCHAR(15),
    @Email NVARCHAR(100),
    @MaMonHoc VARCHAR(10)
AS
BEGIN
    UPDATE GIAOVIEN
    SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, 
        DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email, MaMonHoc = @MaMonHoc
    WHERE MaGiaoVien = @MaGiaoVien;
END;
GO
CREATE PROC sp_TimGiaoVienTheoTen
    @HoTen NVARCHAR(100)
AS
BEGIN
    SELECT * FROM GIAOVIEN WHERE HoTen LIKE '%' + @HoTen + '%';
END;
GO



--TABLE HOCSINH
CREATE PROC sp_LayThongTinHocSinh
    @MaLop NVARCHAR(10),
    @MaHocKy NVARCHAR(10),
    @MaNamHoc NVARCHAR(10),
    @MaMonHoc NVARCHAR(100)
AS
BEGIN
    SELECT DISTINCT
        hs.MaHocSinh,
        hs.HoTen AS TenHocSinh,
        l.MaLop,
        hk.MaHocKy,
        nh.MaNamHoc,
        mh.MaMonHoc
    FROM 
        HOCSINH hs
    LEFT JOIN DIEM d ON hs.MaHocSinh = d.MaHocSinh
    LEFT JOIN LOP l ON hs.MaLop = l.MaLop
    LEFT JOIN HOCKY hk ON d.MaHocKy = hk.MaHocKy
    LEFT JOIN NAMHOC nh ON d.MaNamHoc = nh.MaNamHoc
    LEFT JOIN MONHOC mh ON d.MaMonHoc = mh.MaMonHoc
    WHERE 
        l.MaLop = @MaLop AND
        (d.MaHocKy = @MaHocKy OR d.MaHocKy IS NULL) AND
        (d.MaNamHoc = @MaNamHoc OR d.MaNamHoc IS NULL) AND
        (mh.MaMonHoc = @MaMonHoc OR mh.MaMonHoc IS NULL)
    ORDER BY hs.HoTen;
END;
GO

CREATE PROC sp_LayDSHocSinh
AS
SELECT * FROM HOCSINH
GO

CREATE PROC sp_ThemHocSinh  
    @MaHocSinh VARCHAR(10),  
    @HoTen NVARCHAR(100),  
    @NgaySinh DATE,  
    @GioiTinh NVARCHAR(10),  
    @DiaChi NVARCHAR(255),  
    @SoDienThoai VARCHAR(15),  
    @MaLop VARCHAR(10)  
AS  
BEGIN  
    INSERT INTO HOCSINH (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop)  
    VALUES (@MaHocSinh, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @MaLop);  
END;  
GO  
CREATE PROC sp_XoaHocSinh  
    @MaHocSinh VARCHAR(10)  
AS  
BEGIN  
    DELETE FROM HOCSINH WHERE MaHocSinh = @MaHocSinh;  
END;  
GO  
CREATE PROC sp_SuaHocSinh  
    @MaHocSinh VARCHAR(10),  
    @HoTen NVARCHAR(100),  
    @NgaySinh DATE,  
    @GioiTinh NVARCHAR(10),  
    @DiaChi NVARCHAR(255),  
    @SoDienThoai VARCHAR(15),  
    @MaLop VARCHAR(10)  
AS  
BEGIN  
    UPDATE HOCSINH  
    SET HoTen = @HoTen,  
        NgaySinh = @NgaySinh,  
        GioiTinh = @GioiTinh,  
        DiaChi = @DiaChi,  
        SoDienThoai = @SoDienThoai,  
        MaLop = @MaLop  
    WHERE MaHocSinh = @MaHocSinh;  
END;  
GO  
CREATE PROC sp_TimHocSinhTheoMa  
    @MaHocSinh VARCHAR(10)  
AS  
BEGIN  
    SELECT * FROM HOCSINH WHERE MaHocSinh = @MaHocSinh;  
END;  
GO  
CREATE PROC sp_TimHocSinhTheoTen  
    @HoTen NVARCHAR(100)  
AS  
BEGIN  
    SELECT * FROM HOCSINH WHERE HoTen LIKE '%' + @HoTen + '%';  
END;  
GO  
CREATE PROC sp_LayHocSinhTheoLop  
    @MaLop VARCHAR(10)  
AS  
BEGIN  
    SELECT * FROM HOCSINH WHERE MaLop = @MaLop;  
END;  
GO  




--TABLE HOCKY
CREATE PROC sp_LayDSHocKy
AS
SELECT * FROM HOCKY
GO

CREATE PROC sp_ThemHocKy  
    @MaHocKy VARCHAR(10),  
    @TenHocKy NVARCHAR(50)  
AS  
BEGIN  
    INSERT INTO HOCKY (MaHocKy, TenHocKy)  
    VALUES (@MaHocKy, @TenHocKy);  
END;  
GO  
CREATE PROC sp_XoaHocKy  
    @MaHocKy VARCHAR(10)  
AS  
BEGIN  
    DELETE FROM HOCKY WHERE MaHocKy = @MaHocKy;  
END;  
GO  
CREATE PROC sp_SuaHocKy  
    @MaHocKy VARCHAR(10),  
    @TenHocKy NVARCHAR(50)  
AS  
BEGIN  
    UPDATE HOCKY  
    SET TenHocKy = @TenHocKy  
    WHERE MaHocKy = @MaHocKy;  
END;  
GO  



--TABLE NAMHOC
CREATE PROC sp_LayDSNamHoc
AS
SELECT * FROM NAMHOC
GO

CREATE PROC sp_ThemNamHoc  
    @MaNamHoc VARCHAR(10),  
    @TenNamHoc NVARCHAR(50)  
AS  
BEGIN  
    INSERT INTO NAMHOC (MaNamHoc, TenNamHoc)  
    VALUES (@MaNamHoc, @TenNamHoc);  
END;  
GO  
CREATE PROC sp_XoaNamHoc  
    @MaNamHoc VARCHAR(10)  
AS  
BEGIN  
    DELETE FROM NAMHOC WHERE MaNamHoc = @MaNamHoc;  
END;  
GO  
CREATE PROC sp_SuaNamHoc  
    @MaNamHoc VARCHAR(10),  
    @TenNamHoc NVARCHAR(50)  
AS  
BEGIN  
    UPDATE NAMHOC  
    SET TenNamHoc = @TenNamHoc  
    WHERE MaNamHoc = @MaNamHoc;  
END;  
GO  



--TABLE DIEM
CREATE PROCEDURE sp_LayDiemTheoThongTin
    @MaLop NVARCHAR(50),
    @MaHocKy NVARCHAR(50),
    @MaNamHoc NVARCHAR(50),
    @MaMonHoc NVARCHAR(50),
    @MaHocSinh NVARCHAR(50) = NULL  -- Thêm tham số @MaHocSinh, mặc định NULL nếu không truyền
AS
BEGIN
    -- Truy vấn bảng điểm (Diem) kết hợp với bảng lớp, học kỳ, môn học và học sinh
    SELECT 
        d.MaHocSinh,  
        l.MaLop,
        mh.MaMonHoc,            
        nh.MaNamHoc, 
        hk.MaHocKy,
        d.DiemMieng,       
        d.Diem15Phut,      
        d.Diem1Tiet,      
        d.DiemThi
    FROM 
        HocSinh h 
    LEFT JOIN 
        Diem d ON h.MaHocSinh = d.MaHocSinh AND d.MaHocKy = @MaHocKy AND d.MaNamHoc = @MaNamHoc AND d.MaMonHoc = @MaMonHoc
    INNER JOIN 
        Lop l ON h.MaLop = l.MaLop
    INNER JOIN 
        HocKy hk ON d.MaHocKy = hk.MaHocKy
    INNER JOIN 
        NamHoc nh ON d.MaNamHoc = nh.MaNamHoc
    INNER JOIN 
        MONHOC mh ON d.MaMonHoc = mh.MaMonHoc
    WHERE
        l.MaLop = @MaLop AND
        hk.MaHocKy = @MaHocKy AND
        nh.MaNamHoc = @MaNamHoc AND
        mh.MaMonHoc = @MaMonHoc
        -- Kiểm tra @MaHocSinh nếu không NULL, sẽ lọc theo mã học sinh
        AND (@MaHocSinh IS NULL OR d.MaHocSinh = @MaHocSinh)
END;
GO

--CREATE PROC sp_LayDSDiemm
--AS
--BEGIN
--    SELECT DiemMieng, Diem15Phut, Diem1Tiet, DiemThi
--    FROM DIEM
--END;
--GO
CREATE PROCEDURE sp_LayDSDiemm
    @MaMonHoc NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Diem
    WHERE MaMonHoc = @MaMonHoc
END;
GO


CREATE PROC sp_LayDSDiem
AS
SELECT * FROM DIEM
GO

CREATE PROC sp_ThemDiem  
    @MaHocSinh VARCHAR(10),  
    @MaMonHoc VARCHAR(10),  
    @MaHocKy VARCHAR(10),  
    @MaNamHoc VARCHAR(10),  
    @DiemMieng DECIMAL(4, 2),  
    @Diem15Phut DECIMAL(4, 2),  
    @Diem1Tiet DECIMAL(4, 2),  
    @DiemThi DECIMAL(4, 2)  
AS  
BEGIN  
    INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi)  
    VALUES (@MaHocSinh, @MaMonHoc, @MaHocKy, @MaNamHoc, @DiemMieng, @Diem15Phut, @Diem1Tiet, @DiemThi);  
END;  
GO  
CREATE PROC sp_XoaDiem  
    @MaHocSinh VARCHAR(10),  
    @MaMonHoc VARCHAR(10),  
    @MaHocKy VARCHAR(10),  
    @MaNamHoc VARCHAR(10)  
AS  
BEGIN  
    DELETE FROM DIEM  
    WHERE MaHocSinh = @MaHocSinh AND MaMonHoc = @MaMonHoc AND MaHocKy = @MaHocKy AND MaNamHoc = @MaNamHoc;  
END;  
GO  
CREATE PROC sp_SuaDiem  
    @MaHocSinh VARCHAR(10),  
    @MaMonHoc VARCHAR(10),  
    @MaHocKy VARCHAR(10),  
    @MaNamHoc VARCHAR(10),  
    @DiemMieng DECIMAL(4, 2),  
    @Diem15Phut DECIMAL(4, 2),  
    @Diem1Tiet DECIMAL(4, 2),  
    @DiemThi DECIMAL(4, 2)  
AS  
BEGIN  
    UPDATE DIEM  
    SET DiemMieng = @DiemMieng, Diem15Phut = @Diem15Phut, Diem1Tiet = @Diem1Tiet, DiemThi = @DiemThi  
    WHERE MaHocSinh = @MaHocSinh AND MaMonHoc = @MaMonHoc AND MaHocKy = @MaHocKy AND MaNamHoc = @MaNamHoc;  
END;  
GO  
CREATE PROC sp_TimDiemTheoHocSinh  
    @MaHocSinh VARCHAR(10)  
AS  
BEGIN  
    SELECT * FROM DIEM WHERE MaHocSinh = @MaHocSinh;  
END;  
GO  



--TABLE DIEMDANH
CREATE PROC sp_LayDSDiemDanh
AS
SELECT * FROM DIEMDANH
GO

CREATE PROC sp_ThemDiemDanh  
    @MaDiemDanh INT,  
    @MaHocSinh VARCHAR(10),  
    @NgayDiemDanh DATE,  
    @TrangThai NVARCHAR(50)  
AS  
BEGIN  
    INSERT INTO DIEMDANH (MaDiemDanh, MaHocSinh, NgayDiemDanh, TrangThai)  
    VALUES (@MaDiemDanh, @MaHocSinh, @NgayDiemDanh, @TrangThai);  
END;  
GO  
CREATE PROC sp_XoaDiemDanh  
    @MaDiemDanh INT  
AS  
BEGIN  
    DELETE FROM DIEMDANH WHERE MaDiemDanh = @MaDiemDanh;  
END;  
GO  
CREATE PROC sp_SuaDiemDanh  
    @MaDiemDanh INT,  
    @MaHocSinh VARCHAR(10),  
    @NgayDiemDanh DATE,  
    @TrangThai NVARCHAR(50)  
AS  
BEGIN  
    UPDATE DIEMDANH  
    SET MaHocSinh = @MaHocSinh, NgayDiemDanh = @NgayDiemDanh, TrangThai = @TrangThai  
    WHERE MaDiemDanh = @MaDiemDanh;  
END;  
GO  
CREATE PROC sp_TimDiemDanhTheoHocSinh  
    @MaHocSinh VARCHAR(10)  
AS  
BEGIN  
    SELECT * FROM DIEMDANH WHERE MaHocSinh = @MaHocSinh;  
END;  
GO  

--DECLARE @procName NVARCHAR(255)

--DECLARE proc_cursor CURSOR FOR
--SELECT name
--FROM sys.objects
--WHERE type = 'P' AND is_ms_shipped = 0

--OPEN proc_cursor

--FETCH NEXT FROM proc_cursor INTO @procName

--WHILE @@FETCH_STATUS = 0
--BEGIN
--    EXEC('DROP PROCEDURE [' + @procName + ']')
--    FETCH NEXT FROM proc_cursor INTO @procName
--END

--CLOSE proc_cursor
--DEALLOCATE proc_cursor




select * from HOCSINH