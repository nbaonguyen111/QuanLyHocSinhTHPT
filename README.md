*************************************************HOW TO INSTALL/USE**************************************************
1. clone repo https://github.com/nbaonguyen111/QuanLyHocSinhTHPT.git hoặc download file zip và giải nén
2. truy cập folder DoAnQuanlyHocSinhTHPT
3. bên trong folder DoAnQuanlyHocSinhTHPT sẽ có 3 file sql (create database qlhsthpt.sql,insert du lieu qlhs.sql,store.sql)
4. import 3 file này vào SQL Studio ( phải cài) trong sql studio chạy lần lượt các file .sql
5. sau đó truy cập vào folder NguyenBaoNguyen_Sang1411 -> NguyenBaoNguyen_Sang1311 ->FormQuanLyHocSinh chạy file FormQuanLyHocSinh.csproj
6. vào SQL studio sau khi chạy xong các file sql thì sẽ có Database tên là DoAnQuanLyHocSinhTHPTs
7. chuột phải vào DoAnQuanLyHocSinhTHPTs chọn Properties chọn view connection properties copy phần usename vd lap mình có username là: LAPTOP-A7V1E6QE\HP
8. mở visual studio tìm các dòng  SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7V1E6QE\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
9. thay thế đoạn Data souce= {username của máy bạn}
10. done f5 và chạy chương trình
11. Xin Cảm Ơn Các Bạn
