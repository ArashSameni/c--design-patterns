namespace DesignPatterns.Structural.Adapter.ExternalLibrary;

public class SpecialFilter
{
    private string _image;
    
    public void Initial(string image)
    {
        _image = image;
    }

    public void Apply()
    {
        Console.WriteLine($"Applying special filter to {_image}");
    }
}