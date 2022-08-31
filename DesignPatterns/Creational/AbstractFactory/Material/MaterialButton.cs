using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Material;

public class MaterialButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Material Button");
    }
}