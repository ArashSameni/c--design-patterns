namespace DesignPatterns.Creational.Builder;

public class PdfDocument
{
    public void AddPage(string text, string img)
    {
        Console.WriteLine($"Adding `{text}` to pdf");
    }
}