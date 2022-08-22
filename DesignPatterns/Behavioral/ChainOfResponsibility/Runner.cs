namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class Runner : IRunnable
{
    public void Run()
    {
        var request = new HttpRequest("https://example.com/index.html", HttpMethod.Get);

        var logger = new Logger();
        var authenticator = new Authenticator { Next = logger };

        var webServer = new WebServer(authenticator);
        
        webServer.Handle(request);
    }
}