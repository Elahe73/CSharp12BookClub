// To call this method via the interface, we use a constrained type parameter.
// The following method creates an array of test data using this approach:

T[] CreateTestData<T>(int count) where T : ICreateRandom<T>
{
    T[] result = new T[count];
    for (int i = 0; i < count; i++)
        result[i] = T.CreateRandom();
    return result;
}

Point[] testData = CreateTestData<Point>(50);  // Create 50 random Points.

// Our call to the static CreateRandom method in CreateTestData is polymorphic because it works
// not just with Point, but with any type that implements ICreateRandom<T>. This is different to
// instance polymorphism, because we don’t need an instance of ICreateRandom<T> on which to call
// CreateRandom; we call CreateRandom on the type itself.


// Consider the following interface, which defines a static method to create a random instance of some type T:
interface ICreateRandom<T>
{
    static abstract T CreateRandom();  // Create a random instance of T
}

// Let's implement that interface:
record Point(int X, int Y) : ICreateRandom<Point>
{
    static Random rnd = new();
    public static Point CreateRandom() => new Point(rnd.Next(), rnd.Next());
}