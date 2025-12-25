using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("name=ShoppingContext")
        {
            //  query nhanh hơn tránh lỗi vòng lặp khi serialize JSON
            // this.Configuration.LazyLoadingEnabled = false; 

            Database.SetInitializer<ShoppingContext>(null);
        }

        // Khai báo các bảng dữ liệu (Mapping từ Model C# sang Bảng SQL)
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        // Hàm này dùng để cấu hình thêm nếu cần (Fluent API)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
             modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
