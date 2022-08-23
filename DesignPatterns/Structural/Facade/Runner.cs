namespace DesignPatterns.Structural.Facade;

public class Runner : IRunnable
{
    public void Run()
    {
        NotificationService.Send("Hello world", "arash");
    }
}