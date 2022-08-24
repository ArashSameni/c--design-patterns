using System.Text.RegularExpressions;
using DesignPatterns;

// Uncomment to see the result of the pattern

// RunPattern(new DesignPatterns.Behavioral.Memento.Runner());
// RunPattern(new DesignPatterns.Behavioral.State.Runner());
// RunPattern(new DesignPatterns.Behavioral.Iterator.Runner());
// RunPattern(new DesignPatterns.Behavioral.Strategy.Runner());
// RunPattern(new DesignPatterns.Behavioral.TemplateMethod.Runner());
// RunPattern(new DesignPatterns.Behavioral.Command.Runner());
// RunPattern(new DesignPatterns.Behavioral.Observer.Runner());
// RunPattern(new DesignPatterns.Behavioral.Mediator.Runner());
// RunPattern(new DesignPatterns.Behavioral.ChainOfResponsibility.Runner());
// RunPattern(new DesignPatterns.Behavioral.Visitor.Runner());

// RunPattern(new DesignPatterns.Structural.Composite.Runner());
// RunPattern(new DesignPatterns.Structural.Adapter.Runner());
// RunPattern(new DesignPatterns.Structural.Decorator.Runner());
// RunPattern(new DesignPatterns.Structural.Facade.Runner());
// RunPattern(new DesignPatterns.Structural.Flyweight.Runner());
RunPattern(new DesignPatterns.Structural.Bridge.Runner());

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