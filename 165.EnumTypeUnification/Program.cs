// See also Enums in Chapter 3

static void Display(Enum value)    // The Enum type unifies all enums
{
    Console.WriteLine(value.GetType().Name + "." + value.ToString());
}

Display(Nut.Macadamia);     // Nut.Macadamia
Display(Size.Large);        // Size.Large

enum Nut { Walnut, Hazelnut, Macadamia }
enum Size { Small, Medium, Large }
