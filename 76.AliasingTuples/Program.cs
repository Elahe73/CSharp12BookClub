// From C#, you can leverage the using directive to define aliases for tuples:
using Point = (int, int);

// This feature also works with tuples that have named elements:
using Point1 = (int X, int Y);    // Legal (but not necessarily *good*!)

Point1 p = (3, 4);

// We’ll see shortly how records offer a fully-typed solution with the same level of conciseness:
record Point2(int X, int Y);