using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public class ProductDAO
    {
        // Lấy tất cả sản phẩm (Kèm tên danh mục)
        public List<Product> GetAll()
        {
            using (var db = new ShoppingContext())
            {
                // .Include("Category") giúp lấy luôn thông tin bảng Category liên kết
                var list = db.Products.Include("Category").ToList();

                // Map tên danh mục vào thuộc tính phụ [NotMapped] để hiển thị lên Grid
                foreach (var p in list)
                {
                    if (p.Category != null)  
                    {
                        p.CategoryName = p.Category.CategoryName;
                    }
                }
                return list;
            }
        }

        // Tìm sản phẩm theo Mã vạch (Cho chức năng POS)
        public Product GetByBarcode(string barcode)
        {
            using (var db = new ShoppingContext())
            {
                return db.Products.FirstOrDefault(p => p.Barcode == barcode);
            }
        }

        // Thêm sản phẩm mới
        public void Add(Product p)
        {
            using (var db = new ShoppingContext())
            {
                db.Products.Add(p);
                db.SaveChanges();
            }
        }

        // Sửa sản phẩm
        public void Update(Product p)
        {
            using (var db = new ShoppingContext())
            {
                var existing = db.Products.Find(p.ProductID);
                if (existing != null)
                {
                    existing.ProductName = p.ProductName;
                    existing.Price = p.Price;
                    existing.StockQuantity = p.StockQuantity;
                    existing.CategoryID = p.CategoryID;
                    existing.ImagePath = p.ImagePath;
                    existing.Barcode = p.Barcode;

                    db.SaveChanges();
                }
            }
        }

        // Xóa sản phẩm
        public void Delete(int id)
        {
            using (var db = new ShoppingContext())
            {
                var p = db.Products.Find(id);
                if (p != null)
                {
                    db.Products.Remove(p);
                    db.SaveChanges();
                }
            }
        }

        // Trừ tồn kho khi bán hàng
        public bool DecreaseStock(int productId, int quantityToSell)
        {
            using (var db = new ShoppingContext())
            {
                var p = db.Products.Find(productId);
                if (p != null && p.StockQuantity >= quantityToSell)
                {
                    p.StockQuantity -= quantityToSell;
                    db.SaveChanges();
                    return true;
                }
                return false; // Không đủ hàng
            }
        }
    }
}
