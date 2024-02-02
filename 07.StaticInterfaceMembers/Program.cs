#region Example1

ILogger.Prefix = "File log: ";

var logger = new Logger();
((ILogger)logger).Log("message");

Console.ReadKey();
interface ILogger
{
    void Log(string text) =>
      Console.WriteLine(Prefix + text);

    static string Prefix = "Elahe ";
}

class Logger : ILogger
{
    // We don't need to implement anything
}

#endregion

#region Example2

//ILogger foo = new Logger();
//foo.Log(new Exception("test"));

//Console.ReadKey();

//class Logger : ILogger
//{
//    public void Log(string message) => Console.WriteLine(message);
//}

//interface ILogger
//{
//    // Let's suppose the interface as always defined this method:
//    void Log(string message);

//    // Adding a new member to an interface need not break implementors:
//    public void Log(Exception ex) => Log(ExceptionHeader + ex.Message);

//    static string ExceptionHeader = "Exception: ";
//}

#endregion

#region Example3

// Static virtual/abstract interface members (from C# 11) enable static polymorphism,
// an advanced feature that we will discuss in Chapter 4

interface ITypeDescribable
{
    static abstract string Description { get; }
    static virtual string Category => null;
}

// An implementing class or struct must implement static abstract members, and can
// optionally implement static virtual members

class CustomerTest : ITypeDescribable
{
    public static string Description => "Customer tests";  // Mandatory
    public static string Category => "Unit testing";    // Optional
}

#endregion