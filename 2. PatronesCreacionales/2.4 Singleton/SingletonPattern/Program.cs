// See https://aka.ms/new-console-template for more information
using SingletonPattern.Classes;

Console.WriteLine("Hello, World!");
/*
 * Crea una instancia de un objeto y la comparte a traves de la aplicacion
 * */

var capitals = new SingletonDataContainer();

Console.WriteLine($"Los habitantes de {capitals.GetPopulation("London")}");
Console.ReadLine();