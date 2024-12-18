using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    public class LinuxButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Clicking linux button.");
        }

        public void Render()
        {
            Console.WriteLine("Rendering linux button.");
        }
    }
}
