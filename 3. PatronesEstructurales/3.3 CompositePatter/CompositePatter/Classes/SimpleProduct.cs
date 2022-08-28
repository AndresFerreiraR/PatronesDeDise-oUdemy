using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatter.Classes
{
    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, int price) : base(name, price)
        {
        }

        public override void remove(Product product)
        {
            //No se pude realizar porque es el elemento mas abajo de la jerarquia
            throw new NotImplementedException();
        }

        public override void add(Product product)
        {
            //No se pude realizar porque es el elemento mas abajo de la jerarquia
            throw new NotImplementedException();
        }

        public override string getPrice()
        {
            return $"el precio de {Name} es {Price}";
        }
    }
}
