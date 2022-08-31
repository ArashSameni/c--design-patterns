namespace DesignPatterns.Creational.Builder;

public class PdfDocumentBuilder : IPresentationBuilder
{
    public PdfDocument Document { get; } = new();
    
    public void AddSlide(Slide slide)
    {
        Document.AddPage(slide.Text, "some image");
    }
}