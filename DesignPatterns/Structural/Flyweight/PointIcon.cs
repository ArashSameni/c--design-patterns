namespace DesignPatterns.Structural.Flyweight;

public class PointIcon
{
    private Guid _guid;
    public string Guid => _guid.ToString().Substring(0, 5);
    public PointType Type { get; }
    private readonly byte[] _icon;

    public PointIcon(PointType type, byte[] icon)
    {
        Type = type;
        _icon = icon;
        _guid = System.Guid.NewGuid();
    }
}