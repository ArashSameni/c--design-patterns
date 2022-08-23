namespace DesignPatterns.Structural.Facade.NotificationServer;

public class Message
{
    public string Text { get; }

    public Message(string text)
    {
        Text = text;
    }
}