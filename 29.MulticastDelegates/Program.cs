// All delegate instances have multicast capability:

SomeDelegate d = SomeMethod1;
d += SomeMethod2;

d();
//SomeMethod1 and SomeMethod2 both fired

d -= SomeMethod1;
d();
//Only SomeMethod2 fired

Console.ReadKey();

void SomeMethod1() => Console.WriteLine("SomeMethod1");
void SomeMethod2() => Console.WriteLine("SomeMethod2");

delegate void SomeDelegate();