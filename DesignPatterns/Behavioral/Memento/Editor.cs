namespace DesignPatterns.Behavioral.Memento;

// Originator
public class Editor
{
    public string Title { get; set; } = String.Empty;
    public string Content { get; set; } = String.Empty;

    public EditorState GetState()
    {
        return new EditorState(Title, Content);
    }

    public void Restore(EditorState state)
    {
        Title = state.Title;
        Content = state.Content;
    }
}