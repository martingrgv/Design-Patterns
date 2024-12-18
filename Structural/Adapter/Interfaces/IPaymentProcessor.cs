namespace Adapter.Contracts
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
