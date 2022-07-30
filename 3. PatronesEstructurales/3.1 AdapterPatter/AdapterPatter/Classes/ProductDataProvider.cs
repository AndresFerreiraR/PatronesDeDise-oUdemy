using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatter.Classes
{
    public static class ProductDataProvider
    {
        public static List<Product> GetData() =>
            new List<Product>
            {
                new Product("Iphone", 5000),
                new Product("xiaomi MI 2", 100),
                new Product("Samsung s9", 4000),
            };
    }
}
