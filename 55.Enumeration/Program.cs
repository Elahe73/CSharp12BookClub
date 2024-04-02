// High-level way of iterating through the characters in the word “beer”:

foreach (char c in "beer")
    Console.WriteLine(c);

// Low-level way of iterating through the same characters:

using (var enumerator = "beer".GetEnumerator())
    while (enumerator.MoveNext())
    {
        var element = enumerator.Current;
        Console.WriteLine(element);
    }