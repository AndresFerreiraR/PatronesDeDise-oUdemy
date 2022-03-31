
namespace LiskovSubstitutionPrincipel.Clases
{
    using LiskovSubstitutionPrincipel.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Puedo Volar");
        }
    }
}
