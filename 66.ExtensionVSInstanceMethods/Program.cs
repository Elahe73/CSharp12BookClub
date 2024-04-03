// Any compatible instance method will always take precedence over an extension method:

new Test().Foo("string");  // Instance method wins, as you'd expect
new Test().Foo(123);       // Instance method still wins

public class Test
{
    public void Foo(object x) { Console.WriteLine("Instance") }    // This method always wins
}

public static class Extensions
{
    public static void Foo(this object t, int x) => Console.WriteLine("Extension");
}