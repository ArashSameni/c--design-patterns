namespace DesignPatterns.Creational.Prototype;

public class Circle : IComponent
{
    public uint Radius { get; set; }

    public void Render()
    {
        Console.WriteLine("Rendering Circle");
    }

    public IComponent Clone()
    {
        return new Circle{Radius = Radius};
    }
}