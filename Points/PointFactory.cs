namespace KMean_Algo.Points;

internal class PointFactory
{
    private readonly Random _rnd = new();
    
    public Point CreatePoint()
    {
        return new Point(
            _rnd.Next(0, Values.MaxWidth), 
            _rnd.Next(0, Values.MaxHeight), 
            0
            );
    }
}