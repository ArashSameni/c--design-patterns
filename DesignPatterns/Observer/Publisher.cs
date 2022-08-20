namespace DesignPatterns.Observer;

// Observable or Subject
public abstract class Publisher
{
    private readonly ICollection<IObserver> _observers;

    protected Publisher(ICollection<IObserver> observers)
    {
        _observers = observers;
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}