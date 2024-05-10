Foo(3);

Console.ReadLine();

void Foo(object obj)
{
    // C# won’t let you use the == operator, because obj is object.
    // However, we can use ‘is’
    if (obj is 3) Console.WriteLine("three");
}