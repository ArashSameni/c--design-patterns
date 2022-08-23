namespace DesignPatterns.Structural.Flyweight;

public class Runner : IRunnable
{
    public void Run()
    {
        foreach (var point in PointService.GetPoints())
        {
            point.Draw();
        }
    }
}