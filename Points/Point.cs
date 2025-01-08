using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

public class Point 
{
    public int X { get; }
    public int Y { get; }
    public int ClusterId { get; private set; }

    public Point(int x, int y, int clusterId)
    {
        X = x;
        Y = y; 
        ClusterId = clusterId;
    }

    public double Distance(Centroid pointB)
    {
        return Math.Sqrt(Math.Pow(pointB.X - this.X, 2) + Math.Pow(pointB.Y - this.Y, 2));
    }

    public void SetCluster(int clusterId)
    {
        ClusterId = clusterId;
    }
}