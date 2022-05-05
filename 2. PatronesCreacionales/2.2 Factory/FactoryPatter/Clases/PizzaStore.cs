using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "Napolitana":
                    pizza = new NapolitanPizza();
                    break;
                case "California":
                    pizza = new CaliforniaPizza();
                    break;
                default:
                    break;
            }

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
