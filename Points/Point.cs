using KMean_Algo.Centroids;

namespace KMean_Algo.Points;

public class Point(double x, double y, int clusterId) {
    public double X { get; } = x;
    public double Y { get; } = y;
    public int ClusterId { get; set; } = clusterId;

    public double Distance(Centroid pointB)
    {
        return Math.Sqrt(Math.Pow(this.X - pointB.X, 2) + Math.Pow(this.Y - pointB.Y, 2));
    }
    
    override 
        public string ToString()
    {
        return $"({X}, {Y}, ID: {ClusterId})";
    }
}