namespace DesignPatterns.Memento;

// Caretaker
public class EditorHistory : IHistory<EditorState>
{
    private readonly Stack<EditorState> _states = new();
    
    public void Push(EditorState state)
    {
        _states.Push(state);
    }

    public EditorState Pop()
    {
        if (_states.Count == 0)
            throw new InvalidOperationException("History is empty");
        return _states.Pop();
    }

    public bool IsEmpty()
    {
        return _states.Count == 0;
    }
}