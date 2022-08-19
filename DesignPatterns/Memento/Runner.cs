namespace DesignPatterns.Memento;

[PatternName("Memento")]
public class Runner : IRunnable
{
    public void Run()
    {
        var editor = new Editor
        {
            Title = "My name",
            Content = "Arash"
        };
        var history = new EditorHistory();

        history.Push(editor.GetState());

        editor.Title = "My friend's name";
        editor.Content = "Hadi";
        history.Push(editor.GetState());

        editor.Title = "Another friend";
        editor.Content = "Sahar";
        history.Push(editor.GetState());

        while (!history.IsEmpty())
        {
            editor.Restore(history.Pop());
            Console.WriteLine($"Title: {editor.Title}, Content: {editor.Content}");
        }
    }
}