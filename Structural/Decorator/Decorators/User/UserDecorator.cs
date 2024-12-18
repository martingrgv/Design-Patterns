using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class UserDecorator : IUser
    {
        protected IUser user;

        public UserDecorator(IUser user)
        {
            this.user = user;
        }

        public virtual string GetUserInfo() => user.GetUserInfo();
    }
}
