namespace DesignPatterns.Creational.Prototype;

public class ContextMenu
{
    public void Duplicate(IComponent component)
    {
        var newComponent = component.Clone();
        Console.WriteLine("New component added");
        newComponent.Render();
    }
}