namespace KMean_Algo.Points;

public class PointController
{
    private readonly List<Point> _points = new ();
    private readonly Random _rnd = new();

    public void CreatePoints()
    {
        var numberOfPoints = _rnd.Next(Values.MinNumPoints, Values.MaxNumPoints + 1);
        for (var i = 0; i < numberOfPoints; i++)
        {
            _points.Add(PointFactory.CreatePoint());
        }
    }

    public List<Point> GetPoints() { return _points; }
}