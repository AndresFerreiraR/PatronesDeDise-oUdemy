using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipel.Clases
{
    public class Animal
    {
        public string Noise;

        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }

        public virtual void Fly()
        {
            Console.WriteLine("Estoy Volando");
        }
    }
}
