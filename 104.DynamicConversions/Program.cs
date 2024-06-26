﻿// The dynamic type has implicit conversions to and from all other types:

int i = 7;
dynamic d = i;
int j = d;        // Implicit conversion (or more precisely, an *assignment conversion*)


// The following throws a RuntimeBinderException because an int is not implicitly convertible to a short:
short s = d;


Console.ReadLine();