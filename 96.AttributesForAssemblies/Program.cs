using System.Reflection;

[assembly: AssemblyFileVersion("1.2.3.4")]

class Foo
{
    [field: NonSerialized]
    public int MyProperty { get; set; }
}