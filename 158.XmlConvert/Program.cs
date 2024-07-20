// XmlConvert honors XML formatting rules:

using System.Xml;

string s = XmlConvert.ToString(true);
Console.WriteLine(s);                  // true (rather than True)
Console.WriteLine(XmlConvert.ToBoolean(s));

DateTime dt = DateTime.Now;
Console.WriteLine(XmlConvert.ToString(dt, XmlDateTimeSerializationMode.Local) + "local");
Console.WriteLine(XmlConvert.ToString(dt, XmlDateTimeSerializationMode.Utc) + "Utc");
Console.WriteLine(XmlConvert.ToString(dt, XmlDateTimeSerializationMode.RoundtripKind) + "RoundtripKind");

Console.WriteLine(XmlConvert.ToString(DateTimeOffset.Now) + "DateTimeOffset");