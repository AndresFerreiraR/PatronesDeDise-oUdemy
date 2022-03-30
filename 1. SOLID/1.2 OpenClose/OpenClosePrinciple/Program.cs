// See https://aka.ms/new-console-template for more information
using OpenClosePrinciple.Clases;
using OpenClosePrinciple.Model;

var areaCalculator = new AreaCalculator();
var listObjects = new List<object>()
{
    new Circle { Radius = 10},
    new Rectangle {Width = 40 , Height = 20},
    new Rectangle {Width = 15 , Height = 7},
    new Circle { Radius = 5}
};
var respuesta = areaCalculator.Area(listObjects);

Console.WriteLine(respuesta);