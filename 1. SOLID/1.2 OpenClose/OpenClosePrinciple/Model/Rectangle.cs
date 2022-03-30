
using OpenClosePrinciple.Interfaces;

namespace OpenClosePrinciple.Model
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public string Area()
        {
            return "Reactangulo: " + Width * Height;
        }
    }
}
