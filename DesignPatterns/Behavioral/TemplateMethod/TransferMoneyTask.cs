namespace DesignPatterns.Behavioral.TemplateMethod;

// Concrete Class
public class TransferMoneyTask : Task
{
    // Primitive Operation
    protected override void DoExecute()
    {
        Console.WriteLine("Transferring money...");
    }
}