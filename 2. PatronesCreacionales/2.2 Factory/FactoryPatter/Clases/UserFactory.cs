using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatter.Clases
{
    public static class UserFactory
    {
        public static User CreateWithDefaultCountry(string name, string email)
        {
            return new User(name, email, "Chile");
        }
    }
}
