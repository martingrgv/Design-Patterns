using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    public class LinuxTextbox : ITextbox
    {
        public void Clear()
        {
            Console.WriteLine("Clearing linux textbox.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering linux textbox.");
        }

        public void Write(string text)
        {
            Console.WriteLine("Writing in linux textbox. Text: " + text);
        }
    }
}
