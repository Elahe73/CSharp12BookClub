// Captured variables have their lifetimes extended to that of the delegate:
static Func<int> Natural()
{
    int seed = 0;
    return () => seed++;    // Returns a closure
}


Func<int> natural = Natural();
Console.WriteLine(natural());      // 0
Console.WriteLine(natural());      // 1

Console.ReadLine();
