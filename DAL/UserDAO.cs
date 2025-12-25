
using ShoppingSystem.Models;
using ShoppingSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public class UserDAO
    {
        // Kiểm tra đăng nhập
        public User CheckLogin(string email, string plainPassword)
        {
            using (var db = new ShoppingContext())
            {
                // 1. Chỉ tìm theo Email (và phải đang hoạt động)
                var user = db.Users.FirstOrDefault(u => u.Email == email && u.IsActive == true);

                // 2. Nếu tìm thấy User, bắt đầu check pass
                if (user != null)
                {
                    // user.Password lúc này là chuỗi "Salt:Hash"
                    bool isCorrect = SecurityHelper.VerifyPassword(plainPassword, user.Password);

                    if (isCorrect)
                    {
                        return user; // Đăng nhập thành công
                    }
                }

                return null; // Sai email hoặc sai pass

                //gọi 
                //Khi tạo user mới:
               // newUser.Password = SecurityHelper.HashPassword(txtPassword.Text);
            }
        }

        // Kiểm tra Email đã tồn tại chưa (dùng khi đăng ký)
        public bool IsEmailExist(string email)
        {
            using (var db = new ShoppingContext())
            {
                return db.Users.Any(u => u.Email == email);
            }
        }

        // Thêm User mới (Đăng ký)
        public void AddUser(User newUser)
        {
            using (var db = new ShoppingContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        // Cập nhật điểm tích lũy
        public void UpdatePoint(int userId, int pointsToAdd)
        {
            using (var db = new ShoppingContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.Points += pointsToAdd;
                    db.SaveChanges();
                }
            }
        }
    }
}

