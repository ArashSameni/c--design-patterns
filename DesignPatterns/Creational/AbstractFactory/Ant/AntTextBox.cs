using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Ant;

public class AntTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Ant TextBox");
    }
}