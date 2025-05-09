use QLSV
go
insert into KHOA(MAKHOA,TENKHOA)
values ('TH', N'Khoa tin hoc')
go
insert into KHOA(MAKHOA,TENKHOA)
values ('KT',N'Khoa KT-TC')
go
insert into KHOA(MAKHOA,TENKHOA)
values ('QK',N'Khoa QTKD')
go
insert into KHOA(MAKHOA,TENKHOA)
values ('AV', N'Khoa Ngoại Ngữ')
go
insert into KHOA(MAKHOA,TENKHOA)
values ('DT', N'Điện - Điện tử')

-- chen du lieu cho Sinhvien
set dateformat dmy

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A01',N'Nguyễn Thị', N'Hải', 'Nu','23/03/77',N'Saigon', N'12B Võ Văn Tần', 'Q3','TH', 10000)
go 
INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A02',N'Trần Văn', N'Chính', 'Nam','24/12/77',N'Saigon', N'34 Nguyễn Bỉnh Khiêm', 'Q1','TH', 12000)
go
INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A03',N'Lê Bạch', N'Yến', 'Nu','21/02/96',N'Hà Nội', N'675 Pastuer', 'Q3','TH', 10000)

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A04',N'Trần Tuấn', N'Nam', 'Nam','20/11/77',N'Long An', N'12 Điện Biên Phủ', 'BT','AV', 80000)

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A05',N'Trần Thanh', N'Triều', 'Nam','13/02/77',N'Hà Nội', N'3 Nguyễn Thiện Thuật', 'Q5','AV',80000)

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('A06',N'Trần Văn', N'Chính', 'Nam','23/03/77',N'Saigon', N'12B Võ Văn Tần', 'Q3','TH', '')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('B01',N'Trần Thanh', N'Mai', 'Nu','12/08/77',N'Bến Tre', N'32 Lê Lai', 'Q1','TH', '')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('B02',N'Trần Thu', N'Thủy', 'Nu','01/01/77',N'Saigon', N'45 Nguyễn Thái Sơn', 'BC','TH','')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('B03',N'Lê Thị', N'Thanh', 'Nu','01/01/75',N'Saigon', N'345 Nguyễn Kiệm', 'Q1','AV', '')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('B04',N'Trần Trọng', N'Kim', 'Nam','20/12/77',N'Saigon', N'123 Lê Văn Sỹ', 'Q1','AV', '')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('C01',N'Lê Hồng ', N'Thịnh', 'Nam','01/12/77',N'Saigon', N'56 Hoàng Diệu', 'TB','TH', '')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('C02',N'Hoang Chu', N'Minh', 'Nam','3/05/76',N'Saigon', N'102 Kỳ Đồng', 'TB','AV','')

INSERT INTO SINHVIEN(MaSV,HoSV,TenSV, GIOITINH, NgaySinh, Noisinh, Diachi, quan, makhoa, hocbong)
VALUES('C03',N'Phan Quỳnh', N'Hương', 'Nu','5/05/79',N'Saigon', N'234 Phạm Văn Hai', 'GV','AV','')


-- chen du lieu cho mon hoc
insert into monhoc (Mamh, tenmh, sotiet)
values ('01', N'Cơ sở dữ liệu', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('02', N'Trí Tuệ Nhân Tạo', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('03', N'Truyền Tin', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('04', N'Đồ Họa', 60)

insert into monhoc (Mamh, tenmh, sotiet)
values ('05', N'Văn Phạm', 60)

insert into monhoc (Mamh, tenmh, sotiet)
values ('06', N'Đàm Thoại', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('07', N'Vật lý nguyên tử', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('08', N'Vật lý địa cầu', 45)

insert into monhoc (Mamh, tenmh, sotiet)
values ('09', N'Triết học đông phương', 75)
insert into monhoc (Mamh, tenmh, sotiet)
values ('10', N'Triết học tây phương', 75)

-- chen du lieu cho ket qua
insert into KETQUA
values('A01','01',2)
insert into Ketqua
values('A01','03',7)
insert into Ketqua
values('A02','01',5)
insert into Ketqua
values('A02','03',10)
insert into Ketqua
values('A02','05',9)
insert into Ketqua
values('A02','06',6.5)
insert into Ketqua
values('A03','01',5)
insert into Ketqua
values('A03','03',3)
insert into Ketqua
values('A03','05',10)
insert into Ketqua
values('A04','05',4)
insert into Ketqua
values('A05','06',8)
insert into Ketqua
values('A06','01',7)
insert into Ketqua
values('B01','03',3)
insert into Ketqua
values('B01','02',6)
insert into Ketqua
values('B02','04',10)
insert into Ketqua
values('B02','01',7)
insert into Ketqua
values('B03','03',6)
insert into Ketqua
values('B04','05',3)
insert into Ketqua
values('B04','06',4)
