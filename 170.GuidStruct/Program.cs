Guid g = Guid.NewGuid();
Console.WriteLine(g.ToString() + " - Guid.NewGuid.ToString()");

Guid g1 = new Guid("{0d57629c-7d6e-4847-97cb-9e2fc25083fe}");
Guid g2 = new Guid("0d57629c7d6e484797cb9e2fc25083fe");
Console.WriteLine(g1 == g2);  // True

byte[] bytes = g.ToByteArray();
Guid g3 = new Guid(bytes);
Console.WriteLine(g3);

Console.WriteLine(Guid.Empty + " - Guid.Empty");
Console.WriteLine(default(Guid) + " - default(Guid)");
Console.WriteLine(Guid.Empty.ToByteArray() + " - Guid.Empty - bytes");