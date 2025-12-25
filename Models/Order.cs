using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public int UserID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDate = DateTime.Now;
            Status = "Pending";
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
