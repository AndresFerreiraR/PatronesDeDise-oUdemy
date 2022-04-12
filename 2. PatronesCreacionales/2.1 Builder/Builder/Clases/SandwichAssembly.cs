using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases
{
    public class SandwichAssembly
    {
        public SandwichBuilder sandwichBuilder;

        public SandwichAssembly(SandwichBuilder _sandwichBuilder)
        {
            this.sandwichBuilder = _sandwichBuilder;
        }

        public void Assemble()
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddProtein();
            sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich
        {
            get { return sandwichBuilder.sandwich; }
        }
    }
}
