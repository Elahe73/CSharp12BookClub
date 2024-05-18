// Implicit and explicit conversions are overloadable operators:

Note n = (Note)554.37;  // explicit conversion
double x = n;           // implicit conversion


public struct Note
{
    int value;
    public int SemitonesFromA { get { return value; } }

    public Note(int semitonesFromA) { value = semitonesFromA; }

    // Convert to hertz
    public static implicit operator double(Note x) => 440 * Math.Pow(2, (double)x.value / 12);

    // Convert from hertz (accurate to the nearest semitone)
    public static explicit operator Note(double x) =>
      new Note((int)(0.5 + 12 * (Math.Log(x / 440) / Math.Log(2))));
}