namespace DesignPatterns.Structural.Proxy;

public class EBook : IEBook
{
    public string FileName { get; }

    public EBook(string fileName)
    {
        FileName = fileName;
        Load();
    }

    private void Load()
    {
        Console.WriteLine($"Loading {FileName}");
    }

    public void Show()
    {
        Console.WriteLine($"Showing {FileName}");
    }
}