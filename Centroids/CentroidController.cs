namespace KMean_Algo.Centroids;

public class CentroidController
{
    private readonly List<Centroid> _centroids = new ();

    public void CreateCentroids()
    {
        for (var i = 1; i < Values.NumCentroids + 1; i++)
        {
            _centroids.Add(CentroidFactory.CreateCentroid(i));
        }
    }

    public List<Centroid> GetCentroids() { return _centroids; }
}