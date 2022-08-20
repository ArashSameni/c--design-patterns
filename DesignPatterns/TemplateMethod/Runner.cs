namespace DesignPatterns.TemplateMethod;

public class Runner : IRunnable
{
    public void Run()
    {
        var transferMoney = new TransferMoneyTask();
        transferMoney.Execute();

        var generateReports = new GenerateReportTask();
        generateReports.Execute();
    }
}