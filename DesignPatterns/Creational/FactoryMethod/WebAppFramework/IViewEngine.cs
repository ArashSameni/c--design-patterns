namespace DesignPatterns.Creational.FactoryMethod.WebAppFramework;

public interface IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context);
}