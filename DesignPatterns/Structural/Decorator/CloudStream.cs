namespace DesignPatterns.Structural.Decorator;

public class CloudStream : IStream
{
    public void Write(string data)
    {
        Console.WriteLine($"Storing in the cloud, Data: \"{data}\"");
    }
}