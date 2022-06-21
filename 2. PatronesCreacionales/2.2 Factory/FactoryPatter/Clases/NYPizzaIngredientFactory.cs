using FactoryPatter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MotzarellaCheese();
        }

        public IDough CreateDough()
        {
            throw new NotImplementedException();
        }

        public ISauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public List<IVeggie> Veggies()
        {
            throw new NotImplementedException();
        }
    }
}
