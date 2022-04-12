// See https://aka.ms/new-console-template for more information
using Builder.Clases;

Console.WriteLine("Hello, World!");


var sandwich = new SandwichAssembly(new CheeseBurger());
sandwich.Assemble();
Console.WriteLine($"{ sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Cheese} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies} {sandwich.GetSandwich.Condiments}");
Console.ReadLine();