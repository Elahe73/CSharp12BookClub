using System.Diagnostics;

ProcessStartInfo psi = new ProcessStartInfo
{
    FileName = "cmd.exe",
    Arguments = "/c ipconfig /all",
    RedirectStandardOutput = true,
    UseShellExecute = false
};
Process p = Process.Start(psi);
string result = p.StandardOutput.ReadToEnd();
Console.WriteLine(result);