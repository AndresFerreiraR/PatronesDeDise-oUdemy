
namespace DependencyInversionPrinciple.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Email
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendEmail()
        {
            Console.WriteLine($"Dirigido a: {Subject}, Body: {Content}");
        }
    }
}
