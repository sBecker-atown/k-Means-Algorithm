namespace KMean_Algo.Points;

public static class PointFactory
{
    private static readonly Random Rnd = new();
    
    public static Point CreatePoint()
    {
        return new Point(Rnd.Next(1, 26), Rnd.Next(1, 26), 0);
    }
}