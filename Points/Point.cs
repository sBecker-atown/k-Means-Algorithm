using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

public class Point(int x, int y, int clusterId)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public int ClusterId { get; private set; } = clusterId;

    public double Distance(Centroid pointB)
    {
        return Math.Sqrt(Math.Pow(pointB.X - this.X, 2) + Math.Pow(pointB.Y - this.Y, 2));
    }

    public void SetCluster(int clusterId)
    {
        ClusterId = clusterId;
    }
}