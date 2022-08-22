namespace DesignPatterns.Behavioral.Visitor;

public interface IHtmlNode
{
    public void Accept(IVisitor visitor);
}