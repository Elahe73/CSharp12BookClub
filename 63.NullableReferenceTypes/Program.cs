#nullable enable

string s1 = null;   // Generates a compiler warning!
string? s2 = null;  // OK: s2 is nullable reference type

class Foo
{
    string x;     // Generates a warning
}