﻿// A local variable instantiated within a lambda expression is unique per invocation of the
// delegate instance:

static Func<int> Natural()
{
    return () => { int seed = 0; return seed++; };
}

Func<int> natural = Natural();
Console.WriteLine(natural());           // 0
Console.WriteLine(natural());           // 0

Console.ReadLine();