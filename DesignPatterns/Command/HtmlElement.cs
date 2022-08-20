namespace DesignPatterns.Command;

// Receiver
public class HtmlElement
{
    public string Content { get; set; }

    public HtmlElement(string content)
    {
        Content = content;
    }

    public void MakeBold()
    {
        Content = "<b>" + Content + "</b>";
    }

    public void MakeItalic()
    {
        Content = "<i>" + Content + "</i>";
    }
}