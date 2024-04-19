var person = GetPerson();
Console.WriteLine(person.Name);    // Bob
Console.WriteLine(person.Age);     // 23

Console.ReadLine();

static (string Name, int Age) GetPerson() => ("Bob", 23);