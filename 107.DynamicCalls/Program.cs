// You can also call statically known functions with dynamic arguments.
// Such calls are subject to dynamic overload resolution:

dynamic x = 5;
dynamic y = "watermelon";

FooProvider.Foo(x);                // 1
FooProvider.Foo(y);                // 2

Console.ReadLine();

public static class FooProvider
{
    public static void Foo(int x) { Console.WriteLine("1"); }
    public static void Foo(string x) { Console.WriteLine("2"); }
}