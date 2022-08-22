namespace DesignPatterns.Structural.Composite;

public class Composite : IComponent
{
    public string Name { get; set; }
    private readonly ICollection<IComponent> _components;

    public Composite(string name, ICollection<IComponent> components)
    {
        _components = components;
        Name = name;
    }

    public void Add(IComponent component)
    {
        _components.Add(component);
    }

    public void Render()
    {
        Console.WriteLine($"Rendering group {Name}:");
        foreach (var component in _components)
        {
            Console.Write("\t-");
            component.Render();
        }
    }
}