// See https://aka.ms/new-console-template for more information
using CompositePatter.Classes;

Console.WriteLine("Hello, World!");


Product ram = new SimpleProduct("RAM 16Gb", 7000);
Product processor = new SimpleProduct("Intel Core i7", 17000);
Product videoCard = new SimpleProduct("nVidia gtx 1050", 85000);
Product keyboard = new SimpleProduct("Teclado Dell", 300);
Product mouse = new SimpleProduct("Mouse Dell", 300);
Product rig = new SimpleProduct("Torre HP", 3000);
Product led = new SimpleProduct("Led LG", 4000);


Product gamingKit = new CompositeProduct("Computador Gamer Basico");
gamingKit.add(ram);
gamingKit.add(processor);
gamingKit.add(videoCard);
gamingKit.add(keyboard);
gamingKit.add(mouse);
gamingKit.add(rig);
gamingKit.add(led);


string precio = gamingKit.getPrice();

Console.WriteLine(precio);
Console.ReadLine();