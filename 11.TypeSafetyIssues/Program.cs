﻿for (int i = 0; i <= 16; i++)
{
    BorderSides side = (BorderSides)i;
    Console.WriteLine(IsFlagDefined(side) + " " + side);
}

Console.ReadKey();

bool IsFlagDefined(Enum e)
{
    decimal d;
    return !decimal.TryParse(e.ToString(), out d);
}

[Flags]
public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }