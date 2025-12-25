using ShoppingSystem.DAL;
using ShoppingSystem.Models;
using ShoppingSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem.BLL
{
    public class AuthService
    {
        private UserDAO dao = new UserDAO();

        // 1. Xử lý ĐĂNG NHẬP
        public User Login(string email, string password)
        {
            // Gọi tầng DAL để kiểm tra
            User user = dao.CheckLogin(email, password);

            if (user == null)
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng, hoặc tài khoản bị khóa!",
                                "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Lưu người dùng vào phiên làm việc toàn cục
            SessionManager.CurrentUser = user;
            return user;
        }

        // 2. Xử lý ĐĂNG KÝ
        public bool Register(User newUser, string rawPassword)
        {
            // Kiểm tra Gmail chuẩn (Dùng Utils)
            if (!Validator.IsValidGmail(newUser.Email))
            {
                MessageBox.Show("Email không đúng định dạng Google (@gmail.com)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra độ mạnh mật khẩu
            if (!Validator.IsValidPassword(rawPassword))
            {
                MessageBox.Show("Mật khẩu phải từ 8-16 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Email đã tồn tại chưa
            if (dao.IsEmailExist(newUser.Email))
            {
                MessageBox.Show("Email này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Mã hóa mật khẩu trước khi lưu
            newUser.Password = SecurityHelper.HashPassword(rawPassword);

            // Lưu xuống DB
            dao.AddUser(newUser);
            return true;
        }

        // Đăng xuất
        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}
