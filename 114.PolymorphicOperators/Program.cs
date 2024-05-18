// With a constrained type parameter, we can then write a method that calls our 
// addition operator polymorphically (with edge-case handling omitted for brevity):

T Sum<T>(params T[] values) where T : IAddable<T>
{
    T total = values[0];
    for (int i = 1; i < values.Length; i++)
        total += values[i];
    return total;
}

var sumResult = Sum(new Point(1, 2), new Point(3, 4));

//Our call to the + operator (via the += operator) is polymorphic because it binds to
// IAddable<T>, not Point. Hence, our Sum method works with all types that implement IAddable<T>.


// Because operators are essentially static functions (see “Operator Overloading”),
// operators can also be declared as static virtual interface members:
interface IAddable<T> where T : IAddable<T>
{
    abstract static T operator +(T left, T right);
}

// Here’s how we can implement the interface:
record Point(int X, int Y) : IAddable<Point>
{
    public static Point operator +(Point left, Point right) =>
      new Point(left.X + right.X, left.Y + right.Y);
}