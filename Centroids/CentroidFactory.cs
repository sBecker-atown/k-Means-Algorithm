namespace KMean_Algo.Centroids;

public static class CentroidFactory
{
    private static readonly Random Rnd = new();
    
    public static Centroid CreateCentroid(int clusterId)
    {
        return new Centroid(Rnd.Next(1, 26), Rnd.Next(1, 26), clusterId);
    }
}