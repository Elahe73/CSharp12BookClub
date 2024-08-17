{
    var letters = new HashSet<char>("the quick brown fox");

    Console.WriteLine(letters.Contains('t'));      // true
    Console.WriteLine(letters.Contains('j'));      // false

    foreach (char c in letters) Console.Write(c);   // the quickbrownfx
}
Console.WriteLine();
{
    var letters = new SortedSet<char>("the quick brown fox");

    foreach (char c in letters)
        Console.Write(c);                                    //  bcefhiknoqrtuwx

    Console.WriteLine();

    foreach (char c in letters.GetViewBetween('f', 'i'))
        Console.Write(c);                                    //  fhi
}


{
    var letters = new HashSet<char>("the quick brown fox");
    letters.IntersectWith("aeiou");
    foreach (char c in letters) Console.Write(c);     // euio
}
Console.WriteLine();
{
    var letters = new HashSet<char>("the quick brown fox");
    letters.ExceptWith("aeiou");
    foreach (char c in letters) Console.Write(c);     // th qckbrwnfx
}
Console.WriteLine();
{
    var letters = new HashSet<char>("the quick brown fox");
    letters.SymmetricExceptWith("the lazy brown fox");
    foreach (char c in letters) Console.Write(c);     // quicklazy
}