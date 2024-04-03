using System.Globalization;

Console.WriteLine("FF".IsHexNumber());  // True
Console.WriteLine("1A".NotHexNumber()); // False

static public class Ext
{
    static public bool IsHexNumber(this string candidate)
    {
        return int.TryParse(candidate, NumberStyles.HexNumber, null, out int _);
    }
    static public bool NotHexNumber(this string candidate)
    {
        return !IsHexNumber(candidate);
    }
}