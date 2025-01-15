namespace KMean_Algo.Points;

internal static class PointFactory
{
    private static readonly Random Rnd = new();
    
    public static Point CreatePoint()
    {
        return new Point(
            Rnd.Next(0, Values.MaxWidth), 
            Rnd.Next(0, Values.MaxHeight), 
            0
            );
    }
}