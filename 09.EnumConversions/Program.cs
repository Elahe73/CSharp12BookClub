int i = (int)BorderSide.Left;
BorderSide side = (BorderSide)i;
bool leftOrRight = (int)side <= 2;

HorizontalAlignment h= (HorizontalAlignment)BorderSide.Right;
// same as:
//HorizontalAlignment h= (HorizontalAlignment)(int)BorderSide.Right;

Console.ReadKey();

public enum BorderSide { Left, Right, Top, Bottom }
public enum HorizontalAlignment
{
    Left = BorderSide.Left,
    Right = BorderSide.Right,
    Center
}