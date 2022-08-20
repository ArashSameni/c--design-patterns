namespace DesignPatterns.Observer;

public class Runner : IRunnable
{
    public void Run()
    {
        var dataSource = new DataSource();
        var spreadSheet = new SpreadSheet(dataSource);
        var chart = new Chart(dataSource);
        
        dataSource.Attach(spreadSheet);
        dataSource.Attach(chart);

        dataSource.Data = 5;
        
        dataSource.Detach(spreadSheet);
        
        dataSource.Data = 10;
    }
}