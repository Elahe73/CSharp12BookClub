// The true and false operators are overloaded in the extremely rare case of types that
// are boolean “in spirit”, but do not have a conversion to bool.

// An example is the System.Data.SqlTypes.SqlBoolean type which is defined as follows:

SqlBoolean a = SqlBoolean.Null;
if (a)
    Console.WriteLine("True");
else if (!a)
    Console.WriteLine("False");
else
    Console.WriteLine("Null");

public struct SqlBoolean
{
    public static bool operator true(SqlBoolean x) => x.m_value == True.m_value;

    public static bool operator false(SqlBoolean x) => x.m_value == False.m_value;

    public static SqlBoolean operator !(SqlBoolean x)
    {
        if (x.m_value == Null.m_value) return Null;
        if (x.m_value == False.m_value) return True;
        return False;
    }

    public static readonly SqlBoolean Null = new SqlBoolean(0);
    public static readonly SqlBoolean False = new SqlBoolean(1);
    public static readonly SqlBoolean True = new SqlBoolean(2);

    SqlBoolean(byte value) { m_value = value; }
    byte m_value;
}