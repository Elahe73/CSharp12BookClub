// There’s no standard interface for parsing through a format provider; instead use Parse/TryParse methods
// on the target types:

using System.Globalization;

try
{
    int error = int.Parse("(2)");   // Exception thrown
}
catch (FormatException ex) { Console.WriteLine(ex); }

int minusTwo = int.Parse("(2)"
    , NumberStyles.Integer | NumberStyles.AllowParentheses);   // OK
Console.WriteLine(minusTwo);

decimal fivePointTwo = decimal.Parse("£5.20", NumberStyles.Currency
    , CultureInfo.GetCultureInfo("en-GB"));
Console.WriteLine(fivePointTwo);