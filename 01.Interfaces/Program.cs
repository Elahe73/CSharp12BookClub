// The IEnumerator interface is part of the .NET Framework, defined in System.Collections.
// We can define our own version of this as follows:

IEnumerator e = new Countdown();
while (e.MoveNext())
    Console.Write(e.Current);      // 109876543210

Console.ReadLine();

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

// Here's a class that implements this interface:

class Countdown : IEnumerator
{
    int count = 11;
    public bool MoveNext() => count-- > 0;
    public object Current => count;
    public void Reset() { throw new NotSupportedException(); }
}