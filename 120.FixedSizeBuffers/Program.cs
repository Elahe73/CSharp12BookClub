// Memory can be allocated in a block within a struct using the fixed keyword:

new UnsafeClass("Christian Troy");

unsafe struct UnsafeUnicodeString
{
    public short Length;
    public fixed byte Buffer[30];
}

unsafe class UnsafeClass
{
    UnsafeUnicodeString uus;
    public UnsafeClass(string s)
    {
        uus.Length = (short)s.Length;
        fixed (byte* p = uus.Buffer)
            for (int i = 0; i < s.Length; i++)
                p[i] = (byte)s[i];
    }
}