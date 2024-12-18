using AbstractFactory.Interfaces;
using AbstractFactory.Models.Linux;

namespace AbstractFactory.Factories.UIFactory
{
    public class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public ITextbox CreateTextBox()
        {
            return new LinuxTextbox();
        }
    }
}
