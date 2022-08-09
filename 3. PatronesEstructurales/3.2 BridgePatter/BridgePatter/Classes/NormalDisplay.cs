using BridgePatter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatter.Classes
{
    public class NormalDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
