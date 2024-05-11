// Static types are also used — wherever possible — in dynamic binding:

// Note: the following sometimes throws a RuntimeBinderException in Framework 4.0 beta 2. This is a bug.

object o = "hello";
dynamic d = "goodbye";
FooProvider.Foo(o, d);               // os


public static class FooProvider
{
    public static void Foo(object x, object y) { Console.WriteLine("oo"); }
    public static void Foo(object x, string y) { Console.WriteLine("os"); }
    public static void Foo(string x, object y) { Console.WriteLine("so"); }
    public static void Foo(string x, string y) { Console.WriteLine("ss"); }
}