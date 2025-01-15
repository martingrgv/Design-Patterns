using Strategy.Enums;

namespace Strategy.Strategies
{
    public interface IPaymentStrategy
    {
        void Pay(decimal price);
    }
}
