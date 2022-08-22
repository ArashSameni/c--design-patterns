namespace DesignPatterns.Behavioral.Strategy;

public class Runner : IRunnable
{
    public void Run()
    {
        var image = "myImage.svg";
        
        ImageStorage.Store(image, new JpgCompressor(), new []{new BlackAndWhiteFilter()});
        
        ImageStorage.Store(image, new PngCompressor(), new IImageFilter[]
        {
            new HighContrastFilter(),
            new BlackAndWhiteFilter()
        });
    }
}