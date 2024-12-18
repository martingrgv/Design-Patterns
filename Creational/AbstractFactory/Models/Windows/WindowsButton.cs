using AbstractFactory.Interfaces;
using System.Net.Http.Headers;

namespace AbstractFactory.Models.Windows
{
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Clicking windows button.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering windows button.");
        }
    }
}
