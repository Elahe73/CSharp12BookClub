// A delegate can have more specific parameter types than its method target. This is called contravariance:

void ActOnObject(object o) => Console.WriteLine(o);   // hello

StringAction sa = new StringAction(ActOnObject);
sa("hello");

Console.ReadKey();


delegate void StringAction(string s);