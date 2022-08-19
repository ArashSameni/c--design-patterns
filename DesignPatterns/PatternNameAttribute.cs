namespace DesignPatterns;

[AttributeUsage(AttributeTargets.Class)]
public class PatternNameAttribute : Attribute
{
    public string Name { get; set; }
    public PatternNameAttribute(string name)
    {
        Name = name;
    }
}