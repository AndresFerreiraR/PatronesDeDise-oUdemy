using LiskovSubstitutionPrincipel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipel.Clases
{
    public class Animal : IAnimal
    {
        public string Noise { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}
