using DesignPatterns;

RunPattern(new DesignPatterns.Memento.Runner());
RunPattern(new DesignPatterns.State.Runner());
RunPattern(new DesignPatterns.Iterator.Runner());

void RunPattern(IRunnable runnablePattern)
{
    var patternName = GetPatternName(runnablePattern);
    Console.WriteLine($"{patternName} Pattern:");
    runnablePattern.Run();
    Console.WriteLine("===================================\n");
}

string GetPatternName(IRunnable runnablePattern)
{
    var patternNameAttribute = (PatternNameAttribute)runnablePattern.GetType()
        .GetCustomAttributes(typeof(PatternNameAttribute), false)[0];
    return patternNameAttribute.Name;
}