namespace DesignPatterns.Behavioral.State;

// Context
public class Canvas
{
    public ITool CurrentTool { get; set; }

    public Canvas(ITool currentTool)
    {
        CurrentTool = currentTool;
    }

    // Request
    public void MouseDown()
    {
        CurrentTool.MouseDown();
    }
}