// A delegate type may contain generic type parameters:
int[] values = { 1, 2, 3 };
Util.Transform(values, Square);      // Dynamically hook in Square


Console.ReadKey();

int Square(int x) => x * x;

public delegate T Transformer<T>(T arg);

// With this definition, we can write a generalized Transform utility method that works on any type:
public class Util
{
    public static void Transform<T>(T[] values, Transformer<T> t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t(values[i]);
    }
}