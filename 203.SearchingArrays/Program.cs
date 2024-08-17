string[] names = { "Rodney", "Jack", "Jill", "Jane" };

Console.WriteLine(Array.Find(names, n => n.Contains("a")));  // Returns first matching element
Console.WriteLine(Array.FindAll(names, n => n.Contains("a")));  // Returns all matching elements

// Equivalent in LINQ:

Console.WriteLine(names.FirstOrDefault(n => n.Contains("a")));
Console.WriteLine(names.Where(n => n.Contains("a")));