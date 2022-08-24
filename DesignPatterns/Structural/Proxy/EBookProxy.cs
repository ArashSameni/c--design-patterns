namespace DesignPatterns.Structural.Proxy;

// Proxy for LazyLoading
public class EBookProxy : IEBook
{
    private EBook? _eBook;
    public string FileName { get; }
    
    public EBookProxy(string fileName)
    {
        FileName = fileName;
    }

    public void Show()
    {
        if (_eBook is null)
            _eBook = new EBook(FileName);
        
        _eBook.Show();
    }
}