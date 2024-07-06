DateTime d1 = new DateTime(2010, 1, 30);  // Midnight, January 30 2010
Console.WriteLine(d1);

DateTime d2 = new DateTime(2010, 1, 30, 12, 0, 0);    // Midday, January 30 2010
Console.WriteLine(d2);
Console.WriteLine(d2.Kind);

DateTime d3 = new DateTime(2010, 1, 30, 12, 0, 0, DateTimeKind.Utc);
Console.WriteLine(d3);
Console.WriteLine(d3.Kind);

DateTimeOffset d4 = d1;    // Implicit conversion
Console.WriteLine(d4);

DateTimeOffset d5 = new DateTimeOffset(d1, TimeSpan.FromHours(-8));  // -8 hours UTC
Console.WriteLine(d5);

// See "Formatting & Parsing" for constructing a DateTime from a string