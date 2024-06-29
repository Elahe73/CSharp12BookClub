// Split takes a sentence and returns an array of words (default delimiters = whitespace):
string[] words = "The quick brown fox".Split();
Console.WriteLine(words);

// The static Join method does the reverse of Split:
string together = string.Join(" ", words);
Console.WriteLine(together);                // The quick brown fox

// The static Concat method accepts only a params string array and applies no separator.
// This is exactly equivalent to the + operator:
string sentence = string.Concat("The", " quick", " brown", " fox");
string sameSentence = "The" + " quick" + " brown" + " fox";

Console.WriteLine(sameSentence);

Console.ReadLine();