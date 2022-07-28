// See https://aka.ms/new-console-template for more information
using FactoryPatter.Clases;
using FactoryPatter.Enumeradores;

Console.WriteLine("Hello, World!");


//// Se debe asignar por defecto un pais

//var user = new User.CreateWithDefaultCountry("Rodrigo", "rodrigo@yahoo.es", "Chile");
//Console.WriteLine($"Usuario: {user.Name} Email {user.Email}, Pais: {user.Country}");

//var user = UserFactory.CreateWithDefaultCountry("Rodrigo", "rodrigo@yahoo.es");
//Console.WriteLine($"Usuario: {user.Name} Email {user.Email}, Pais: {user.Country}");
//Console.ReadLine();

PizzaStore nYStore = new NYPizzaStore();
Pizza pizza = nYStore.OrderPizza(TypeOfPizza.Pepperoni);
Console.WriteLine($"Pizza {pizza.Name} lista para entretgar al usuario a Andres");
Console.ReadLine();