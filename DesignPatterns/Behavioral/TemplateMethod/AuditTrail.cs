namespace DesignPatterns.Behavioral.TemplateMethod;

public static class AuditTrail
{
    public static void Record(Task task)
    {
        Console.WriteLine($"{task.GetType().Name} Recorded");
    }
}