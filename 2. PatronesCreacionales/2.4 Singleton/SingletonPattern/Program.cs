// See https://aka.ms/new-console-template for more information
using SingletonPattern.Classes;

Console.WriteLine("Hello, World!");
/*
 * Crea una instancia de un objeto y la comparte a traves de la aplicacion
 * */
// Genera error
// var capitals = new SingletonDataContainer();
var capitals = SingletonDataContainer.Instance;
var capitals2 = SingletonDataContainer.Instance;
var capitals3 = SingletonDataContainer.Instance;
var capitals4 = SingletonDataContainer.Instance;
Console.WriteLine($"Los habitantes de {capitals.GetPopulation("London")}");
Console.WriteLine($"Los habitantes de {capitals2.GetPopulation("New Delhi")}");
Console.WriteLine($"Los habitantes de {capitals3.GetPopulation("Beijing")}");
Console.WriteLine($"Los habitantes de {capitals4.GetPopulation("Washington, D.C")}");
Console.ReadLine();