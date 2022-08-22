namespace DesignPatterns.Behavioral.Command;

// Concrete Command
public class BoldCommand : IUndoableCommand
{
    private readonly HtmlElement _element;
    private readonly History _history;
    private string? _prevContent;

    public BoldCommand(HtmlElement element, History history)
    {
        _element = element;
        _history = history;
    }

    public void Execute()
    {
        if (_prevContent != null)
            throw new InvalidOperationException("Already executed");
        
        _prevContent = _element.Content;
        _element.MakeBold();
        _history.Push(this);
    }

    public void Undo()
    {
        if (_prevContent != null)
            _element.Content = _prevContent;
    }
}