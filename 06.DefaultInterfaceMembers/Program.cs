var logger = new Logger();

// We can't call the Log method directly:
// foo.Log ("message")   // Won't compile

// But we can call it via the interface:
((ILogger)logger).Log("message");

Console.ReadKey();

interface ILogger
{
    void Log(string text) => Console.WriteLine(text);
}

class Logger : ILogger
{
    // We don't need to implement anything
}