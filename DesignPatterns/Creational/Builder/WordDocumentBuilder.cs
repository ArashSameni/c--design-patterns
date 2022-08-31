namespace DesignPatterns.Creational.Builder;

public class WordDocumentBuilder : IPresentationBuilder
{
    public WordDocument Document { get; } = new();
    
    public void AddSlide(Slide slide)
    {
        Document.AddPage(slide.Text);
    }
}