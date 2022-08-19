namespace DesignPatterns.Strategy;

// Concrete Strategy
public class HighContrastFilter : IImageFilter
{
    public void ApplyFilter(string imagePath)
    {
        Console.WriteLine("Applying High Contrast filter to the image");
    }
}