using Adapter.Contracts;
using Adapter.ThirdParty;

namespace Adapter.Adapters
{
    internal class PaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPayment thirdPartyPayment;

        public PaymentAdapter(ThirdPartyPayment thirdPartyPayment)
        {
            this.thirdPartyPayment = thirdPartyPayment;
        }

        public void ProcessPayment(double amount)
        {
            thirdPartyPayment.MakePayment(amount);
        }
    }
}
