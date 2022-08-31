namespace DesignPatterns.Creational.Builder;

public class Runner : IRunnable
{
    public void Run()
    {
        var presentation = new Presentation();
        presentation.AddSlide(new Slide{Text = "Hi"});
        presentation.AddSlide(new Slide{Text = "Love you all :|"});

        var pdfBuilder = new PdfDocumentBuilder();
        presentation.Export(pdfBuilder );
        var pdf = pdfBuilder.Document;
        
        var wordBuilder = new WordDocumentBuilder();
        presentation.Export(wordBuilder);
        var word = wordBuilder.Document;
    }
}