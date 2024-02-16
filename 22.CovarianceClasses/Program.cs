#region Problem

//// Generic classes are not covariant, to ensure static type safety. Consider the following:

//// The following fails to compile:
//Stack<Bear> bears = new Stack<Bear>();
//Stack<Animal> animals = bears;      // Compile-time error

//// That restriction prevents the possibility of runtime failure with the following code:
//animals.Push(new Camel());          // Trying to add Camel to bears

//class Animal { }
//class Bear : Animal { }
//class Camel : Animal { }

//public class Stack<T>   // A simple Stack implementation
//{
//    int position;
//    T[] data = new T[100];
//    public void Push(T obj) => data[position++] = obj;
//    public T Pop() => data[--position];
//}

#endregion

#region Hindering Reusability

//// Lack of covariance with classes can hinder reusability. 

//Stack<Bear> bears = new Stack<Bear>();
//ZooCleaner.Wash(bears);        // Will not compile!

//class Animal { }
//class Bear : Animal { }
//class Camel : Animal { }

//public class Stack<T>   // A simple Stack implementation
//{
//    int position;
//    T[] data = new T[100];
//    public void Push(T obj) => data[position++] = obj;
//    public T Pop() => data[--position];
//}

//static class ZooCleaner
//{
//    public static void Wash(Stack<Animal> animals) { /*...*/ }
//}

#endregion

#region Workaround

// Lack of covariance with classes can hinder reusability. 

Stack<Bear> bears = new Stack<Bear>();
ZooCleaner.Wash(bears);        // Works!

class Animal { }
class Bear : Animal { }
class Camel : Animal { }

public class Stack<T>   // A simple Stack implementation
{
    int position;
    T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];

}

static class ZooCleaner
{
    public static void Wash<T>(Stack<T> animals) where T : Animal { /*...*/ }
}

#endregion