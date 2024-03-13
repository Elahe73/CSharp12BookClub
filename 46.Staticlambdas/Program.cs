Func<int, int> multiplier = static n => n * 2;
Console.WriteLine(multiplier(123));

Foo();

Console.ReadLine();

void Foo()
{
    Multiply(123);

    static int Multiply(int x) => x * 2;   // Local static method
}