namespace DesignPatterns.Behavioral.TemplateMethod;

// Concrete Class
public class GenerateReportTask : Task
{
    // Primitive Operation
    protected override void DoExecute()
    {
        Console.WriteLine("Generating reports...");
    }
}