using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Mac
{
    public class MacTextbox : ITextbox
    {
        public void Clear()
        {
            Console.WriteLine("Clearing mac textbox.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering mac textbox.");
        }

        public void Write(string text)
        {
            Console.WriteLine("Writing in mac textbox. Text: " + text);
        }
    }
}
