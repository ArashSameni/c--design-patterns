namespace DesignPatterns.Structural.Facade.NotificationServer;

public class AuthToken
{
    private readonly string _appId;
    private readonly string _key;

    public AuthToken(string appId, string key)
    {
        _appId = appId;
        _key = key;
    }

    public void Authenticate()
    {
        Console.WriteLine($"Authenticating {_appId};{_key}");
    }
}