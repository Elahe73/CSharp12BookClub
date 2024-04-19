var p1 = new Point(2, 3);                // OK

try
{
    var p2 = new Point(double.NaN, 3);
}
catch (ArgumentException ex)
{    
    Console.WriteLine("Expected error");
    Console.WriteLine("Expected error : " + ex.Message);
}

try
{
    var p3 = p1 with { X = double.NaN };
}
catch (ArgumentException ex)
{
    Console.WriteLine("Expected error : " + ex.Message);
}

record Point
{
    // Notice that we assign x to the X property (and not the _x field):
    public Point(double x, double y) => (X, Y) = (x, y);

    double _x;
    public double X
    {
        get => _x;
        init
        {
            if (double.IsNaN(value))
                throw new ArgumentException("X Cannot be NaN");
            _x = value;
        }
    }
    public double Y { get; init; }
}