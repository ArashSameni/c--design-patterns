namespace DesignPatterns.State;

// Concrete State
public class Eraser : ITool
{
    // Handle
    public void MouseDown()
    {
        Console.WriteLine("Erasing something from canvas...");
    }
}