// Creates objects without specifying the exact class.

using FactoryMethod.Factories.Transport;

TransportFactory factory;

factory = new TruckFactory();
factory.PlanDelivery();
