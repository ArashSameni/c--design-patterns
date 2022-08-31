namespace DesignPatterns.Creational.Builder;

public class WordDocument
{
    public void AddPage(string text)
    {
        Console.WriteLine($"Adding `{text}` to word");
    }
}