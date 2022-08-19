namespace DesignPatterns.Strategy;

// Concrete Strategy
public class JpgCompressor : IImageCompressor
{
    public void Compress(string imagePath)
    {
        Console.WriteLine($"Compressing {imagePath} using jpg");
    }
}