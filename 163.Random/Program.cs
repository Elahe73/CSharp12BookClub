// If given the same seed, the random number series will be the same:
Random r1 = new Random(1);
Random r2 = new Random(1);
Console.WriteLine(r1.Next(100) + ", " + r1.Next(100));      // 24, 11
Console.WriteLine(r2.Next(100) + ", " + r2.Next(100));      // 24, 11

// Using system clock for seed:
Random r3 = new Random();
Random r4 = new Random();
Console.WriteLine(r3.Next(100) + ", " + r3.Next(100));      // ?, ?
Console.WriteLine(r4.Next(100) + ", " + r4.Next(100));      // ", "
// Notice we still get same sequences, because of limitations in system clock resolution.

// Here's a workaround:
Random r5 = new Random(Guid.NewGuid().GetHashCode());
Random r6 = new Random(Guid.NewGuid().GetHashCode());
Console.WriteLine(r5.Next(100) + ", " + r5.Next(100));      // ?, ?
Console.WriteLine(r6.Next(100) + ", " + r6.Next(100));      // ?, ?

// From .NET 8, the Random class includes a GetItems method, which picks n random items from a collection.
int[] numbers = { 10, 20, 30, 40, 50 };
int[] randomTwo = new Random().GetItems(numbers, 2);
Console.WriteLine("Two random items " + randomTwo);

// Shuffle (also new to .NET 8) shuffles items in an array:
new Random().Shuffle(numbers);
Console.WriteLine("All shuffled! " + numbers);


// Random is not crytographically strong (the following, however, is):
var rand = System.Security.Cryptography.RandomNumberGenerator.Create();
byte[] bytes = new byte[4];
rand.GetBytes(bytes);       // Fill the byte array with random numbers.

Console.WriteLine("A cryptographically strong random integer" + BitConverter.ToInt32(bytes, 0));