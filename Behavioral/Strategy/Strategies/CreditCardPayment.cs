namespace Strategy.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private readonly string _creditCardNumber;
        private readonly DateTime _expirationDate; 
        private readonly string _cvv;

        public CreditCardPayment(string creditCardNumber, DateTime expirationDate, string cvv)
        {
            _creditCardNumber = creditCardNumber;
            _expirationDate = expirationDate;
            _cvv = cvv;
        }

        public void Pay(decimal price)
        {
            Console.WriteLine($"Calling {nameof(CreditCardPayment)}");
        }
    }
}
