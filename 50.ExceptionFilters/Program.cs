using System.Net;

try
{
    await new HttpClient().GetStringAsync("http://www.albahari.com/x");
}
catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine("Page not found");
}
catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.InternalServerError)
{
    Console.WriteLine("Internal server error!");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Some other failure: {ex.StatusCode}");
}

Console.ReadKey();