Half h = (Half)123.456;
Console.WriteLine(h);     // 123.44

Console.WriteLine(Half.MinValue);   // -65500
Console.WriteLine(Half.MaxValue);   // 65500

Console.WriteLine((Half)65500);     // 65500
Console.WriteLine((Half)65490);     // 65500
Console.WriteLine((Half)65480);     // 65470