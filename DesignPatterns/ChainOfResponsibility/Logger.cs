namespace DesignPatterns.ChainOfResponsibility;

public class Logger : Handler
{
    protected override void DoHandle(HttpRequest request)
    {
        Console.WriteLine($"Logging the request: {request}");
    }
}