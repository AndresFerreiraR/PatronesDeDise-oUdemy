using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipel.Interfaces
{
    public interface IAnimal
    {
        string Noise { get; set; }
        void MakeNoise();
    }
}
