namespace AbstractFactory.Interfaces
{
    public interface ITextbox : IRender
    {
        void Clear();
        void Write(string text);
    }
}
