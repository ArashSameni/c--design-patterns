namespace DesignPatterns.Structural.Decorator;

// Decorator
public class EncryptedCloudStream : IStream
{
    private IStream _stream;

    public EncryptedCloudStream(IStream stream)
    {
        _stream = stream;
    }

    public void Write(string data)
    {
        Console.WriteLine($"Encrypting \"{data}\"");
        var encryptedData = Encrypt(data);
        _stream.Write(encryptedData);
    }

    private string Encrypt(string data)
    {
        return new string(data.Select(c => (char)(c + 5)).ToArray());
    }
}