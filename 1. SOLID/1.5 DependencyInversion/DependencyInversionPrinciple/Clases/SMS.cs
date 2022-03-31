
namespace DependencyInversionPrinciple.Clases
{
    using DependencyInversionPrinciple.Interafce;
    using System;


    public class SMS : IMassage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine($"Dirigido a: {PhoneNumber}, Body: {Message}");
        }
    }
}
