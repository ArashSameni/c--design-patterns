namespace DesignPatterns.Creational.FactoryMethod;

public class Runner : IRunnable
{
    public void Run()
    {
        var newsController = new NewsController();
        newsController.GetNews();
    }
}