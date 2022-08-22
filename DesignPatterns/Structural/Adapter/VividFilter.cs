namespace DesignPatterns.Structural.Adapter;

public class VividFilter : IFilter
{
    public void Apply(string image)
    {
        Console.WriteLine($"Applying vivid filter to {image}");
    }
}