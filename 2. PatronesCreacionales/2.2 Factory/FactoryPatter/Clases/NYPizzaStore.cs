using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "Pepperoni":
                    return new NYPepperoniPizza();
                    break;
                case "Napolitana":
                    return new NYNapolitanPizza();
                    break;
                case "California":
                    return new NYCaliforniaPizza();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
