// Unlike string, StringBuilder is mutable.

// The following is more efficient than repeatedly concatenating ordinary string types:

using System.Text;

StringBuilder sb = new StringBuilder();

for (int i = 0; i < 50; i++) sb.Append(i + ",");

// To get the final result, call ToString():
Console.WriteLine(sb.ToString());

sb.Remove(0, 60);    // Remove first 50 characters
sb.Length = 10;      // Truncate to 10 characters
sb.Replace(",", "+");  // Replace comma with +
Console.WriteLine(sb.ToString());

sb.Length = 0;      // Clear StringBuilder

Console.ReadLine();