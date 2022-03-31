
namespace DependencyInversionPrinciple.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendSMS()
        {
            Console.WriteLine($"Dirigido a: {PhoneNumber}, Body: {Message}");
        }
    }
}
