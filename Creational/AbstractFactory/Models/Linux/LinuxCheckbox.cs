using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    public class LinuxCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Checking linux textbox.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering linux textbox.");
        }

        public void Uncheck()
        {
            Console.WriteLine("Unchecking linux textbox.");
        }
    }
}
