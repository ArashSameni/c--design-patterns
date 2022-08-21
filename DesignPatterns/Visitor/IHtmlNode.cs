namespace DesignPatterns.Visitor;

public interface IHtmlNode
{
    public void Accept(IVisitor visitor);
}