using Decorator.Interfaces;

namespace Decorator.Models.Users
{
    public class BasicUser : IUser
    {
        public string UserName { get; private set; } = null!;

        public BasicUser(string username)
        {
            UserName = username;
        }

        public string GetUserInfo() => UserName;
    }
}
