namespace DesignPatterns;

public static class PatternRunner
{
    public static void Run(IRunnable runnablePattern)
    {
        var patternName = GetPatternName(runnablePattern);
        Console.WriteLine($"{patternName} Pattern:");
        runnablePattern.Run();
        Console.WriteLine("===================================\n");
    }

    private static string GetPatternName(IRunnable runnablePattern)
    {
        var patternNameAttribute = (PatternNameAttribute)runnablePattern.GetType()
            .GetCustomAttributes(typeof(PatternNameAttribute), false)[0];
        return patternNameAttribute .Name;
    }
}