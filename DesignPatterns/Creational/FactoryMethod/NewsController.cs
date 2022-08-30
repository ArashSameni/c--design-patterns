using DesignPatterns.Creational.FactoryMethod.WebAppFramework;

namespace DesignPatterns.Creational.FactoryMethod;

public class NewsController : Controller
{
    public void GetNews()
    {
        var news = new List<string>
        {
            "Some news",
            "Another news"
        };

        Render("news.html", new Dictionary<string, object>
        {
            { "news", news }
        });
    }

    protected override IViewEngine CreateViewEngine()
    {
        return new ComplexViewEngine();
    }
}