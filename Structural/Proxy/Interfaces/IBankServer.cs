namespace Proxy.Interfaces
{
    public interface IBankServer
    {
        void Withdraw(int amount);
        decimal CheckBalance();
    }
}
