// C# supports direct memory manipulation via pointers within blocks of code marked unsafe
// and compiled with the /unsafe compiler option. LINQPad implicitly compiles with this option.

// Here's how to use pointers to quickly process a bitmap:

int[,] bitmap = { { 0x101010, 0x808080, 0xFFFFFF }, { 0x101010, 0x808080, 0xFFFFFF } };
BlueFilter(bitmap);

unsafe static void BlueFilter(int[,] bitmap)
{
    int length = bitmap.Length;
    fixed (int* b = bitmap)
    {
        int* p = b;
        for (int i = 0; i < length; i++)
            *p++ &= 0xFF;
    }
}