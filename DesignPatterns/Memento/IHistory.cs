namespace DesignPatterns.Memento;

public interface IHistory<T>
{
    public void Push(T state);
    public T Pop();
    public bool IsEmpty();
}