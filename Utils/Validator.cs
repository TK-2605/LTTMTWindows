    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem.Utils
{
    public static class Validator
    {
        public static bool IsValidGmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            // Regex:
            // ^            : Bắt đầu chuỗi
            // [a-z0-9]     : Ký tự đầu phải là chữ hoặc số (Không được là dấu chấm)
            // (            : Nhóm các ký tự tiếp theo
            //   \.?        : Cho phép 1 dấu chấm (hoặc không)
            //   [a-z0-9]   : Sau dấu chấm bắt buộc phải là chữ/số (Chặn ".." và chặn kết thúc bằng ".")
            // ){5,29}      : Lặp lại nhóm trên 5-29 lần (Tổng cộng độ dài username thành 6-30)
            // @gmail\.com$ : Kết thúc bắt buộc là @gmail.com

            string pattern = @"^[a-z0-9](\.?[a-z0-9]){5,29}@gmail\.com$";

            // RegexOptions.IgnoreCase: Tự động hiểu A = a 
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }


        // - Phải là số, viết liền
        // - Bắt đầu bằng 0
        // - Tổng cộng 10 số
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;

            // ^0       : Bắt đầu bằng số 0
            // \d{9}$   : Theo sau là đúng 9 chữ số nữa
            string pattern = @"^0\d{9}$";

            return Regex.IsMatch(phone, pattern);
        }

        // Kiểm tra mật khẩu (Tùy chọn: Ít nhất 8 ký tự)
        public static bool IsValidPassword(string pass)
        {
             return pass.Length >= 8 && pass.Length <= 16;
        }
    }
}


// note 
// Trong sự kiện btnRegister_Click:

//string pass = txtPassword.Text.Trim();

//if (!Validator.IsValidPassword(pass))
//{
 //   MessageBox.Show("Mật khẩu phải từ 8 đến 16 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//return; // Dừng lại, không cho đăng ký tiếp
//}

// Nếu đúng thì mới chạy tiếp lệnh mã hóa và lưu vào DB...