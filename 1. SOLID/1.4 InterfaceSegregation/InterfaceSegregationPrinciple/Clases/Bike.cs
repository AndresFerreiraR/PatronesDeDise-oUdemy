namespace InterfaceSegregationPrinciple.Clases
{
    using InterfaceSegregationPrinciple.Interfaces;
    using System;


    public class Bike : IVehicle
    {
        public void GetNumberOfWheel()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
