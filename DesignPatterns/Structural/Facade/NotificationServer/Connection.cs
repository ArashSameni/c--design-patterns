namespace DesignPatterns.Structural.Facade.NotificationServer;

public class Connection
{
    private readonly string _ipAddress;
    
    public Connection(string ipAddress)
    {
        _ipAddress = ipAddress;
    }

    public void Connect()
    {
        Console.WriteLine($"Connecting to \"{_ipAddress}\"");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected");
    }
}