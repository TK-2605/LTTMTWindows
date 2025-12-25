using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.Utils
{
    public static class SecurityHelper
    {
        // Độ dài của Salt 
        private const int SALT_SIZE = 32;

        /// Hàm tạo Hash từ mật khẩu (Dùng khi Đăng Ký hoặc Đổi mật khẩu)
        /// Định dạng trả về: "SALT_BASE64:HASH_BASE64"
        public static string HashPassword(string password)
        {
            try
            {
                // 1. Tạo Salt ngẫu nhiên
                byte[] saltBytes = new byte[SALT_SIZE];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }

                // 2. Tạo Hash (Mật khẩu + Salt)
                byte[] hashBytes = ComputeHash(password, saltBytes);

                // 3. Ghép Salt và Hash thành 1 chuỗi để lưu vào DB
                // Dùng dấu ":" để ngăn cách
                string saltString = Convert.ToBase64String(saltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                return $"{saltString}:{hashString}";
            }
            catch
            {
                return null;
            }
        }

        /// Hàm kiểm tra mật khẩu (Dùng khi Đăng Nhập)

        /// <param name="inputPassword">Mật khẩu người dùng nhập</param>
        /// <param name="storedHash">Chuỗi hash lấy từ Database (gồm Salt:Hash)</param>
        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            try
            {
                // 1. Tách Salt và Hash cũ ra
                string[] parts = storedHash.Split(':');
                if (parts.Length != 2) return false;

                string saltString = parts[0];
                string originalHashString = parts[1];

                byte[] saltBytes = Convert.FromBase64String(saltString);

                // 2. Băm mật khẩu vừa nhập với Salt CŨ
                byte[] newHashBytes = ComputeHash(inputPassword, saltBytes);
                string newHashString = Convert.ToBase64String(newHashBytes);

                // 3. So sánh Hash mới tạo với Hash trong DB
                return newHashString == originalHashString;
            }
            catch
            {
                return false;
            }
        }

        // Hàm phụ trợ dùng chung để băm SHA512
        private static byte[] ComputeHash(string password, byte[] salt)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                // Chuyển password sang byte
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Nối Salt + Password lại với nhau
                byte[] combinedBytes = new byte[salt.Length + passwordBytes.Length];
                Buffer.BlockCopy(salt, 0, combinedBytes, 0, salt.Length);
                Buffer.BlockCopy(passwordBytes, 0, combinedBytes, salt.Length, passwordBytes.Length);

                // Băm
                return sha512.ComputeHash(combinedBytes);
            }
        }
    }
}
