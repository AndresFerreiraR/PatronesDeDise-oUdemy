using SingletonPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Classes
{
    public class SingletonDataContainer : ISingletonContainer
    {

        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        public SingletonDataContainer()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Capitals.txt");
            var elements = File.ReadAllLines(path);
            for(int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
