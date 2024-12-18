using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Application : IApplication
    {
        private readonly IButton button;
        private readonly ICheckbox checkbox;
        private readonly ITextbox textbox;

        public Application(IUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
            textbox = factory.CreateTextBox();
        }

        public void Render()
        {
            button.Render();
            checkbox.Render();
            textbox.Render();
        }
    }
}
