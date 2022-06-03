using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYNapolitanPizza : Pizza
    {
        public NYNapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "Delgada";
            Sauce = "Tomate";
            Toppings.Add("Queso Motzarella");
        }
    }
}
