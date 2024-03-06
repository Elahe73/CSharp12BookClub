// When a delegate object is assigned to an instance method, the delegate object must maintain
// a reference not only to the method, but also to the instance to which the method belongs:

MyReporter r = new MyReporter();
r.Prefix = "%Complete: ";
ProgressReporter p = r.ReportProgress;
p(99);                                 // 99
Console.WriteLine(p.Target == r);     // True
Console.WriteLine(p.Method);          // Void InstanceProgress(Int32)
r.Prefix = "";
p(99);                                 // 99

Console.ReadKey();

public delegate void ProgressReporter(int percentComplete);

class MyReporter
{
    public string Prefix = "";
    public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
}