namespace DesignPatterns.Structural.Facade.NotificationServer;

public class NotificationServer
{
    private readonly string _ipAddress;

    public NotificationServer(string ipAddress, string appId, string key)
    {
        _ipAddress = ipAddress;
        new AuthToken(appId, key).Authenticate();
    }

    public void Send(Message message, string to)
    {
        Console.WriteLine($"Sending {message.Text} to {to}");
    }
}