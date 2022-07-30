using SingletonPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton.MockTest
{
    public class DummyDataBase : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>()
            {
                ["Santiago"] = 7000,
                ["Buenos Aires"] = 222
            }[name];
        }
    }
}
