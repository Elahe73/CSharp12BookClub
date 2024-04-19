Point p1 = new Point(2, 3);
Console.WriteLine(p1.DistanceFromOrigin);

Point p2 = p1 with { Y = 4 };
Console.WriteLine(p2.DistanceFromOrigin);


Console.ReadKey();

// The best solution is to use lazy evaluation.

record Point
{
    public Point(double x, double y) => (X, Y) = (x, y);

    double _x, _y;
    public double X { get => _x; init { _x = value; _distance = null; } }
    public double Y { get => _y; init { _y = value; _distance = null; } }

    double? _distance;
    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);
}