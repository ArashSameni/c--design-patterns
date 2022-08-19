namespace DesignPatterns.State;

public static class Usage
{
    public static void Run()
    {
        var canvas = new Canvas(new Brush());
        canvas.MouseDown();

        canvas.CurrentTool = new Eraser();
        canvas.MouseDown();
    }
}