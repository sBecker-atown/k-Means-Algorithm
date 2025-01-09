using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

internal class PointClusterCreator
{
    public void ReclusterPoints(List<Centroid> centroids, List<Point> points)
    {
        foreach (var point in points)
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