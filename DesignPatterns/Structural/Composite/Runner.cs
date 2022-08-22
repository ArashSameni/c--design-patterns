namespace DesignPatterns.Structural.Composite;

public class Runner : IRunnable
{
    public void Run()
    {
        var circle = new Shape("Circle");
        var square = new Shape("Square");

        var group = new Composite("Group1", new List<IComponent>());
        group.Add(circle);
        group.Add(square);
        
        group.Render();
    }
}