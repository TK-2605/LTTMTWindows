using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingSystem.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; } // khóa chính 

        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(100, ErrorMessage = "Email không được quá 100 ký tự")]
        [EmailAddress(ErrorMessage = "Định dạng Email không hợp lệ")]
        public string Email { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8-16 ký tự")]
        public string Password { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Họ tên không được quá 50 ký tự")]
        public string FullName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Số điện thoại không hợp lệ")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Quý khách vui lòng kiểm tra lại số điện thoại.")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; } // "ADMIN", "STAFF", "USER"

        public int Points { get; set; } = 0;

        public bool IsActive { get; set; } = true;

        // Constructor mặc định
        public User() { }
    }
}
