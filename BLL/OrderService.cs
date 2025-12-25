
using ShoppingSystem.DAL;
using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem.BLL
{
    public class OrderService
    {
        private OrderDAO orderDAO = new OrderDAO();
        private ProductDAO productDAO = new ProductDAO();

        // Tạo Đơn Hàng mới
        public int CreateOrder(Order order, List<OrderDetail> details)
        {
            // 1. Check giỏ hàng trống
            if (details == null || details.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return 0;
            }

            // 2. Check tồn kho
            foreach (var item in details)
            {
                Product productInDB = productDAO.GetByBarcode(item.Product.Barcode);
                if (productInDB != null)
                {
                    if (productInDB.StockQuantity < item.Quantity)
                    {
                        MessageBox.Show($"Sản phẩm '{item.ProductName}' không đủ hàng!\nTồn kho: {productInDB.StockQuantity}");
                        return 0;
                    }
                }
            }

            // 3. Gọi DAL tạo đơn
            int newOrderID = orderDAO.CreateOrder(order, details);

            if (newOrderID > 0)
            {
                // 4. Trừ tồn kho
                foreach (var item in details)
                {
                    productDAO.DecreaseStock(item.ProductID, item.Quantity);
                }

                // 5. Cộng điểm (100k = 1 điểm)
                if (order.UserID > 0)
                {
                    int points = (int)(order.TotalAmount / 100000);
                    new UserDAO().UpdatePoint(order.UserID, points);
                }

                return newOrderID;
            }

            return 0;
        }

        // Lấy lịch sử đơn hàng
        public List<Order> GetHistory(int userId)
        {
            return orderDAO.GetHistoryByUser(userId);
        }
    }
}
