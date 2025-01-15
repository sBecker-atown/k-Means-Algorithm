using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

internal class PointClusterCreator
{
    public void ReclusterPoints(List<Centroid> centroids, List<Point> points)
    {
        foreach (var point in points)
        {
            double? shortestDistance = null;
            var nearestCentroidId = 0;

            foreach (var centroid in centroids)
            {
                var currentDistance = point.Distance(centroid);
                if (shortestDistance == null || currentDistance < shortestDistance)
                {
                    shortestDistance = currentDistance;
                    nearestCentroidId = centroid.ClusterId;
                }
            } 
            point.ClusterId = nearestCentroidId;
        } 
    }
}