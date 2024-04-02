bool result;
var resultCode = TryToBoolean("Bad", out result);
result = ToBoolean("Bad");    // throws Exception

Console.ReadKey();

bool ToBoolean(string text)
{
    bool returnValue;
    if (!TryToBoolean(text, out returnValue))
        throw new FormatException("Cannot parse to Boolean");
    return returnValue;
}

bool TryToBoolean(string text, out bool result)
{
    text = text.Trim().ToUpperInvariant();
    if (text == "TRUE" || text == "YES" || text == "Y")
    {
        result = true;
        return true;
    }
    if (text == "FALSE" || text == "NO" || text == "N")
    {
        result = false;
        return true;
    }
    result = false;
    return false;
}