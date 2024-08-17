var s = new Stack<int>();
s.Push(1);                      //            Stack = 1
s.Push(2);                      //            Stack = 1,2
s.Push(3);                      //            Stack = 1,2,3
Console.WriteLine(s.Count);     // Prints 3
Console.WriteLine(s.Peek());    // Prints 3,  Stack = 1,2,3
Console.WriteLine(s.Pop());     // Prints 3,  Stack = 1,2
Console.WriteLine(s.Pop());     // Prints 2,  Stack = 1
Console.WriteLine(s.Pop());     // Prints 1,  Stack = <empty>
Console.WriteLine(s.Pop());     // throws exception