using Mediator.Interfaces;

namespace Mediator.Models
{
    public class ChatRoom : IChatRoom
    {
        private readonly Dictionary<int, IUser> _users = new();

        public void RegisterUser(IUser user)
        {
            if (!_users.ContainsKey(user.Id))
            {
                _users[user.Id] = user;
                user.SetChatRoom(this);
            }
        }

        public void SendMessage(string message, int userId)
        {
            if (_users.ContainsKey(userId))
            {
                _users[userId].Recieve(message);
            }
        }
    }
}
