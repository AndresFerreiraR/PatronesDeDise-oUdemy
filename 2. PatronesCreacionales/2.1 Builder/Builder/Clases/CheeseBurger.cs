
namespace Builder.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CheeseBurger : SandwichBuilder
    {

        public CheeseBurger()
        {
            _sandwich = new Sandwich();
        }

        public override void AddBread()
        {
            _sandwich.Bread = "Pan arabe";
        }

        public override void AddCheese()
        {
            _sandwich.Cheese = "Motzarella";
        }

        public override void AddCondiments()
        {
            _sandwich.Condiments = "Mayonesa";
        }

        public override void AddProtein()
        {
            _sandwich.Protein = "Carne Molida";
        }

        public override void AddVeggies()
        {
            _sandwich.Veggies = "Tomate, Lechuga, Cebolla";
        }
    }
}
