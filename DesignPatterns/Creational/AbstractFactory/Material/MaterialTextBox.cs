using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Material;

public class MaterialTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Material TextBox");
    }
}