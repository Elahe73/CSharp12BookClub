using System.Numerics;

uint value = 0b00000000000000000000000000001111;

// LeadingZeroCount
int leadingZeros = BitOperations.LeadingZeroCount(value);
Console.WriteLine($"Leading zeros: {leadingZeros}");

// PopCount
int popCount = BitOperations.PopCount(value);
Console.WriteLine($"Population count: {popCount}");

// RotateLeft
uint rotatedLeft = BitOperations.RotateLeft(value, 2);
Console.WriteLine($"Rotated left: {Convert.ToString(rotatedLeft, toBase: 2)}");

// RotateRight
uint rotatedRight = BitOperations.RotateRight(value, 2);
Console.WriteLine($"Rotated right: {Convert.ToString(rotatedRight, toBase: 2)}");

// Log2
int log2 = BitOperations.Log2(value);
Console.WriteLine($"Log2: {log2}");

// TrailingZeroCount
int trailingZeros = BitOperations.TrailingZeroCount(value);
Console.WriteLine($"Trailing zeros: {trailingZeros}");