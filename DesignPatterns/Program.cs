using DesignPatterns;

RunPattern(new DesignPatterns.Memento.Runner());
RunPattern(new DesignPatterns.State.Runner());
RunPattern(new DesignPatterns.Iterator.Runner());
RunPattern(new DesignPatterns.Strategy.Runner());

void RunPattern(IRunnable runnablePattern)
{
    var patternName = GetPatternName(runnablePattern);
    Console.WriteLine("===================================\n");
    Console.WriteLine($"{patternName} Pattern:\n");
    runnablePattern.Run();
    Console.WriteLine("\n===================================\n");
}

string GetPatternName(IRunnable runnablePattern)
{
    return runnablePattern.GetType().Namespace!.Split('.').Last();
}