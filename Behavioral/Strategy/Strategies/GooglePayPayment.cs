using Strategy.Enums;

namespace Strategy.Strategies
{
    public class GooglePayPayment : IPaymentStrategy
    {
        private readonly string _phoneNumber;

        public GooglePayPayment(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void Pay(decimal price)
        {
            Console.WriteLine($"Calling {nameof(GooglePayPayment)}.");
        }
    }
}
