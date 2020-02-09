using System;

namespace FactoryMethod
{
    public abstract class Logistic
    {
        public void PlanDeliver()
        {
            Console.WriteLine("Maxsulotlarni tayyorlash");
            Console.WriteLine("Maxsulotlarni o`rab yetkazishga tayorlash");
            
            var transport = CreateTransport();
            transport.Deliver();
        }

        public abstract ITransport CreateTransport();
    }
}
