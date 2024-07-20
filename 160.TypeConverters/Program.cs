// Type converters are designed to format and parse in design-time environments.

using System.ComponentModel;
using System.Drawing;

TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));

Color beige = (Color)cc.ConvertFromString("Beige");
Color purple = (Color)cc.ConvertFromString("#800080");
Color window = (Color)cc.ConvertFromString("Window");

Console.WriteLine(beige);
Console.WriteLine(purple);
Console.WriteLine(window);