namespace DesignPatterns.Behavioral.TemplateMethod;

// Abstract Class
public abstract class Task
{
    // Template Method
    public void Execute()
    {
        AuditTrail.Record(this);
        DoExecute();
    }

    // Primitive Operation
    protected abstract void DoExecute();
}