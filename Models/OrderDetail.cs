
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.Models
{
    [Table("OrderDetails")] 
    public class OrderDetail
    {
        [Key] 
        public int DetailID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        // Liên kết ngược về bảng Order (Để biết chi tiết này nằm trong hóa đơn nào)
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        // Liên kết sang bảng Product (Để lấy thông tin tên SP, hình ảnh...)
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [NotMapped]
        public string ProductName { get; set; }

        [NotMapped]
        public decimal TotalPrice
        {
            get { return Quantity * UnitPrice; }
        }
    }
}

