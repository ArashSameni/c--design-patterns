namespace DesignPatterns.ChainOfResponsibility;

public class Authenticator : Handler
{
    protected override void DoHandle(HttpRequest request)
    {
        Console.WriteLine($"Authenticator handling the request: {request}");
    }
}