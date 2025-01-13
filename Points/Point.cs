using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

public class Point(double x, double y, int clusterId) {
    public double X { get; private set; } = x;
    public double Y { get; private set; } = y;
    public int ClusterId { get; private set; } = clusterId;

    public double Distance(Centroid pointB)
    {
        return Math.Sqrt(Math.Pow(pointB.X - this.X, 2) + Math.Pow(pointB.Y - this.Y, 2));
    }

    public void SetCluster(int clusterId)
    {
        ClusterId = clusterId;
    }
    
    override 
        public string ToString()
    {
        return $"({X}, {Y}, ID: {ClusterId})";
    }
}