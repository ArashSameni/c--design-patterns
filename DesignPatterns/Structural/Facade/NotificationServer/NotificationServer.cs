namespace DesignPatterns.Structural.Facade.NotificationServer;

public class NotificationServer
{
    private readonly Connection _connection;
    public NotificationServer(string ipAddress, string appId, string key)
    {
        _connection = new Connection(ipAddress);
        new AuthToken(appId, key).Authenticate();
    }

    public void Send(Message message, string to)
    {
        _connection.Connect();
        Console.WriteLine($"Sending {message.Text} to {to}");
        _connection.Disconnect();
    }
}