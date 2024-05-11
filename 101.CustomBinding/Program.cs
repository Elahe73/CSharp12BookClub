using System.Dynamic;

// Custom binding occurs when a dynamic object implements IDynamicMetaObjectProvider:


dynamic d = new Duck();
d.Quack();                  // Quack method was called
d.Waddle();                 // Waddle method was called

Console.ReadLine();

public class Duck : System.Dynamic.DynamicObject
{
    public override bool TryInvokeMember(
      InvokeMemberBinder binder, object[] args, out object result)
    {
        Console.WriteLine(binder.Name + " method was called");
        result = null;
        return true;
    }
}