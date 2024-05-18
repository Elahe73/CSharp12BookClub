// Memory can be allocated in a block on the stack explicitly using the stackalloc keyword:

unsafe
{
    int* a = stackalloc int[10];
    for (int i = 0; i < 10; ++i)
        Console.WriteLine(a[i]);   // Print raw memory
}