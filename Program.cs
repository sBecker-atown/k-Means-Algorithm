using KMean_Algo.Centroids;
using KMean_Algo.Points;

namespace KMean_Algo;

internal static class Program
{
    public static void Main(string[] args)
    {
        var centroidCalculator = new CentroidCalculator();
        var pointClusterCreator = new PointClusterCreator();
        var canvas = new Canvas();
        
        canvas.InitializePoints();
        canvas.InitializeCentroids();
        
        pointClusterCreator.ReclusterPoints(canvas.GetCentroids(), canvas.GetPoints());
        // Draw once.
        centroidCalculator.RecenterAll(canvas.GetCentroids(), canvas.GetPoints());
        // Draw again.
        
        // Debug Testing.
        foreach (var centroid in canvas.GetCentroids())
        {
            Console.WriteLine("X: " + centroid.X);
            Console.WriteLine("Y: " + centroid.Y);
            Console.WriteLine("Id: " + centroid.ClusterId);
            Console.WriteLine();
        }
    }
} 