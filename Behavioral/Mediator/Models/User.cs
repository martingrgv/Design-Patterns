using Mediator.Interfaces;

namespace Mediator.Models
{
    public class User(string username)
        : IUser
    {
        private IChatRoom _chatRoom = default!;

        public int Id { get; set; }
        public string Username { get; set; } = username;

        public void Recieve(string message)
        {
            Console.WriteLine($"Recieved message: {message}; at {DateTime.Now}");
        }

        public void Send(string message, int userId)
        {
            _chatRoom.SendMessage(message, userId);
        }

        public void SetChatRoom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }
    }
}
