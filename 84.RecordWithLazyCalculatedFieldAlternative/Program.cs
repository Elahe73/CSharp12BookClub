Point p1 = new Point(2, 3);
Console.WriteLine(p1.DistanceFromOrigin);

Point p2 = p1 with { Y = 4 };
Console.WriteLine(p2.DistanceFromOrigin);

// This also works, but is not quite as efficient if we had additional
// properties that weren't part of the calculation.

Console.ReadKey();

record Point(double X, double Y)
{
    double? _distance;
    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);

    protected Point(Point other) => (X, Y) = other;
}