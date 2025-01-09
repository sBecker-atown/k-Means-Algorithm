namespace KMean_Algo.Points;

public static class PointFactory
{
    private static readonly Random Rnd = new();
    
    public static Point CreatePoint()
    {
        return new Point(
            Rnd.Next(0, Values.MaxWidth + 1), 
            Rnd.Next(0, Values.MaxHeight + 1), 
            0
            );
    }
}