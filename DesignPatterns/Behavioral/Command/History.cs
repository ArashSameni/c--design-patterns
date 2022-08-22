namespace DesignPatterns.Behavioral.Command;

public class History
{
    private readonly Stack<ICommand> _commands = new();

    public void Push(ICommand command)
    {
        _commands.Push(command);
    }

    public ICommand Pop()
    {
        return _commands.Pop();
    }

    public int Count => _commands.Count;
}