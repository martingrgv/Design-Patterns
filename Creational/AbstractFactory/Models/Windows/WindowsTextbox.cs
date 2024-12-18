using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Windows
{
    public class WindowsTextbox : ITextbox
    {
        public void Clear()
        {
            Console.WriteLine("Clearing windows checkbox.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering windows checkbox.");
        }

        public void Write(string text)
        {
            Console.WriteLine("Writing in windows checkbox. Text: " + text);
        }
    }
}
