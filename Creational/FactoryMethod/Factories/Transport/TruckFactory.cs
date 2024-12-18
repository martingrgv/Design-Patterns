using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories.Transport
{
    public class TruckFactory : TransportFactory
    {
        public override ITransporter CreateTransport()
        {
            return new Truck();
        }
    }
}
