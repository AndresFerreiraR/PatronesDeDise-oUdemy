
namespace Builder.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class SandwichBuilder
    {

        protected Sandwich _sandwich; 

        public Sandwich sandwich
        {
            get { return _sandwich; }
        }

        public abstract void AddBread();
        public abstract void AddVeggies();
        public abstract void AddProtein();
        public abstract void AddCondiments();
        public abstract void AddCheese();
    }
}
