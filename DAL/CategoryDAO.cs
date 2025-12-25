
using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public class CategoryDAO
    {
        // Lấy tất cả danh mục
        public List<Category> GetAll()
        {
            using (var db = new ShoppingContext())
            {
                return db.Categories.ToList();
            }
        }
    }
}
