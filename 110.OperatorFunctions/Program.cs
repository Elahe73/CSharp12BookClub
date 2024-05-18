// From C# 11, when you declare an operator function, you can also declare a checked version.
// The checked version will be called inside checked expressions or blocks.

Note B = new Note(2);
Note other = (B + 2);  
Note other2 = (B + int.MaxValue);  
Note other3 = checked(B + int.MaxValue);  // throws OverflowException

public struct Note
{
    int value;
    public int SemitonesFromA => value;

    public Note(int semitonesFromA) { value = semitonesFromA; }

    public static Note operator +(Note x, int semitones)
      => new Note(x.value + semitones);

    public static Note operator checked +(Note x, int semitones)
      => checked(new Note(x.value + semitones));
}