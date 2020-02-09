using System;

namespace FactoryMethod
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
           Console.WriteLine("Yetkazib berildi!");
        }
    }
}
