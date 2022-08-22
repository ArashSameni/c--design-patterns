namespace DesignPatterns.Structural.Decorator;

public class Runner : IRunnable
{
    public void Run()
    {
        var data = "I hate design patterns";
        var cloudStream = new CloudStream();
        var encryptedStream = new EncryptedCloudStream(cloudStream);
        var compressedStream = new CompressedCloudStream(encryptedStream);
        
        compressedStream.Write(data);
    }
}