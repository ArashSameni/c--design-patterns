namespace DesignPatterns.Creational.Prototype;

public class Square : IComponent
{
    public uint Width { get; set; }
    
    public void Render()
    {
        Console.WriteLine("Rendering square");
    }

    public IComponent Clone()
    {
        return new Square{Width = Width};
    }
}