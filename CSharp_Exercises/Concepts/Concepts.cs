using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercises.Concepts;

class Concepts
{
    #region Delegates
    /* Source: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
    A delegate is a type that represents references to methods with a particular
    parameter list and return type. When you instantiate a delegate, you can
    associate the delegate instance with any method that has a compatible signature
    and return type. You can invoke (or call) the method through the delegate
    instance.

    Delegates are used to pass methods as arguments to other methods. Event handlers
    are essentially methods you invoke through delegates. When you create a custom
    method, a class such as a Windows control can call your method when a certain event occurs.
    */
    internal void DemonstrateDelegates()
    {
        DelegateOfActualFunction delegateInstanceOfActualFunction = new DelegateOfActualFunction(ActualFunction);
        delegateInstanceOfActualFunction("Hello from delegate");
        ActualFunction("Hello");
    }
    public delegate void DelegateOfActualFunction(string message);
    public void ActualFunction(string message)
    {
        Console.WriteLine(message);
    }
    #endregion
}
