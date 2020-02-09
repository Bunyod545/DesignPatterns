using System;

namespace FactoryMethod
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
           Console.WriteLine("Yetkazib berildi!");
        }
    }
}
