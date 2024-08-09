// Here's how we can use object.Equals:
object x = 3, y = 3;
Console.WriteLine(object.Equals(x, y));   // True
x = null;
Console.WriteLine(object.Equals(x, y));   // False
y = null;
Console.WriteLine(object.Equals(x, y));   // True

class Test<T>
{
    T _value;
    public void SetValue(T newValue)
    {
        if (!object.Equals(newValue, _value))
        {
            _value = newValue;
            OnValueChanged();
        }
    }

    protected virtual void OnValueChanged() { /*...*/ }
}