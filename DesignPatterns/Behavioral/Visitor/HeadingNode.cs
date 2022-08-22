namespace DesignPatterns.Behavioral.Visitor;

public class HeadingNode : IHtmlNode
{
    public string Content { get; set; }
    
    public HeadingNode(string content = "")
    {
        Content = content;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public override string ToString()
    {
        return "<h1>" + Content + "</h1>";
    }
}