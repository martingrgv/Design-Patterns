using Decorator.Interfaces;

namespace Decorator.Decorators.User
{
    public class SendMessageDecorator : UserDecorator
    {
        public SendMessageDecorator(IUser user) : base(user)
        {
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{base.GetUserInfo()}: {message}");
        }
    }
}
