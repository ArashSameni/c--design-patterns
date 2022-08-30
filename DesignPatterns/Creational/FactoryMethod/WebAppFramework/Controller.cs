namespace DesignPatterns.Creational.FactoryMethod.WebAppFramework;

public abstract class Controller
{
    public void Render(string viewName, Dictionary<string, object> context)
    {
        var viewEngine = CreateViewEngine();
        Console.WriteLine(viewEngine.Render(viewName, context));
    }

    protected virtual IViewEngine CreateViewEngine()
    {
        return new SimpleViewEngine();
    }
}