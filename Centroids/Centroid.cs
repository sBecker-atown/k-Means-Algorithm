namespace KMean_Algo.Centroids;

public class Centroid(double x, double y, int clusterId) {
    
    public double X { get; private set; } = x;
    public double Y { get; private set; } = y;
    public int ClusterId { get; } = clusterId;

    public void SetX(double x)
    {
        X = x;
    }

    public void SetY(double y)
    {
        Y = y;
    }

    override 
    public string ToString()
    {
        return $"({X}, {Y}, ID: {ClusterId})";
    }
}