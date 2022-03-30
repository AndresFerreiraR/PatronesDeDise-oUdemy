
namespace OpenClosePrinciple.Clases
{
    using OpenClosePrinciple.Model;
    using System;
    using System.Collections.Generic;

    public class AreaCalculator
    {
        public string Area (List<object> shapes)
        {
            string area = string.Empty;

            foreach (var shape in shapes)
            {
                if(shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += "Reactangulo: " + rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += "Circulo: " + circle.Radius * circle.Radius * Math.PI;
                }

                area += Environment.NewLine;
            }

            return area;
        }
    }
}
