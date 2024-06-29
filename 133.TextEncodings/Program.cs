using System.Text;

Console.WriteLine(Encoding.UTF8);

// Call Encoding.GetEncoding with a standard IANA name to obtain an encoding:
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Encoding chinese = Encoding.GetEncoding("GB18030");
Console.WriteLine(chinese);

// The static GetEncodings method returns a list of all supported encodings:
foreach (EncodingInfo info in Encoding.GetEncodings())
    Console.WriteLine(info.Name);

Console.ReadLine();