using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new ShipLogistic();
            Client(ship);

            var truck = new TruckLogistic();
            Client(truck);
        }

        static void Client(Logistic logistic)
        {
            logistic.PlanDeliver();
        }
    }
}
