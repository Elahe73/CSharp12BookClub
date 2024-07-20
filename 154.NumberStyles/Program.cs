using System.Globalization;

int thousand = int.Parse("3E8", NumberStyles.HexNumber);
int minusTwo = int.Parse("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses);

Console.WriteLine(double.Parse("1,000,000", NumberStyles.Any) + "million");
Console.WriteLine(decimal.Parse("3e6", NumberStyles.Any) + "3 million");
Console.WriteLine(decimal.Parse("$5.20", NumberStyles.Currency) + "5.2");

NumberFormatInfo ni = new NumberFormatInfo();
ni.CurrencySymbol = "€";
ni.CurrencyGroupSeparator = " ";
Console.WriteLine(double.Parse("€1 000 000", NumberStyles.Currency, ni) + "million");