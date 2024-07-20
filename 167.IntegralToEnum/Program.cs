object bs = Enum.ToObject(typeof(BorderSides), 3);
Console.WriteLine(bs);                              // Left, Right

//This is the dynamic equivalent of this:
BorderSides bs2 = (BorderSides)3;

[Flags] public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }