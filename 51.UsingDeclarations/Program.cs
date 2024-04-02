
if (File.Exists("file.txt"))
{
    using var reader = File.OpenText("file.txt");
    Console.WriteLine(reader.ReadLine());
}

// reader is now disposed
Console.ReadKey();