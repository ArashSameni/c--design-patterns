using System.Text.RegularExpressions;
using DesignPatterns;

RunPattern(new DesignPatterns.Memento.Runner());
RunPattern(new DesignPatterns.State.Runner());
RunPattern(new DesignPatterns.Iterator.Runner());
RunPattern(new DesignPatterns.Strategy.Runner());
RunPattern(new DesignPatterns.TemplateMethod.Runner());
RunPattern(new DesignPatterns.Command.Runner());
RunPattern(new DesignPatterns.Observer.Runner());
RunPattern(new DesignPatterns.Mediator.Runner());
RunPattern(new DesignPatterns.ChainOfResponsibility.Runner());
RunPattern(new DesignPatterns.Visitor.Runner());

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
    return AddSpaceBeforeCapitalLetters(runnablePattern.GetType().Namespace!.Split('.').Last());
}

string AddSpaceBeforeCapitalLetters(string text)
{
    return Regex.Replace(text, "([a-z])([A-Z])", "$1 $2");
}