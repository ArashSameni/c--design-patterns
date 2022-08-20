namespace DesignPatterns.Command;

public class UndoCommand : ICommand
{
    private readonly History _history;

    public UndoCommand(History history)
    {
        _history = history;
    }

    public void Execute()
    {
        while (_history.Count > 0)
        {
            if (_history.Pop() is IUndoableCommand undoableCommand)
            {
                undoableCommand.Undo();
                break;
            }
        }
    }
}