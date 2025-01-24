using KMean_Algo.Centroids;
using KMean_Algo.Points;

namespace KMean_Algo;

public class Canvas
{
    private readonly List<Centroid> _centroids = [];
    private readonly List<Point> _points = [];
    private readonly Random _rnd = new();
    private readonly PointFactory _pointFactory = new();
    private readonly CentroidFactory _centroidFactory = new();
    
    public List<Centroid> GetCentroids() { return _centroids; }
    public List<Point> GetPoints() { return _points; }
    
    public void InitializePoints()
    {
        var numberOfPoints = _rnd.Next(Values.MinNumPoints, Values.MaxNumPoints + 1);
        for (var i = 0; i < numberOfPoints; i++)
        {
            _points.Add(_pointFactory.CreatePoint());
        }
    }
    
    public void InitializeCentroids()
    {
        for (var i = 1; i < Values.NumCentroids + 1; i++)
        {
            _centroids.Add(_centroidFactory.CreateCentroid(i));
        }
    }
}