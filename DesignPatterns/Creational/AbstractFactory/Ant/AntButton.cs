using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Ant;

public class AntButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Ant Button");
    }
}