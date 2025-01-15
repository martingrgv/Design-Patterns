using Proxy.Models;

namespace Proxy.Proxies
{
    public class ATMProxy
    {
        private readonly BankServer _server;
        private bool _isAuthenticated;

        public ATMProxy(BankServer bankServer)
        {
            _server = bankServer;
            _isAuthenticated = false;
        }

        public void Authenticate(string pin)
        {
            Console.WriteLine("ATM: Authenticating user...");

            if (pin == "0000")
            {
                Console.WriteLine("ATM: Successful authentication!");
                _isAuthenticated = true;
            }
            else
            {
                Console.WriteLine("ATM: Unsuccessful authentication!");
            }
        }

        public void Withdraw(int amount)
        {
            if (!_isAuthenticated)
            {
                Console.WriteLine("ATM: Please authenticate before proceeding!");
                return;
            }

            Console.WriteLine("ATM: Processing withdraw...");
            _server.Withdraw(amount);
        }

        public void CheckBalance()
        {
            if (!_isAuthenticated)
            {
                Console.WriteLine("ATM: Please authenticate before proceeding!");
                return;
            }

            Console.WriteLine($"ATM: Account balance: {_server.CheckBalance()}");
        }
    }
}
