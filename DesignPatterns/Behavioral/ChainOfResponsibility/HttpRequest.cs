namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class HttpRequest
{
    public Uri Url { get; set; }
    public HttpMethod HttpMethod { get; set; }

    public HttpRequest(string url, HttpMethod httpMethod)
    {
        Url = new Uri(url);
        HttpMethod = httpMethod;
    }

    public override string ToString()
    {
        return $"{HttpMethod} {Url.AbsolutePath}";
    }
}