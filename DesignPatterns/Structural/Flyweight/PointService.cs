namespace DesignPatterns.Structural.Flyweight;

public static class PointService
{
    public static IList<Point> GetPoints()
    {
        return new List<Point>
        {
            new(5, 10, PointIconFactory.GetPointIcon(PointType.Cafe)),
            new(19, 6, PointIconFactory.GetPointIcon(PointType.Cafe)),
            new(24, 13, PointIconFactory.GetPointIcon(PointType.Hospital)),
            new(76, 4, PointIconFactory.GetPointIcon(PointType.Restaurant)),
            new(34, 14, PointIconFactory.GetPointIcon(PointType.Restaurant)),
        };
    }
}