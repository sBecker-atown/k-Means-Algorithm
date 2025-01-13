using KMean_Algo.Points;

namespace KMean_Algo.Centroids;

internal class CentroidCalculator
{
    public void RecenterAll(List<Centroid> centroids, List<Point> points)
    {
        // Recenter Centroids based on cluster points.
        foreach (Centroid centroid in centroids)
        {
            double sumX = 0;
            double sumY = 0;
            var numPoints = 0;
            foreach (var point in points)
            {
                if (point.ClusterId == centroid.ClusterId)
                {
                    sumX += point.X;
                    sumY += point.Y;
                    numPoints++;
                }
            }
            centroid.SetX(sumX / numPoints);
            centroid.SetY(sumY / numPoints);
        }
    }
}