
namespace DependencyInversionPrinciple.Clases
{
    using DependencyInversionPrinciple.Interafce;
    using System.Collections.Generic;

    public class Employee
    {
        private List<IMassage> _massages;

        public Employee(List<IMassage> massages)
        {
            this._massages = massages;
        }

        public void Send()
        {
            _massages.ForEach(massage =>
            {
                massage.SendMessage();
            });
        }
    }
}
