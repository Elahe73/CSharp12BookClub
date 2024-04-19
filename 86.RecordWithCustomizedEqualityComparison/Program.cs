Console.WriteLine(new Point1(1, 2) == new Point1(1, 2));   // False
Console.WriteLine(new Point2(1, 2) == new Point2(1, 2));   // True

Console.ReadKey();

record Point1(double X, double Y)
{
    static int _nextInstance;
    double _someOtherField = _nextInstance++;
}

record Point2(double X, double Y)
{
    static int _nextInstance;
    double _someOtherField = _nextInstance++;

    public virtual bool Equals(Point2 other) =>
      other != null && X == other.X && Y == other.Y;

    public override int GetHashCode() => (X, Y).GetHashCode();
}