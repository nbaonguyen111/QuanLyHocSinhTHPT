using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLyHocSinh
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Trợ Giúp Ứng Dụng";
            rtxtContent.Text = @"
1. Giới Thiệu Về Ứng Dụng:
   Ứng dụng của chúng tôi giúp quản lý các công việc văn phòng hiệu quả hơn. Với các tính năng như...
   
2. Hướng Dẫn Sử Dụng:
   - Để thêm công việc mới: Bấm vào nút 'Thêm Mới' và điền thông tin vào các trường yêu cầu.
   - Để xóa công việc: Chọn công việc và bấm 'Xóa'.
   
3. Câu Hỏi Thường Gặp:
   - Làm thế nào để thay đổi mật khẩu?
   - Nếu không thể đăng nhập, tôi phải làm gì?

4. Liên Hệ Hỗ Trợ:
   - Email: nooobao86@gmail.com
   - Số điện thoại: 0866633426

5. Chính Sách và Điều Khoản:
   Xem các điều khoản sử dụng và chính sách bảo mật của ứng dụng tại [https://www.facebook.com/]";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}


