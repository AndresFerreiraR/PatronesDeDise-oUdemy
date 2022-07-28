// See https://aka.ms/new-console-template for more information
using PrototypePatter.Class;

Console.WriteLine("Hello, World!");


/*
 * Primer consumo usando ICloneable
 * 
 * 
 * 
 */
//var noteBook1 = new Product("Macbook", new Category("Computers"));
//var iphone = (Product)noteBook1.Clone();
//iphone.Name = "Iphone";
//iphone.Category.Name = "MobilePhone";
//Console.WriteLine(noteBook1);
//Console.WriteLine(iphone);

var noteBook1 = new Product("Macbook", new Category("Computers"));
var cellPhone = (Product)noteBook1.DeepCopy();
cellPhone.Name = "Iphone";
cellPhone.Category.Name = "MobilePhone";
Console.WriteLine(noteBook1);
Console.WriteLine(cellPhone);