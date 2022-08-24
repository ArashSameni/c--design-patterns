namespace DesignPatterns.Structural.Proxy;

public class Library
{
    private Dictionary<string, IEBook> _books = new();

    public void Add(IEBook book)
    {
        _books[book.FileName] = book;
    }

    public void Open(string fileName)
    {
        if (!_books.ContainsKey(fileName))
            throw new ArgumentException($"{fileName} doesn't exist", nameof(fileName));
        
        _books[fileName].Show();
    }
}