using Proxy.Interfaces;

namespace Proxy.Models
{
    public class BankServer : IBankServer
    {
        private decimal _balance;

        public BankServer(decimal initialBalance)
        {
            _balance = initialBalance;           
        }

        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Bank Server: Insufficient funds!");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Bank Server: Registered withdraw of {amount}");
            }
        }

        public decimal CheckBalance() => _balance;
    }
}
