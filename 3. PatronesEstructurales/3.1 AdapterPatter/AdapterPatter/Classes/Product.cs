using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatter.Classes
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        public Product(string _name, int _price)
        {
            this.name = _name;
            this.price = _price;
        }
    }
}
