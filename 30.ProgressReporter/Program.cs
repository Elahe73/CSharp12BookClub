ProgressReporter p = WriteProgressToConsole;
p += WriteProgressToFile;
Util.HardWork(p);

void WriteProgressToConsole(int percentComplete)
{
    Console.WriteLine(percentComplete);
}

void WriteProgressToFile(int percentComplete)
{
    System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
}

delegate void ProgressReporter(int percentComplete);

class Util
{
    public static void HardWork(ProgressReporter p)
    {
        for (int i = 0; i < 10; i++)
        {
            p(i * 10);                           // Invoke delegate
            System.Threading.Thread.Sleep(100);  // Simulate hard work
        }
    }
}