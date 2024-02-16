
using System.Text;

#region Problem

//StringBuilder Foo<T>(T arg)
//{
//    if (arg is StringBuilder)
//        return (StringBuilder)arg;   // Will not compile: Cannot convert T to StringBuilder

//    /*...*/
//    return null;
//}

#endregion

#region Solution1

//StringBuilder Foo<T>(T arg)
//{
//    StringBuilder sb = arg as StringBuilder;
//    if (sb != null) return sb;
//    return sb;
//}

#endregion


#region Solution2

// A more general solution is to first cast to object:

//StringBuilder Foo<T>(T arg)
//{
//    if (arg is StringBuilder)
//        return (StringBuilder)(object)arg;

//    /*...*/
//    return null;
//}

#endregion