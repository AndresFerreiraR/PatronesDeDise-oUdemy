
namespace FactoryPatter.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        public User(string name, string email, string country)
        {
            this.Name = name;
            this.Email = email;
            this.Country = country;
        }
    }
}
