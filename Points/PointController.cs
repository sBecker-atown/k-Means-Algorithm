using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

public class PointController
{
    private readonly List<Point> _points = [];
    private readonly Random _rnd = new();

    public void InitializePoints()
    {
        var numberOfPoints = _rnd.Next(Values.MinNumPoints, Values.MaxNumPoints + 1);
        for (var i = 0; i < numberOfPoints; i++)
        {
            _points.Add(PointFactory.CreatePoint());
        }
    }

    public List<Point> GetPoints() { return _points; }

    public void ReclusterPoints(List<Centroid> centroids)
    {
        foreach (var point in _points)
        {
            int? shortestDistance = null;
            Centroid? nearestCentroid  = null;
            
            foreach (var centroid in centroids)
            {
                var currentDistance = (int) point.Distance(centroid);
                if (shortestDistance == null)
                {
                    shortestDistance = currentDistance;
                    nearestCentroid = centroid;
                    continue;
                }
                if (currentDistance < shortestDistance)
                {
                    shortestDistance = currentDistance;
                    nearestCentroid = centroid;
                }
            }
            if (nearestCentroid != null)
            {
                point.SetCluster(nearestCentroid.ClusterId);
            }
        } 
    }
}