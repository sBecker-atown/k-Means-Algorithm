using KMean_Algo.Centroids;
using KMean_Algo.Points;

namespace KMean_Algo;

internal static class Program
{
    public static void Main(string[] args)
    {
        var centroidController = new CentroidController();
        var pointController = new PointController();
        
        pointController.InitializePoints();
        centroidController.InitializeCentroids();
        
        pointController.ReclusterPoints(centroidController.GetCentroids());
        // Draw once.
        centroidController.RecenterAll(pointController.GetPoints());
        // Draw again.
        
        // Debug Testing.
        foreach (var centroid in centroidController.GetCentroids())
        {
            Console.WriteLine("X: " + centroid.X);
            Console.WriteLine("Y: " + centroid.Y);
            Console.WriteLine("Id: " + centroid.ClusterId);
            Console.WriteLine();
        }
    }
} 