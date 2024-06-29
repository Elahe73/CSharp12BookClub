int musicalNote = 0x1D161;

string s = char.ConvertFromUtf32(musicalNote);
Console.WriteLine(s.Length);  // 2 (surrogate pair)

Console.WriteLine(char.ConvertToUtf32(s, 0).ToString("X"));      // Consumes two chars
Console.WriteLine(char.ConvertToUtf32(s[0], s[1]).ToString("X"));    // Explicitly specify two chars

Console.ReadLine();