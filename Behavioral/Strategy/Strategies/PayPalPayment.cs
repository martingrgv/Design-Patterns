using Strategy.Enums;

namespace Strategy.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        private readonly string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal price)
        {
            Console.WriteLine($"Calling {nameof(PayPalPayment)}.");
        }
    }
}
