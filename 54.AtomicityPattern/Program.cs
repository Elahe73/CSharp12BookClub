Accumulator a = new Accumulator();
try
{
    a.Add(4, 5);             // a.Total is now 9
    a.Add(1, int.MaxValue);  // Will cause OverflowException
}
catch (OverflowException)
{
    Console.WriteLine(a.Total);  // a.Total is still 9
}

Console.ReadKey();

public class Accumulator
{
    public int Total { get; private set; }

    public void Add(params int[] ints)
    {
        bool success = false;
        int totalSnapshot = Total;
        try
        {
            foreach (int i in ints)
            {
                checked { Total += i; }
            }
            success = true;
        }
        finally
        {
            if (!success)
                Total = totalSnapshot;
        }
    }
}