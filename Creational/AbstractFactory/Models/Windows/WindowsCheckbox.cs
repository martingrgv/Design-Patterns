using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Checking windows checkbox.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering windows checkbox.");
        }

        public void Uncheck()
        {
            Console.WriteLine("Unchecking windows checkbox.");
        }
    }
}
