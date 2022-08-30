namespace DesignPatterns.Creational.Singleton;

public class Runner : IRunnable
{
    public void Run()
    {
        var configManager = ConfigManager.GetInstance();
        configManager.Set("name", "arash");

        var otherConfigManager = ConfigManager.GetInstance();
        Console.WriteLine((string)otherConfigManager.Get("name"));
    }
}