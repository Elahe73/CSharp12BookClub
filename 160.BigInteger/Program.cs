// BigInteger supports arbitrary precision.

using System.Numerics;
using System.Security.Cryptography;

BigInteger twentyFive = 25;      // implicit cast from integer

BigInteger googol = BigInteger.Pow(10, 100);

// Alternatively, you can Parse a string: 
BigInteger googolFromString = BigInteger.Parse("1".PadRight(101, '0'));

Console.WriteLine(googol.ToString());

double g1 = 1e100;                  // implicit cast
BigInteger g2 = (BigInteger)g1;    // explicit cast
Console.WriteLine(g2 + " Note loss of precision");

// This uses the System.Security.Cryptography namespace:
RandomNumberGenerator rand = RandomNumberGenerator.Create();
byte[] bytes = new byte[32];
rand.GetBytes(bytes);
var bigRandomNumber = new BigInteger(bytes);   // Convert to BigInteger
Console.WriteLine(bigRandomNumber + " Big random number");