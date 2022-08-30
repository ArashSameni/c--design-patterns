namespace DesignPatterns.Creational.FactoryMethod.WebAppFramework;

public class SimpleViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context)
    {
        return "View rendered by " + nameof(SimpleViewEngine);
    }
}