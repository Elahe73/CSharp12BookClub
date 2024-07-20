using System.Globalization;

string composite = "Credit={0:C}";
Console.WriteLine(string.Format(composite, 500));   // Credit=$500.00

Console.WriteLine("Credit={0:C}", 500);   // Credit=$500.00

{
    object someObject = DateTime.Now;
    string s = string.Format(CultureInfo.InvariantCulture, "{0}", someObject);
    Console.WriteLine(s);
}
// Equivalent to:
{
    object someObject = DateTime.Now;
    string s;
    if (someObject is IFormattable)
        s = ((IFormattable)someObject).ToString(null, CultureInfo.InvariantCulture);
    else if (someObject == null)
        s = "";
    else
        s = someObject.ToString();
    Console.WriteLine(s);
}