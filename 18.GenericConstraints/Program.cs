#region Example1

/* Constraints can be applied to a type parameter restrict the type arguments.

where T : base-class   // Base class constraint
where T : interface    // Interface constraint
where T : class        // Reference-type constraint
where T : struct       // Value-type constraint (excludes Nullable types)
where T : new()        // Parameterless constructor constraint
where U : T            // Naked type constraint

*/

//using System.Text;

//int z = Max(5, 10);               // 10
//string last = Max("ant", "zoo");  // zoo

//Console.ReadKey();

//T Max<T>(T a, T b) where T : IComparable<T>  // Self-referencing interface constraint
//{
//    return a.CompareTo(b) > 0 ? a : b;
//}

//class SomeClass { }
//interface Interface1 { }

//class GenericClass<T> where T : SomeClass, Interface1 { }  // Class & interface constraint

#endregion

#region Example2

// The parameterless constructor constraint requires T to have a public parameterless constructor.
// If this constraint is defined, you can call new() on T:

//using System.Text;

//var builders = new StringBuilder[100];
//Initialize(builders);
//var temp = builders[37];

//Console.ReadKey();

//static void Initialize<T>(T[] array) where T : new()
//{
//    for (int i = 0; i < array.Length; i++)
//        array[i] = new T();
//}

#endregion


#region Example3

// The naked type constraint requires one type parameter to derive from another type parameter:

//class Stack<T>
//{
//    Stack<U> FilteredStack<U>() where U : T
//    {
//        /* ... */
//        return default(Stack<U>);
//    }
//}

#endregion