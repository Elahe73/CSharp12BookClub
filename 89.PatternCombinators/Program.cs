Console.WriteLine(IsJanetOrJohn("Janet"));
Console.WriteLine(IsVowel('e'));
Console.WriteLine(Between1And9(5));
Console.WriteLine(IsLetter('!'));

Console.ReadLine();

bool IsJanetOrJohn(string name) => name.ToUpper() is "JANET" or "JOHN";

bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';

bool Between1And9(int n) => n is >= 1 and <= 9;

bool IsLetter(char c) => c is >= 'a' and <= 'z'
                            or >= 'A' and <= 'Z';