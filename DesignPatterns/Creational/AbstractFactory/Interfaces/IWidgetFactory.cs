namespace DesignPatterns.Creational.AbstractFactory.Interfaces;

public interface IWidgetFactory
{
    public IButton CreateButton();
    public ITextBox CreateTextBox();
}