using Decorator.Interfaces;

namespace Decorator.Decorators.User
{
    public class GrantAdminRightsDecorator : UserDecorator
    {
        public GrantAdminRightsDecorator(IUser user) : base(user)
        {
        }

        public void MakeAdmin()
        {
            Console.WriteLine($"{base.GetUserInfo()} is an admin!");
        }

        public override string GetUserInfo() => $"Administrator {base.GetUserInfo()}";
    }
}
