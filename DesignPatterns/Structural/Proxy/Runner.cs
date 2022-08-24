namespace DesignPatterns.Structural.Proxy;

public class Runner : IRunnable
{
    public void Run()
    {
        var library = new Library();
        var fileNames = new[] { "First Book", "Second Book", "Third Book" };
        foreach (var fileName in fileNames)
            library.Add(new EBookProxy(fileName));
        
        library.Open(fileNames[0]);
        library.Open(fileNames[2]);
    }
}