BorderSides leftRight = BorderSides.Left | BorderSides.Right;
if ((leftRight & BorderSides.Left) != 0)
    Console.WriteLine("Includes Left"); // Includes Left
string formatted = leftRight.ToString(); // "Left, Right"
BorderSides s = BorderSides.Left;
s |= BorderSides.Right;
Console.WriteLine(s == leftRight); // True
s ^= BorderSides.Right; // Toggles BorderSides.Right
Console.WriteLine(s); // Left


enum BorderSides { None = 0, Left = 1, Right = 1 << 1, Top = 1 << 2, Bottom = 1 << 3 }

//[Flags]
//enum BorderSides
//{
//    None = 0,
//    Left = 1, Right = 1 << 1, Top = 1 << 2, Bottom = 1 << 3,
//    LeftRight = Left | Right,
//    TopBottom = Top | Bottom,
//    All = LeftRight | TopBottom
//}
