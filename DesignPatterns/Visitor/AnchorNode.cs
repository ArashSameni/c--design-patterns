namespace DesignPatterns.Visitor;

public class AnchorNode : IHtmlNode
{
    public string Content { get; set; }
    public string Link { get; set; }
    
    public AnchorNode(string content = "", string link = "")
    {
        Content = content;
        Link = link;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public override string ToString()
    {
        return @$"<a href=""{Link}"">{Content}</a>";
    }
}