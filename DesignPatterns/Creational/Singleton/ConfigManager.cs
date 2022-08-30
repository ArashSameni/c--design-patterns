namespace DesignPatterns.Creational.Singleton;

public class ConfigManager
{
    private static ConfigManager? _instance;
    private readonly Dictionary<string, object> _settings = new();

    private ConfigManager()
    {
    }

    public static ConfigManager GetInstance()
    {
        if (_instance == null)
            _instance = new ConfigManager();

        return _instance;
    }

    public void Set(string key, object value)
    {
        _settings[key] = value;
    }

    public object Get(string key)
    {
        return _settings[key];
    }
}