foreach (Enum value in Enum.GetValues(typeof(BorderSides)))
    Console.WriteLine(value);

[Flags] public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }