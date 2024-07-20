// The simplest formatting mechanism is the ToString method.
using System.Globalization;

string s = true.ToString();
Console.WriteLine(s);

// Parse does the reverse:
bool b = bool.Parse(s);
Console.WriteLine(b);

// TryParse avoids a FormatException in case of error:
int i;
Console.WriteLine(int.TryParse("qwerty", out i) + " Successful");
Console.WriteLine(int.TryParse("123", out i) + " Successful");

if (int.TryParse("123", out int j))
{
    Console.WriteLine(j + " Use j");
}

bool validInt = int.TryParse("123", out int _);
Console.WriteLine( validInt + " We don't care about the actual value so use discard.");

// Culture trap:
Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");  // Germany
Console.WriteLine(double.Parse("1.234") + " Parsing 1.234");   // 1234 

// Specifying invariant culture fixes this:
Console.WriteLine(double.Parse("1.234", CultureInfo.InvariantCulture) + " Parsing 1.234 Invariantly");

Console.WriteLine((1.234).ToString() + " 1.234.ToString()");
Console.WriteLine((1.234).ToString(CultureInfo.InvariantCulture) + " 1.234.ToString Invariant");