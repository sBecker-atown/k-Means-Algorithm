namespace KMean_Algo.Centroids;

public class Centroid(double x, double y, int clusterId) {
    
    public double X { get; set; } = x;
    public double Y { get; set; } = y;
    public int ClusterId { get; } = clusterId;

    override 
    public string ToString()
    {
        return $"({X}, {Y}, ID: {ClusterId})";
    }
}