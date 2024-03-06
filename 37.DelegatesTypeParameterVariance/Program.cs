/* From C# 4.0, type parameters on generic delegates can be marked as covariant (out) or contravariant (in).

For instance, the System.Func delegate in the Framework is defined as follows:

  public delegate TResult Func<out TResult>();

This makes the following legal:  */

Func<string> x = () => "Hello, world";
Func<object> y = x;

/* The System.Action delegate is defined as follows:

  void Action<in T> (T arg);

This makes the following legal:  */

Action<object> x2 = o => Console.WriteLine(o);
Action<string> y2 = x2;