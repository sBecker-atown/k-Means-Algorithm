using KMean_Algo.Centroids;
using KMean_Algo.Points;

namespace KMean_Algo.Rendering;

internal class Renderer
{
    private readonly RenderPoint[,] _renderPoints = new RenderPoint[Values.MaxHeight, Values.MaxWidth];

    private void ResetRenderPoints()
    {
        for (var i = 0; i < Values.MaxHeight; i++)
        {
            for (var j = 0; j < Values.MaxWidth; j++)
            {
                _renderPoints[i, j] = new RenderPoint();
            }
        }
    }
    public void MapRenderPoints(List<Point> points, List<Centroid> centroids)
    {
        ResetRenderPoints();
        foreach (var centroid in centroids)
        {
            var vertical = (int)Math.Floor(centroid.Y);
            var horizontal = (int)Math.Floor(centroid.X);
            
            _renderPoints[vertical, horizontal].Type = PointType.Centroid;
            _renderPoints[vertical, horizontal].ClusterId = centroid.ClusterId;
        }
        foreach (var point in points)
        {
            var vertical = (int)Math.Floor(point.Y);
            var horizontal = (int)Math.Floor(point.X);
            
            if (_renderPoints[vertical,horizontal].Type == PointType.Centroid)
            {
                continue;
            }
            _renderPoints[vertical, horizontal].Type = PointType.Point;
            _renderPoints[vertical, horizontal].ClusterId = point.ClusterId;
        }
    }

    public void Draw()
    {
        var centroid = "\u25cf";
        var point = "•"; //"•" "\u25aa"
        var blank = " ";
        
        for (var i = 0; i < Values.MaxHeight; i++)
        {
            for (var j = 0; j < Values.MaxWidth; j++)
            {
                var currentPoint = _renderPoints[i, j];
                if (currentPoint.ClusterId == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (currentPoint.Type == PointType.Centroid)
                    {
                        Console.Write(centroid);
                    }
                    if (currentPoint.Type == PointType.Point)
                    {
                        Console.Write(point);
                    }
                    if (currentPoint.Type == PointType.Blank)
                    {
                        Console.Write(blank);
                    }
                    Console.ResetColor();
                }
                if (currentPoint.ClusterId == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (currentPoint.Type == PointType.Centroid)
                    {
                        Console.Write(centroid);
                    }
                    if (currentPoint.Type == PointType.Point)
                    {
                        Console.Write(point);
                    }
                    if (currentPoint.Type == PointType.Blank)
                    {
                        Console.Write(blank);
                    }
                    Console.ResetColor();
                }
                if (currentPoint.ClusterId == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (currentPoint.Type == PointType.Centroid)
                    {
                        Console.Write(centroid);
                    }
                    if (currentPoint.Type == PointType.Point)
                    {
                        Console.Write(point);
                    }
                    if (currentPoint.Type == PointType.Blank)
                    {
                        Console.Write(blank);
                    }
                    Console.ResetColor();
                }
                if (currentPoint.ClusterId == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    if (currentPoint.Type == PointType.Centroid)
                    {
                        Console.Write(centroid);
                    }
                    if (currentPoint.Type == PointType.Point)
                    {
                        Console.Write(point);
                    }
                    if (currentPoint.Type == PointType.Blank)
                    {
                        Console.Write(blank);
                    }
                    Console.ResetColor();
                }
                if (currentPoint.ClusterId == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (currentPoint.Type == PointType.Centroid)
                    {
                        Console.Write(centroid);
                    }
                    if (currentPoint.Type == PointType.Point)
                    {
                        Console.Write(point);
                    }
                    if (currentPoint.Type == PointType.Blank)
                    {
                        Console.Write(blank);
                    }
                    Console.ResetColor();
                }
                if (currentPoint.ClusterId == 0)
                {
                    Console.Write(blank);
                }
            }
            Console.Write("\n");
        }
    }
}