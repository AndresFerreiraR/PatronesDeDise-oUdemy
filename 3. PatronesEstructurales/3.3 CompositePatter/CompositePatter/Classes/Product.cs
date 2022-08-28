using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatter.Classes
{
    public abstract class Product
    {

        public string Name { get; private set; }
        public int Price { get; private set; }


        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract void add(Product product);
        public abstract void remove(Product product);
        public abstract string getPrice();
    }
}
