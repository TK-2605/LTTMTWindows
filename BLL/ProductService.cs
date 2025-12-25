
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
    public class ProductService
    {
        private ProductDAO productDao = new ProductDAO();
        private CategoryDAO categoryDao = new CategoryDAO();

        // Lấy danh sách sản phẩm
        public List<Product> GetAllProducts()
        {
            return productDao.GetAll();
        }

        // Lấy danh sách danh mục (để đổ vào ComboBox)
        public List<Category> GetAllCategories()
        {
            return categoryDao.GetAll();
        }

        // Tìm kiếm theo Barcode (Cho máy quét)
        public Product FindByBarcode(string barcode)
        {
            if (string.IsNullOrEmpty(barcode)) return null;
            return productDao.GetByBarcode(barcode);
        }

        // THÊM sản phẩm
        public bool AddProduct(Product p)
        {
            if (!ValidateProduct(p)) return false;
            try
            {
                productDao.Add(p);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        // SỬA sản phẩm
        public bool UpdateProduct(Product p)
        {
            if (!ValidateProduct(p)) return false;
            try
            {
                productDao.Update(p);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        // XÓA sản phẩm
        public bool DeleteProduct(int id)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    productDao.Delete(id);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa (Sản phẩm này đã có trong đơn hàng cũ).");
                    return false;
                }
            }
            return false;
        }

        // Hàm kiểm tra logic (Private)
        private bool ValidateProduct(Product p)
        {
            if (string.IsNullOrWhiteSpace(p.ProductName))
            {
                MessageBox.Show("Tên sản phẩm không được trống!"); return false;
            }
            if (p.Price < 0)
            {
                MessageBox.Show("Giá bán không được âm!"); return false;
            }
            if (p.StockQuantity < 0)
            {
                MessageBox.Show("Tồn kho không được âm!"); return false;
            }
            if (p.CategoryID <= 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục!"); return false;
            }
            return true;
        }
    }
}
