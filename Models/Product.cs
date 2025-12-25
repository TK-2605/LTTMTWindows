using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingSystem.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm bắt buộc nhập")]
        [StringLength(200, ErrorMessage = "Tên sản phẩm quá dài")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string Barcode { get; set; } // Mã vạch

        [Required]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }


        [Range(0, 999999999, ErrorMessage = "Giá không được âm")]
        public decimal Price { get; set; }

        [Range(0, 10000, ErrorMessage = "Tồn kho không hợp lệ")]
        public int StockQuantity { get; set; }

        [StringLength(255)]
        public string ImagePath { get; set; } // Chỉ lưu tên file

        // Thuộc tính phụ (Không map vào bảng Products trong DB)
        [NotMapped]
        public string CategoryName { get; set; }
    }
}
