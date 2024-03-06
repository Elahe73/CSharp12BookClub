// A delegate variable is assigned a method dynamically. This is useful for writing plug-in methods:

int[] values = { 1, 2, 3 };
Transform(values, Square);   // Hook in the Square method


values = new int[] { 1, 2, 3 };
Transform(values, Cube);          // Hook in the Cube method

Console.ReadKey();

void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
        values[i] = t(values[i]);
}

int Square(int x) => x * x;
int Cube(int x) => x * x * x;

delegate int Transformer(int x);