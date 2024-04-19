(string Name, int Age, char Sex) bob1 = ("Bob", 23, 'M');
(string Age, int Sex, char Name) bob2 = bob1;   // No error!

// Our particular example leads to confusing results:
Console.WriteLine(bob2.Name);    // M
Console.WriteLine(bob2.Age);     // Bob
Console.WriteLine(bob2.Sex);     // 23

object bobCopy = bob1;

Console.ReadLine();