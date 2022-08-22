namespace DesignPatterns.Behavioral.Strategy;

// Context
public static class ImageStorage
{
    public static void Store(string fileName, IImageCompressor compressor, IEnumerable<IImageFilter> filters)
    {
        compressor.Compress(fileName);
        foreach (var filter in filters)
        {
            filter.ApplyFilter(fileName);
        }

        Console.WriteLine("Storing the image...");
    }
}