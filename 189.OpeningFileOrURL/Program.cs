using System.Diagnostics;

LaunchFileOrUrl("http://www.albahari.com/nutshell");

void LaunchFileOrUrl(string url)
{
    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
}