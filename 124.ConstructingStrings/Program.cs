// String literals:
string s1 = "Hello";
string s2 = "First Line\r\nSecond Line";
string s3 = @"\\server\fileshare\helloworld.cs";

// To create a repeating sequence of characters you can use string’s constructor:
Console.Write(new string('*', 10));    // **********

// You can also construct a string from a char array. ToCharArray does the reverse:
char[] ca = "Hello".ToCharArray();
string s = new string(ca);              // s = "Hello"
Console.WriteLine(s);

Console.ReadLine();