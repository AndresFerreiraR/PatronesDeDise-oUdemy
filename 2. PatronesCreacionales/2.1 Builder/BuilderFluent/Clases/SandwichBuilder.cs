
namespace BuilderFluent.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich sandwich
        {
            get { return _sandwich; }
        }

        public SandwichBuilder WitOreganoBread()
        {
            sandwich.Bread = "pan oregano";
            return this;
        }

        public SandwichBuilder WithTomatoe()
        {
            sandwich.Veggies = "Tomate";
            return this;
        }

        public SandwichBuilder WithOnion()
        {
            sandwich.Veggies = "Cebolla";
            return this;
        }

        public SandwichBuilder WithMeat()
        {
            _sandwich.Protein = "Carne";
            return this;
        }

        public SandwichBuilder WithMayonnaise()
        {
            sandwich.Condiments = "Mayonesa";
            return this;
        }

        public SandwichBuilder WithMotzarella()
        {
            _sandwich.Cheese = "Motzarella";
            return this;
        }
    }
}
