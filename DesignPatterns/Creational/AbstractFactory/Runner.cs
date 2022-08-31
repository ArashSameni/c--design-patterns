using DesignPatterns.Creational.AbstractFactory.Ant;
using DesignPatterns.Creational.AbstractFactory.Material;

namespace DesignPatterns.Creational.AbstractFactory;

public class Runner : IRunnable
{
    public void Run()
    {
        var materialForm = new ContactForm(new MaterialWidgetFactory());
        materialForm.Render();
        
        var antForm = new ContactForm(new AntWidgetFactory());
        antForm.Render();
    }
}