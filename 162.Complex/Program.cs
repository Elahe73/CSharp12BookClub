using System.Numerics;

var c1 = new Complex(2, 3.5);
var c2 = new Complex(3, 0);

Console.WriteLine(c1 + " c1");
Console.WriteLine(c2 + " c2");

Console.WriteLine(c1.Real);       // 2
Console.WriteLine(c1.Imaginary);  // 3.5
Console.WriteLine(c1.Phase);      // 1.05165021254837
Console.WriteLine(c1.Magnitude);  // 4.03112887414927

Complex c3 = Complex.FromPolarCoordinates(1.3, 5);

// The standard arithmetic operators are overloaded to work on Complex numbers:
Console.WriteLine(c1 + c2);    // (5, 3.5)
Console.WriteLine(c1 * c2);    // (6, 10.5)

Console.WriteLine(Complex.Atan(c1) + " Atan");
Console.WriteLine(Complex.Log10(c1) + " Log10");
Console.WriteLine(Complex.Conjugate(c1) + " Conjugate");