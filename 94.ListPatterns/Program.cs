// List patterns (from C# 11) work with any collection type that is countable
// (with a Count or Length property) and indexable (with an indexer of type int or System.Index).

// A list pattern matches a series of elements in square brackets:
int[] numbers = { 0, 1, 6, 3, 4 };
Console.WriteLine(numbers is [0, 1, 2, 3, 4]);   // True

// An underscore matches a single element of any value:
Console.WriteLine(numbers is [0, 1, _, _, 4]);   // True

// The var pattern also works in matching a single element:
Console.WriteLine(numbers is [0, 1, var x, 3, 4] && x > 1);   // True

// Two dots indicate a slice.A slice matches zero or more elements:
Console.WriteLine(numbers is [0, .., 4]);    // True

// With arrays and other types that support indices and ranges
//   - see query://../../Chapter_2_-_C#_Language_Basics/Arrays/Indices 
//     and query://../../Chapter_2_-_C#_Language_Basics/Arrays/Ranges 
// you can follow a slice with a var pattern:
Console.WriteLine(numbers is [0, .. var mid, 4] && mid.Contains(2)); // True

// A list pattern can include at most one slice.

Console.ReadLine();