int[] myArray = { 1, 2, 3 };
foreach (int val in myArray)
    Console.WriteLine(val);

// Alternative:
Array.ForEach(new[] { 1, 2, 3 }, Console.WriteLine);

// From C# 12:
Array.ForEach([1, 2, 3], Console.WriteLine);