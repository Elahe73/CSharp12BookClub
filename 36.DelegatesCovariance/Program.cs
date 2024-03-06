// A delegate can have more specific parameter types than its method target. This is called contravariance:

ObjectRetriever o = new ObjectRetriever(RetriveString);
object result = o();
Console.WriteLine(result);      // hello

Console.ReadLine();

string RetriveString() => "hello";

delegate object ObjectRetriever();