namespace DesignPatterns.Structural.Flyweight;

public static class PointIconFactory
{
    private static readonly Dictionary<PointType, PointIcon> PointIcons = new();
    
    public static PointIcon GetPointIcon(PointType type)
    {
        if (!PointIcons.ContainsKey(type))
            PointIcons[type] = new PointIcon(type, new byte[]{});
        
        return PointIcons[type];
    }
}