using Decorator.Interfaces;

namespace Decorator.Decorators.User
{
    public class BanUserDecorator : UserDecorator
    {
        public BanUserDecorator(IUser user) : base(user) { }

        public void BanUser()
        {
            Console.WriteLine("Banned successfully!");
        }

        public override string GetUserInfo() => $"{base.GetUserInfo()} is banned!";
    }
}
