using FactoryPatter.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            var pizza = (Pizza)Activator.CreateInstance(Type.GetType($"FactoryPatter.Clases.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
            Pizza pizzaDefualt = new Pizza();
            return pizza != null ? pizza : pizzaDefualt;
        }
    }
}
