using Strategy.Strategies;

namespace Strategy.Context
{
    public class PaymentContext
    {
        private IPaymentStrategy _strategy = default!;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            if (_strategy is null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }

            _strategy.Pay(amount);
        }
    }
}
