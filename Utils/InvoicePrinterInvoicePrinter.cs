using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem.Utils
{
    //VẼ hóa đơn cửa hàng
    public static class InvoicePrinter
    {
        public static void PrintInvoice(PrintPageEventArgs e, Order order, DataGridView dgvCart)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fHead = new Font("Arial", 11, FontStyle.Bold);
            Font fBody = new Font("Arial", 11, FontStyle.Regular);
            Brush brush = Brushes.Black;

            int x = 20, y = 20;

            // --- SỬA TÊN CỬA HÀNG TẠI ĐÂY ---
            g.DrawString("UNIVA Mart", fTitle, brush, x, y);
            y += 30;

            // Các phần khác giữ nguyên
            g.DrawString($"Mã HĐ: {order.OrderID} - Ngày: {order.OrderDate:dd/MM/yyyy HH:mm}", fBody, brush, x, y); y += 20;
            string khach = SessionManager.CurrentUser?.FullName ?? "Khách lẻ";
            g.DrawString($"Khách hàng: {khach}", fBody, brush, x, y); y += 20;
            g.DrawString("----------------------------------------------------------", fBody, brush, x, y); y += 20;

            // Table Header
            g.DrawString("Tên SP", fHead, brush, x, y);
            g.DrawString("SL", fHead, brush, x + 250, y);
            g.DrawString("Đơn giá", fHead, brush, x + 300, y);
            g.DrawString("Thành tiền", fHead, brush, x + 450, y);
            y += 25;

            // Table Body
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["ProductName"].Value != null)
                {
                    string name = row.Cells["ProductName"].Value.ToString();
                    if (name.Length > 25) name = name.Substring(0, 22) + "...";

                    string qty = row.Cells["Quantity"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                    g.DrawString(name, fBody, brush, x, y);
                    g.DrawString(qty, fBody, brush, x + 255, y);
                    g.DrawString(price.ToString("#,##0"), fBody, brush, x + 300, y);
                    g.DrawString(total.ToString("#,##0"), fBody, brush, x + 450, y);
                    y += 25;
                }
            }

            // Footer
            y += 20;
            g.DrawString("----------------------------------------------------------", fBody, brush, x, y); y += 20;
            g.DrawString("TỔNG CỘNG:", fHead, brush, x + 300, y);
            g.DrawString(order.TotalAmount.ToString("#,##0") + " VNĐ", fTitle, brush, x + 400, y - 5);
            y += 50;
            g.DrawString("Cảm ơn quý khách!", new Font("Arial", 10, FontStyle.Italic), brush, x + 200, y);
        }
    }
}
