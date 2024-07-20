// To string:
Console.WriteLine(BorderSides.Right.ToString());
Console.WriteLine(Enum.Format(typeof(BorderSides), BorderSides.Right, "g"));

// From string:
BorderSides leftRight = (BorderSides)Enum.Parse(typeof(BorderSides), "Left, Right");
Console.WriteLine(leftRight);

BorderSides leftRightCaseInsensitive = (BorderSides)
  Enum.Parse(typeof(BorderSides), "left, right", true);

Console.WriteLine(leftRightCaseInsensitive);

[Flags] public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }