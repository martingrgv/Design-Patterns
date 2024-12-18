namespace Adapter.ThirdParty
{
    internal class ThirdPartyPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of amount {amount} processed by Third Party.");
        }
    }
}
