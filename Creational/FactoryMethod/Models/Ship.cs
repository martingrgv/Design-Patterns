using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Ship : ITransporter
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship.");
        }
    }
}
