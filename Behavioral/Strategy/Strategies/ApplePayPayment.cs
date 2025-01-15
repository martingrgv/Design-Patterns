using Strategy.Enums;

namespace Strategy.Strategies
{
    public class ApplePayPayment : IPaymentStrategy
    {
        private readonly string _appleAccount;

        public ApplePayPayment(string icloudAccount)
        {
            _appleAccount = icloudAccount;
        }

        public void Pay(decimal price)
        {
            Console.WriteLine($"Calling {nameof(ApplePayPayment)}.");
        }
    }
}
