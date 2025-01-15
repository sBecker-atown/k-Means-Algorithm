using KMean_Algo.Centroids;
using KMean_Algo.Points;
using KMean_Algo.Rendering;

namespace KMean_Algo;

internal static class Program
{
    public static void Main(string[] args)
    {
        var centroidCalculator = new CentroidCalculator();
        var pointClusterCreator = new PointClusterCreator();
        var canvas = new Canvas();
        var renderer = new Renderer();
        
        canvas.InitializePoints();
        canvas.InitializeCentroids();
        
        // Draw once
        Console.WriteLine("Iteration 0");
        pointClusterCreator.ReclusterPoints(canvas.GetCentroids(), canvas.GetPoints());
        renderer.MapRenderPoints(canvas.GetPoints(), canvas.GetCentroids());
        renderer.Draw();
        Console.WriteLine();
        
        var iterations = 5; 
        
        for (var i = 0; i < iterations; i++)
        {
            Console.WriteLine($"Iteration {i + 1}");
            Console.WriteLine();
            centroidCalculator.RecenterAll(canvas.GetCentroids(), canvas.GetPoints());
            renderer.MapRenderPoints(canvas.GetPoints(), canvas.GetCentroids());
            renderer.Draw();
            Console.WriteLine();
            pointClusterCreator.ReclusterPoints(canvas.GetCentroids(), canvas.GetPoints());
        }
    }

    /* private static void Output(Canvas canvas)
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
    } */
} 