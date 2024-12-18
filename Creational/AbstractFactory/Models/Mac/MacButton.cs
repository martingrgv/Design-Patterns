using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Mac
{
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Clicking mac button.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering mac button.");
        }
    }
}
