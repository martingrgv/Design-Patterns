using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Checking mac textbox.");
        }

        public void Render()
        {
            Console.WriteLine("Render mac textbox.");
        }

        public void Uncheck()
        {
            Console.WriteLine("Unchecking mac textbox.");
        }
    }
}
