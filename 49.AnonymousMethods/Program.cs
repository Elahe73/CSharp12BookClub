internal class Program
{
    delegate int Transformer(int i);

    private static void Main(string[] args)
    {
        // This can be done more easily with a lambda expression:
        Transformer sqr = delegate (int x) { return x * x; };
        Console.WriteLine(sqr(3));
        Console.ReadKey();
    }

    // A unique feature of anonymous methods is that you can omit the parameter declaration entirely - even 
    // if the delegate expects them. This can be useful in declaring events with a default empty handler:
    public static event EventHandler Clicked = delegate { };
    // because it avoids the need for a null check before firing the event.

    // The following is also legal:
    static void HookUp()
    {
        Clicked += delegate { Console.WriteLine("clicked"); };   // No parameters
    }
}