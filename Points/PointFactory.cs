namespace KMean_Algo.Points;

public static class PointFactory
{
    private static readonly Random Rnd = new();
    
    public static Point CreatePoint()
    {
        return new Point(Rnd.Next(0, 26), Rnd.Next(0, 26), 0);
    }
}