using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string name);
        public Pizza OrderPizza(string name)
        {
            Pizza pizza = CreatePizza(name);

            //switch (name)
            //{
            //    case "pepperoni":
            //        pizza = new PepperoniPizza();
            //        break;
            //    case "Napolitana":
            //        pizza = new NapolitanPizza();
            //        break;
            //    case "California":
            //        pizza = new CaliforniaPizza();
            //        break;
            //    default:
            //        break;
            //}

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
