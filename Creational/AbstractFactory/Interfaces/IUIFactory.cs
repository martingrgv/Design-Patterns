namespace AbstractFactory.Interfaces
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
        ITextbox CreateTextBox();
    }
}
