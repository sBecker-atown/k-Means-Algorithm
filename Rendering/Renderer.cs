using KMean_Algo.Centroids;
using KMean_Algo.Points;

namespace KMean_Algo.Rendering;

internal class Renderer
{
    private readonly RenderPoint[,] _renderPoints = new RenderPoint[Values.MaxHeight, Values.MaxWidth];

    private const string Centroid = "\u25cf";
    private const string Point = "•"; // "*"; //"•" "\u25aa"
    private const string Blank = " ";
    
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

            vertical = NormalizeVertical(vertical);
            horizontal = NormalizeHorizontal(horizontal);
            
            _renderPoints[vertical, horizontal].Type = PointType.Centroid;
            _renderPoints[vertical, horizontal].ClusterId = centroid.ClusterId;
        }
        foreach (var point in points)
        {
            var vertical = (int)Math.Floor(point.Y);
            var horizontal = (int)Math.Floor(point.X);
            
            vertical = NormalizeVertical(vertical);
            horizontal = NormalizeHorizontal(horizontal);
            
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
        for (var i = 0; i < Values.MaxHeight; i++)
        {
            for (var j = 0; j < Values.MaxWidth; j++)
            {
                var currentPoint = _renderPoints[i, j];
                switch (currentPoint.ClusterId)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        DrawPoint(currentPoint);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        DrawPoint(currentPoint);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        DrawPoint(currentPoint);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        DrawPoint(currentPoint);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        DrawPoint(currentPoint);
                        break;
                    case 0:
                        Console.Write(Blank);
                        break;
                }
            }
            Console.Write("\n");
        }
    }

    private static void DrawPoint(RenderPoint currentPoint)
    {
        switch (currentPoint.Type)
        {
            case PointType.Centroid:
                Console.Write(Centroid);
                break;
            case PointType.Point:
                Console.Write(Point);
                break;
            case PointType.Blank:
            default:
                Console.Write(Blank);
                break;
        }
        Console.ResetColor();
    }

    private static int NormalizeVertical(int value)
    {
        return value switch
        {
            <= 0 => 1,
            >= Values.MaxHeight => Values.MaxHeight - 1,
            _ => value
        };
    }
    
    private static int NormalizeHorizontal(int value)
    {
        return value switch
        {
            <= 0 => 1,
            >= Values.MaxWidth => Values.MaxWidth - 1,
            _ => value
        };
    }
}