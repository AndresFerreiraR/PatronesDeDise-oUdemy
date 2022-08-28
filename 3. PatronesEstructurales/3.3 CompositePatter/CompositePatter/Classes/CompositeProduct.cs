using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatter.Classes
{
    public class CompositeProduct : Product
    {
        List<Product> products = new List<Product>();

        public CompositeProduct(string name) : base(name, 0)
        {

        }

        public override void add(Product product)
        {
            products.Add(product);
        }

        public override string getPrice()
        {
            return $"el precio de {Name} es {products.Sum(x => x.Price).ToString("N2")}";
        }

        public override void remove(Product product)
        {
            products.Remove(product);
        }
    }
}
