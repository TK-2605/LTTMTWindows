
using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public class OrderDAO
    {
        // Tạo đơn hàng mới (Kèm danh sách chi tiết)
        // Hàm này nhận vào object Order, bên trong object Order đã chứa List<OrderDetail>
        public int CreateOrder(Order newOrder, List<OrderDetail> details)
        {
            using (var db = new ShoppingContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Lưu Order (Header) trước
                        db.Orders.Add(newOrder);
                        db.SaveChanges(); // Lúc này newOrder.OrderID sẽ được sinh ra tự động

                        // 2. Gán OrderID vừa sinh ra cho các dòng chi tiết
                        foreach (var item in details)
                        {
                            item.OrderID = newOrder.OrderID;
                            db.OrderDetails.Add(item);
                        }

                        db.SaveChanges(); // Lưu tiếp chi tiết
                        transaction.Commit(); // Xác nhận giao dịch thành công

                        return newOrder.OrderID; // Trả về mã đơn hàng
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); // Nếu lỗi thì hủy hết, không lưu dở dang
                        return 0;
                    }
                }
            }
        }

        // Lấy lịch sử mua hàng của 1 User
        public List<Order> GetHistoryByUser(int userId)
        {
            using (var db = new ShoppingContext())
            {
                return db.Orders
                         .Where(o => o.UserID == userId)
                         .OrderByDescending(o => o.OrderDate) // Mới nhất lên đầu
                         .ToList();
            }
        }

        // Lấy chi tiết của 1 đơn hàng cụ thể (Khi User bấm vào xem chi tiết)
        public List<OrderDetail> GetDetailsByOrderID(int orderId)
        {
            using (var db = new ShoppingContext())
            {
                var list = db.OrderDetails
                             .Include("Product") // Join bảng Product để lấy tên SP
                             .Where(d => d.OrderID == orderId)
                             .ToList();

                // Map tên SP để hiển thị
                foreach (var d in list)
                {
                    /* Vì trong model OrderDetail ta có ProductID, 
                       EF tự tạo navigation property 'Product' (nếu bạn chưa khai báo trong model 
                       thì EF vẫn join được nhưng cần cấu hình).
                       Ở đây tôi giả định bạn dùng LINQ join thủ công hoặc map tên như sau: */

                    // Cách đơn giản nhất nếu Model chưa có Relation chuẩn:
                    var prod = db.Products.Find(d.ProductID);
                    if (prod != null) d.ProductName = prod.ProductName;
                }

                return list;
            }
        }
    }
}
