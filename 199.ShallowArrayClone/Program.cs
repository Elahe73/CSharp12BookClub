using System.Text;

StringBuilder[] builders = new StringBuilder[5];
builders[0] = new StringBuilder("builder1");
builders[1] = new StringBuilder("builder2");
builders[2] = new StringBuilder("builder3");

StringBuilder[] builders2 = builders;
StringBuilder[] shallowClone = (StringBuilder[])builders.Clone();

Console.WriteLine(string.Join(" , ", builders.Select(x => x?.ToString())));
Console.WriteLine(string.Join(" , ", builders2.Select(x => x?.ToString())));

Console.WriteLine($"Comparing first element of each array : {(builders[0] == builders2[0])}");