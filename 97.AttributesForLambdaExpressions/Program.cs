using System.ComponentModel;
using System.Reflection;

Action<int> a = [Description("Method")]
[return: Description("Return value")]
([Description("Parameter")] int x) => Console.WriteLine(x);

var methodAttr = a.GetMethodInfo().GetCustomAttributes();
var paramAttr = a.GetMethodInfo().GetParameters()[0].GetCustomAttributes();
var returnAttr = a.GetMethodInfo().ReturnParameter.GetCustomAttributes();