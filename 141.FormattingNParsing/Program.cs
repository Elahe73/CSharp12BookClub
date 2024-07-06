// The following all honor local culture settings:


Console.WriteLine($"Short date followed by long time : {DateTime.Now.ToString()}");
Console.WriteLine($"Short date followed by long time (+ timezone) : {DateTimeOffset.Now.ToString()}");

Console.WriteLine($"ToShortDateString : {DateTime.Now.ToShortDateString()}");
Console.WriteLine($"ToShortTimeString : {DateTime.Now.ToShortTimeString()}");

Console.WriteLine($"ToLongDateString : {DateTime.Now.ToLongDateString()}");
Console.WriteLine($"ToLongTimeString : {DateTime.Now.ToLongTimeString()}");

// Culture-agnostic methods make for reliable formatting & parsing:

DateTime dt1 = DateTime.Now;
string cannotBeMisparsed = dt1.ToString("o");
DateTime dt2 = DateTime.Parse(cannotBeMisparsed);
Console.WriteLine(dt2);