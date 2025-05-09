📚 Quản Lý Học Sinh THPT
Ứng dụng WinForms quản lý học sinh trung học phổ thông, bao gồm các chức năng quản lý học sinh, giáo viên, lớp học, điểm số, và điểm danh.

🚀 Hướng dẫn chạy ứng dụng
🔹 Bước 1: Clone hoặc tải project
Clone repo từ GitHub:

bash
Sao chép
Chỉnh sửa
git clone https://github.com/nbaonguyen111/QuanLyHocSinhTHPT.git
Hoặc tải file .zip từ GitHub và giải nén.

🔹 Bước 2: Import database
Truy cập thư mục:

Sao chép
Chỉnh sửa
QuanLyHocSinhTHPT/CSDL
Tìm 3 file SQL trong thư mục này.

Mở SQL Server Management Studio (SSMS) và lần lượt chạy cả 3 file.

Sau khi chạy xong, bạn sẽ thấy database có tên:

nginx
Sao chép
Chỉnh sửa
DoAnQuanLyHocSinhTHPTs
🔹 Bước 3: Lấy thông tin User name
Trong SSMS, click chuột phải vào database DoAnQuanLyHocSinhTHPTs.

Chọn Properties → View connection properties.

Tìm dòng User name và copy nó.

🔹 Bước 4: Cấu hình project
Trong thư mục:

nginx
Sao chép
Chỉnh sửa
QuanLyHocSinhTHPT
tìm file:

Sao chép
Chỉnh sửa
FormQuanLyHocSinh.csproj
Mở project bằng cách double-click file .csproj để mở trong Visual Studio.

🔹 Bước 5: Kết nối database
Trong Visual Studio, trên thanh navbar chọn:

pgsql
Sao chép
Chỉnh sửa
Tools → Connect to Database
Chọn:

pgsql
Sao chép
Chỉnh sửa
Microsoft SQL Server
Ở mục Server name, dán User name mà bạn đã copy ở bước 3.

Khi mục Select or enter a database name hoạt động, chọn:

nginx
Sao chép
Chỉnh sửa
DoAnQuanLyHocSinhTHPTs
Ấn OK để kết nối.

🔹 Bước 6: Chỉnh sửa chuỗi kết nối
Trong Solution Explorer (góc phải Visual Studio), click chuột phải vào project → View Code.

Tìm dòng:

csharp
Sao chép
Chỉnh sửa
SqlConnection conn = new SqlConnection("Data Source={username}\\SQLEXPRESS;Initial Catalog=DoAnQuanLyHocSinhTHPTs;Integrated Security=True");
Thay {username} bằng tên máy của bạn (hoặc User name đã copy).

🔹 Bước 7: Chạy ứng dụng
Nhấn Start (hoặc phím F5) trong Visual Studio để chạy ứng dụng.

💡 Ghi chú
Đảm bảo SQL Server của bạn đang chạy và có quyền truy cập database.

Nếu gặp lỗi kết nối, kiểm tra lại tên server hoặc cấu hình SQLEXPRESS.

Nếu bạn dùng phiên bản SQL khác (không phải SQLEXPRESS), nhớ sửa lại trong chuỗi kết nối.
