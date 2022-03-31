using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipel.Clases
{
    public class Dog : Animal
    {
        public override void Fly()
        {
            throw new NotImplementedException("No puedo volar");
        }
    }
}
