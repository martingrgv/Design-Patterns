using AbstractFactory.Interfaces;
using AbstractFactory.Models.Windows;

namespace AbstractFactory.Factories.UIFactory
{
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }

        public ITextbox CreateTextBox()
        {
            return new WindowsTextbox();
        }
    }
}
