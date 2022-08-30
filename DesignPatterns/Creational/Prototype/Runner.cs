namespace DesignPatterns.Creational.Prototype;

public class Runner : IRunnable
{
    public void Run()
    {
        var contextMenu = new ContextMenu();
        var circle = new Circle { Radius = 5 };
        var square = new Square { Width = 10 };
        contextMenu.Duplicate(circle);
        contextMenu.Duplicate(square);
    }
}