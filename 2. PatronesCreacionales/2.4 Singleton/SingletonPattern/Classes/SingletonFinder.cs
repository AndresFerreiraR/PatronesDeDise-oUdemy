using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Classes
{
    public class SingletonFinder
    {
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int totalPopulation = 0;
            foreach (string name in names)
            {
                totalPopulation += SingletonDataContainer.Instance.GetPopulation(name);
            }

            return totalPopulation;
        }
    }
}
