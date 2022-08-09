// See https://aka.ms/new-console-template for more information
using BridgePatter.Classes;

Console.WriteLine("Hello, World!");


ReaderApp windows7 = new Windows7(new NormalDisplay()) { Text = "Aprendiendo Bried 7" };
windows7.Display();
ReaderApp windows10 = new Windows10(new NormalDisplay()) { Text = "Aprendiendo Bried 10" };
windows10.Display();


ReaderApp windows7r = new Windows7(new ReverseDisplay()) { Text = "Aprendiendo Bried 7" };
windows7.Display();
ReaderApp windows10r = new Windows10(new ReverseDisplay()) { Text = "Aprendiendo Bried 10" };
windows10.Display();

Console.ReadLine();
