using KMean_Algo.Points;

namespace KMean_Algo.Centroids;

public class CentroidController
{
    private readonly List<Centroid> _centroids = new ();

    public void InitializeCentroids()
    {
        for (var i = 1; i < Values.NumCentroids + 1; i++)
        {
            _centroids.Add(CentroidFactory.CreateCentroid(i));
        }
    }

    public List<Centroid> GetCentroids() { return _centroids; }

    public void RecenterAll(List<Point> points)
    {
        // Recenter Centroids based on cluster points.
    }
}