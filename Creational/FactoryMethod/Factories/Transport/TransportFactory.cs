using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories.Transport
{
    public abstract class TransportFactory
    {
        public abstract ITransporter CreateTransport();

        public void PlanDelivery()
        {
            var transport = CreateTransport();
            transport.Deliver();
        }
    }
}
