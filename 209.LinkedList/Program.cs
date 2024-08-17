var tune = new LinkedList<string>();
tune.AddFirst("do"); 
Console.WriteLine(string.Join(",", tune)); // do
tune.AddLast("so"); 
Console.WriteLine(string.Join(",", tune)); // do - so

tune.AddAfter(tune.First, "re"); 
Console.WriteLine(string.Join(",", tune)); // do - re- so
tune.AddAfter(tune.First.Next, "mi"); 
Console.WriteLine(string.Join(",", tune)); // do - re - mi- so
tune.AddBefore(tune.Last, "fa"); 
Console.WriteLine(string.Join(",", tune)); // do - re - mi - fa- so

tune.RemoveFirst(); 
Console.WriteLine(string.Join(",", tune)); // re - mi - fa - so
tune.RemoveLast(); 
Console.WriteLine(string.Join(",", tune)); // re - mi - fa

LinkedListNode<string> miNode = tune.Find("mi");
tune.Remove(miNode); 
Console.WriteLine(string.Join(",", tune)); // re - fa
tune.AddFirst(miNode); 
Console.WriteLine(string.Join(",", tune)); // mi- re - fa