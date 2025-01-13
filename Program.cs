using System.Xml;
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

        Output(canvas);
        
        var iterations = 3; 

        for (var i = 0; i < iterations; i++)
        {
            pointClusterCreator.ReclusterPoints(canvas.GetCentroids(), canvas.GetPoints());
            centroidCalculator.RecenterAll(canvas.GetCentroids(), canvas.GetPoints());
            Console.WriteLine($"Iteration {i + 1}");
            Console.WriteLine();
            Output(canvas);
        }
    }

    private static void Output(Canvas canvas)
    {
        Console.WriteLine("Centroids:");
        foreach (var centroid in canvas.GetCentroids())
        {
            Console.WriteLine(centroid);
        }
        Console.WriteLine();
        Console.WriteLine("Points:");
        foreach (var point in canvas.GetPoints())
        {
            Console.WriteLine(point);
        }
        Console.WriteLine();
    }
} 