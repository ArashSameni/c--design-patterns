namespace DesignPatterns.State;

public class Runner : IRunnable
{
    public void Run()
    {
        var canvas = new Canvas(new Brush());
        canvas.MouseDown();

        canvas.CurrentTool = new Eraser();
        canvas.MouseDown();
    }
}