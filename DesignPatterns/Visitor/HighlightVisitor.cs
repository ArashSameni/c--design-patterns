namespace DesignPatterns.Visitor;

public class HighlightVisitor : IVisitor
{
    public void Visit(HeadingNode heading)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(heading.Content);
        Console.ResetColor();
    }

    public void Visit(AnchorNode anchor)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(anchor);
        Console.ResetColor();
    }
}