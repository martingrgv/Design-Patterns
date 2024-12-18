using AbstractFactory.Interfaces;
using AbstractFactory.Models.Mac;

namespace AbstractFactory.Factories.UIFactory
{
    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox(); 
        }

        public ITextbox CreateTextBox()
        {
            return new MacTextbox();
        }
    }
}
