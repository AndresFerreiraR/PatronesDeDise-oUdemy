using SingletonPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Classes
{
    public class SingletonFinder
    {

        private ISingletonContainer singletonContainer;

        public SingletonFinder(ISingletonContainer _singletonContainerData)
        {
            this.singletonContainer = _singletonContainerData;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int totalPopulation = 0;
            foreach (string name in names)
            {
                totalPopulation += singletonContainer.GetPopulation(name);
            }

            return totalPopulation;
        }
    }
}
