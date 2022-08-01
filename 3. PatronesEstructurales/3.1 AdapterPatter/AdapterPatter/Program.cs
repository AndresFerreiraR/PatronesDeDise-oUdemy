// See https://aka.ms/new-console-template for more information
using AdapterPatter.Classes;

Console.WriteLine("Hello, World!");


//Console.WriteLine(new JsonConverter().GetJson());
//Console.ReadLine();

//Console.WriteLine(new XmlConverter().GetXml());
//Console.ReadLine();


var xmlConverter = new XmlConverter();
var adapter = new XmlToJsonAdapter(xmlConverter);
adapter.ConvertXmlToJson();
Console.WriteLine(adapter);
Console.ReadLine();