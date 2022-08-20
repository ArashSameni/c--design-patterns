namespace DesignPatterns.Command;

public interface IUndoableCommand : ICommand
{
    public void Undo();
}