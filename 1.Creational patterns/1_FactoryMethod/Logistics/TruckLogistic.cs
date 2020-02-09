using System;

namespace FactoryMethod
{
    public class TruckLogistic : Logistic
    {
        public override ITransport CreateTransport()
        {
           return new Truck();
        }
    }
}
