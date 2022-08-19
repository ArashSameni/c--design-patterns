namespace DesignPatterns.Memento;

// Memento
public class EditorState
{
    public string Title { get; }
    public string Content { get; }

    public EditorState(string title, string content)
    {
        Title = title;
        Content = content;
    }
}