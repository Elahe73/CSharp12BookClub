// Extension methods, like instance methods, provide a tidy way to chain functions:

string x = "sausage".Pluralize().Capitalize();

// Equivalent to:
string y = StringHelper.Capitalize(StringHelper.Pluralize("sausage"));

Console.ReadLine();

public static class StringHelper
{
    public static string Pluralize(this string s) => s + "s";   // Very naiive implementation!

    public static string Capitalize(this string s) => s.ToUpper();
}