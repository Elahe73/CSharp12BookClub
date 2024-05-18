// .NET 7 introduced the INumber<TSelf> interface to unify arithmetic operations across 
// numeric types, allowing generic methods such as the following to be written:

T Sum<T>(params T[] numbers) where T : System.Numerics.INumber<T>
{
    T total = T.Zero;
    foreach (T n in numbers)
        total += n;      // Invokes addition operator for any numeric type
    return total;
}

int intSum = Sum(3, 5, 7);
double doubleSum = Sum(3.2, 5.3, 7.1);
decimal decimalSum = Sum(3.2m, 5.3m, 7.1m);

// The System.Numerics namespace also contains interfaces that are not part of INumber for
// operations specific to certain kinds of numbers (such as floating-point). To compute a
// root-mean-square, for instance, we can add the IRootFunctions<T> interface to the 
// constraint list to expose its static RootN method to T:

T RMS<T>(params T[] values) where T : System.Numerics.INumber<T>, System.Numerics.IRootFunctions<T>
{
    T total = T.Zero;
    for (int i = 0; i < values.Length; i++)
        total += values[i] * values[i];
    // Use T.CreateChecked to convert values.Length (type int) to T.
    T count = T.CreateChecked(values.Length);
    return T.RootN(total / count, 2);   // Calculate square root
}

float rms1 = RMS(5f, 10f, 20f);
double rms2 = RMS(5d, 10d, 20d);