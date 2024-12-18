using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Plane : ITransporter
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by plane.");
        }
    }
}
