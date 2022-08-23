using DesignPatterns.Structural.Facade.NotificationServer;

namespace DesignPatterns.Structural.Facade;

public static class NotificationService
{
    public static void Send(string message, string target)
    {
        var notificationServer = new NotificationServer.NotificationServer("1.2.3.4", "AppId", "Key");
        notificationServer.Send(new Message(message), target);
    }
}