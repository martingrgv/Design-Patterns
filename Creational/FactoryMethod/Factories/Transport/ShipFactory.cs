using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories.Transport
{
    public class ShipFactory : TransportFactory
    {
        public override ITransporter CreateTransport()
        {
            return new Ship();
        }
    }
}
