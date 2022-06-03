using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYCaliforniaPizza : Pizza
    {
        public NYCaliforniaPizza()
        {
            Name = "California";
            Dough = "Delgada";
            Sauce = "Tomate";
            Toppings.Add("Queso Motzarella");
        }
    }
}
