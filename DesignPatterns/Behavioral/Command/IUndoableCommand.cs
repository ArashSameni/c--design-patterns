namespace DesignPatterns.Behavioral.Command;

public interface IUndoableCommand : ICommand
{
    public void Undo();
}