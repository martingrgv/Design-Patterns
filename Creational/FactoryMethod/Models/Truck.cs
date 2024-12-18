using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Truck : ITransporter
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck.");
        }
    }
}
