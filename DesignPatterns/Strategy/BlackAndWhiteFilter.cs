namespace DesignPatterns.Strategy;

// Concrete Strategy
public class BlackAndWhiteFilter : IImageFilter
{
    public void ApplyFilter(string imagePath)
    {
        Console.WriteLine("Applying Black and White filter to the image");
    }
}