// With interfaces, we’re forced into writing a separate type per transform
// since Test can only implement ITransformer once:

int[] values = { 1, 2, 3 };
Util.TransformAll(values, new Cuber());

Console.ReadKey();

public interface ITransformer
{
    int Transform(int x);
}

public class Util
{
    public static void TransformAll(int[] values, ITransformer t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t.Transform(values[i]);
    }
}

class Squarer : ITransformer
{
    public int Transform(int x) => x * x;
}

class Cuber : ITransformer
{
    public int Transform(int x) => x * x * x;
}