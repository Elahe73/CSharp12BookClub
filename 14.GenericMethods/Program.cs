// A generic method declares type parameters within the signature of a method.

int x = 5;
int y = 10;
Swap(ref x, ref y);

Console.ReadKey();

static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}