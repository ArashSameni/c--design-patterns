namespace DesignPatterns.Visitor;

public interface IVisitor
{
    public void Visit(HeadingNode heading);
    public void Visit(AnchorNode anchor);
}