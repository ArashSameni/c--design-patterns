namespace DesignPatterns.Visitor;

public class Runner : IRunnable
{
    public void Run()
    {
        var anchor = new AnchorNode("Google", "https://google.com");
        var heading = new HeadingNode("Hello World");

        anchor.Accept(new HighlightVisitor());
        heading.Accept(new HighlightVisitor());
    }
}