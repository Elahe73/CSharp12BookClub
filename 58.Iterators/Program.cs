// Whereas a foreach statement is a consumer of an enumerator, an iterator is a producer of an enumerator:

foreach (int fib in Fibs(6))
    Console.Write(fib + "  ");

Console.ReadKey();

IEnumerable<int> Fibs(int fibCount)
{
    for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
    {
        yield return prevFib;
        int newFib = prevFib + curFib;
        prevFib = curFib;
        curFib = newFib;
    }
}