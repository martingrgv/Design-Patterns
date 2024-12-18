using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories.Transport
{
    public class PlaneFactory : TransportFactory
    {
        public override ITransporter CreateTransport()
        {
            return new Plane();
        }
    }
}
