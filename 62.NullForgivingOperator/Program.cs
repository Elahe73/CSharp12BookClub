#nullable enable

// Enable nullable reference types

// This generates a warning:

void Foo1(string? s) => Console.Write(s.Length);

// which we can remove with the null-forgiving operator:
void Foo2(string? s) => Console.Write(s!.Length);

// If we add a check, we no longer need the null-forgiving operator in this case:
void Foo3(string? s)
{
    if (s != null) Console.Write(s.Length);
}