using Adapter.Contracts;

namespace Adapter.Services
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;            
        }

        public void Pay(double amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }
}
