namespace DesignPatterns.ChainOfResponsibility;

public abstract class Handler
{
    public Handler? Next { get; set; }

    public void Handle(HttpRequest request)
    {
        DoHandle(request);
        Next?.Handle(request);
    }
    
    protected abstract void DoHandle(HttpRequest request);
}