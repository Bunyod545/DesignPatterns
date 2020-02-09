using System;

namespace FactoryMethod
{
    public class ShipLogistic : Logistic
    {
        public override ITransport CreateTransport()
        {
           return new Ship();
        }
    }
}
