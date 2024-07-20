foreach (char c in "gfdx")
    Format(c.ToString());

void Format(string formatString)
{
    Console.WriteLine(ConsoleColor.Red.ToString(formatString) + "ToString (\"" + formatString + "\")");
}