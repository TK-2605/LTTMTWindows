using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.DAL
{
    public static class DBConnection
    {
        public static ShoppingContext GetContext()
        {
            return new ShoppingContext();
        }
    }
}
