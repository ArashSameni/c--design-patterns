using DesignPatterns.Creational.FactoryMethod.WebAppFramework;

namespace DesignPatterns.Creational.FactoryMethod;

public class ComplexViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context)
    {
        return "View rendered by " + nameof(ComplexViewEngine);
    }
}