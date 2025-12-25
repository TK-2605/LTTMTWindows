using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.Utils
{
    public static class SessionManager
    {
        // Biến toàn cục: Lưu User đang đăng nhập
        public static User CurrentUser { get; set; } = null;

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
