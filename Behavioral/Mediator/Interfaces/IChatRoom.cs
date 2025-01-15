namespace Mediator.Interfaces
{
    public interface IChatRoom
    {
        void RegisterUser(IUser user);
        void SendMessage(string message, int userId);
    }
}
