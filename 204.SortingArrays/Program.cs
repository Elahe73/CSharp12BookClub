int[] numbers = [3, 2, 1];
Array.Sort(numbers);
Console.WriteLine($"Simple sort : {string.Join(",", numbers)}");

numbers = [3, 2, 1];
string[] words = { "three", "two", "one" };
Array.Sort(numbers, words);
Console.WriteLine($"Parallel sort : {string.Join(",", numbers)} - {string.Join(",", words)}");