var p = new Point(2, 2);
Console.WriteLine(p is (2, 2));                     // True
Console.WriteLine(p is (var x, var y) && x == y);   // True

Console.WriteLine(Print(new Point(0, 0)));
Console.WriteLine(Print(new Point(1, 1)));

string Print(object obj) => obj switch
{
    Point(0, 0) => "Empty point",
    Point(var x, var y) when x == y => "Diagonal",

    _ => "Other"
};

record Point(int X, int Y);