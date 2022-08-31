using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory;

public class ContactForm
{
    public IWidgetFactory WidgetFactory { get; set; }
    
    public ContactForm(IWidgetFactory widgetFactory)
    {
        WidgetFactory = widgetFactory;
    }
    
    public void Render()
    {
        WidgetFactory.CreateTextBox().Render();
        WidgetFactory.CreateButton().Render();
    }
}