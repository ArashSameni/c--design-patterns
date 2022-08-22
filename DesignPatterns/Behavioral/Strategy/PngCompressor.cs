namespace DesignPatterns.Behavioral.Strategy;

// Concrete Strategy
public class PngCompressor : IImageCompressor
{
    public void Compress(string imagePath)
    {
        Console.WriteLine($"Compressing {imagePath} using png");
    }
}