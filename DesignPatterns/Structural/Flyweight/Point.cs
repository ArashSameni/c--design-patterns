namespace DesignPatterns.Structural.Flyweight;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointIcon Icon { get; set; }

    public Point(int x, int y, PointIcon icon)
    {
        X = x;
        Y = y;
        Icon = icon;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Point({X}, {Y}, {Icon.Type}(id: {Icon.Guid}))");
    }
}