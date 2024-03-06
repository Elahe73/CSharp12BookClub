// A delegate type declaration is like an abstract method declaration, prefixed with the delegate keyword.
// To create a delegate instance, assign a method to a delegate variable:  

Transformer t = Square;          // Create delegate instance
int result = t(3);               // Invoke delegate
Console.WriteLine(result);      // 9

Console.ReadKey();
int Square(int x) => x * x;

delegate int Transformer(int x);   // Our delegate type declaration