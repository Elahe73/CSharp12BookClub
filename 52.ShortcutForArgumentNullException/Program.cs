void Display(string name)
{
    ArgumentNullException.ThrowIfNull(name);
    Console.WriteLine(name);
}

// Exceptions can be thrown either by the runtime or in user code:
try
{
    Display(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Caught the exception");
}

Console.ReadKey();
