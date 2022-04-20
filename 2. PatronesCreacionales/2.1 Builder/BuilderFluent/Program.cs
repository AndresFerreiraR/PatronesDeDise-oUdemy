// See https://aka.ms/new-console-template for more information
using BuilderFluent.Clases;

Console.WriteLine("Hello, World!");

var builder = new SandwichBuilder().WithMotzarella()
                                   .WithTomatoe()
                                   .WithOnion()
                                   .WitOreganoBread()
                                   .WithMeat()
                                   .WithMayonnaise();

Console.WriteLine(builder.ToString());
Console.ReadLine();