#region Example1

// Type parameters marked with the in modifier indicate contravariance:
IPushable<Animal> animals = new Stack<Animal>();
IPushable<Bear> bears = animals;    // Legal
bears.Push(new Bear());

public interface IPoppable<out T> { T Pop(); }
public interface IPushable<in T> { void Push(T obj); }

class Animal { }
class Bear : Animal { }
class Camel : Animal { }

// Note that Stack<T> can implement both IPoppable<T> and IPushable<T>:
public class Stack<T> : IPoppable<T>, IPushable<T>
{
    int position;
    T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];
}

#endregion

#region Example2

///* The following interface is defined as part of the .NET Framework:

//public interface IComparer<in T>
//{
//  // Returns a value indicating the relative ordering of a and b
//  int Compare (T a, T b);
//}

//*/

//var objectComparer = Comparer<object>.Default;
//IComparer<string> stringComparer = objectComparer;
//int result = stringComparer.Compare("Brett", "Jemaine");

#endregion