
namespace DependencyInversionPrinciple.Clases
{
    using DependencyInversionPrinciple.Interafce;
    using System;

    public class Email : IMassage
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine($"Dirigido a: {Subject}, Body: {Content}");
        }
    }
}
