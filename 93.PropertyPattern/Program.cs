// Property pattern with is operator
{
    object obj = "test";

    if (obj is string { Length: 4 })
        Console.WriteLine("string with length of 4");
}
// Property pattern with switch
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Scheme: "http", Port: 80 } => true,
        { Scheme: "https", Port: 443 } => true,
        { Scheme: "ftp", Port: 21 } => true,
        { IsLoopback: true } => true,
        _ => false
    };
}
// Property pattern with switch - nested
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Scheme: { Length: 4 }, Port: 80 } => true,
        _ => false
    };
}
// Property pattern with switch - nested simplified
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Scheme.Length: 4, Port: 80 } => true,   // Simplified syntax (from C# 10)
        _ => false
    };
}
// Property pattern with relational pattern
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Host: { Length: < 1000 }, Port: > 0 } => true,
        _ => false
    };
}
// Property pattern with switch - with when clause
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Scheme: "http" } when string.IsNullOrWhiteSpace(uri.Query) => true,
        _ => false
    };
}
// Property pattern with type pattern
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(object uri) => uri switch
    {
        Uri { Scheme: "http", Port: 80 } httpUri => httpUri.Host.Length < 1000,
        Uri { Scheme: "https", Port: 443 } => true,
        Uri { Scheme: "ftp", Port: 21 } => true,
        Uri { IsLoopback: true } => true,
        _ => false
    };
}
// Property pattern with type pattern and when
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(object uri) => uri switch
    {
        Uri { Scheme: "http", Port: 80 } httpUri
                                           when httpUri.Host.Length < 1000 => true,
        Uri { Scheme: "https", Port: 443 } => true,
        Uri { Scheme: "ftp", Port: 21 } => true,
        Uri { IsLoopback: true } => true,
        _ => false
    };
}
// Property pattern with property variable
{
    Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
    Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
    Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

    bool ShouldAllow(Uri uri) => uri switch
    {
        { Scheme: "http", Port: 80, Host: var host } => host.Length < 1000,
        { Scheme: "https", Port: 443 } => true,
        { Scheme: "ftp", Port: 21 } => true,
        { IsLoopback: true } => true,
        _ => false
    };
}

Console.ReadLine();