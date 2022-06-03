using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "Delgada";
            Sauce = "Tomate";
            Toppings.Add("Queso Motzarella");
        }
    }
}
