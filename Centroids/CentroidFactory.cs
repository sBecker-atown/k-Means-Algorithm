namespace KMean_Algo.Centroids;

internal class CentroidFactory
{
    private readonly Random _rnd = new();
    
    public Centroid CreateCentroid(int clusterId)
    {
        return new Centroid(
            _rnd.Next(0, Values.MaxWidth + 1), 
            _rnd.Next(0, Values.MaxHeight + 1), 
            clusterId
            );
    }
}