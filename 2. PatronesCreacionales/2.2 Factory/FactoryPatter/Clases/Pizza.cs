using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public class Pizza
    {
        public string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings = new List<string>();

        //public void Prepare()
        //{
        //    Console.WriteLine($"Preparando: {Name}");
        //    Console.WriteLine($"Colocando masa: {Dough}");
        //    Console.WriteLine($"Agregando Salsa: {Sauce}");
        //    Console.WriteLine($"Agregando capas: {string.Join(",", Toppings)}");
        //}



        public void Bake() => Console.WriteLine("Cocinar por 20 min");
        public void Cut() => Console.WriteLine("Pizza cortada en partes iguales");
        public void Box() => Console.WriteLine("Pizza colocada en caja oficial");
    }
}
