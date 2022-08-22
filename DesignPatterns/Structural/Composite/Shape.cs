namespace DesignPatterns.Structural.Composite;

public class Shape : IComponent
{
    public string Name { get; set; }
    
    public Shape(string name)
    {
        Name = name;
    }
    
    public void Render()
    {
        Console.WriteLine($"{Name} is being rendered...");
    }
}