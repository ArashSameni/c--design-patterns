namespace DesignPatterns.Observer;

public class DataSource : Publisher
{
    private int _data;
    public int Data
    {
        get => _data;
        set
        {
            _data = value;
            Notify();
        }
    }

    public DataSource() : base(new List<IObserver>())
    {
    }
}