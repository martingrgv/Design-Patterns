namespace Mediator.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        public string Username { get; set; }
        void Recieve(string message);
        void Send(string message, int userId);
        void SetChatRoom(IChatRoom chatRoom);
    }
}
