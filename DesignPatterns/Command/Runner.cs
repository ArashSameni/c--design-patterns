namespace DesignPatterns.Command;

public class Runner : IRunnable
{
    public void Run()
    {
        var history = new History();
        var undoCommand = new UndoCommand(history);
        var htmlElement = new HtmlElement("Hello world");
        
        new ItalicCommand(htmlElement, history).Execute();
        new BoldCommand(htmlElement, history).Execute();

        Console.WriteLine(htmlElement.Content);
        
        undoCommand.Execute();
        Console.WriteLine(htmlElement.Content);
        
        undoCommand.Execute();
        Console.WriteLine(htmlElement.Content);
    }
}