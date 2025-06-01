using System;

namespace CSharp_Exercises.Concepts;

/* Source: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
-C# is a strongly typed language, meaning every variable, constant, and expression
that evaluates to a value has a type. The compiler uses type information to make
sure all operations performed in your code are type safe. The compiler embeds the
type information into the executable file as metadata. The common language runtime
(CLR) uses that metadata to further guarantee type safety when it allocates and
reclaims memory.
-The .NET class library defines built-in numeric types and complex types.
-When you declare a variable or constant in a program, you must specify its type or
use the "var" keyword to let the compiler infer the type.
-C# provides a standard set of built-in types, which for the most part, are just
aliases for the corresponding .NET type. They're interchangeable.

-A type that is defined as a class, record, delegate, array, or interface is a reference
type.
-When you declare a variable of a reference type, it contains the value null until you
assign it with an instance of that type or create one using the "new" operator.
-An interface can't be directly instantiated using the new operator. Instead, create
and assign an instance of a class that implements the interface.
-When the object is created, the memory is allocated on the managed heap. The variable
holds only a reference to the location of the object.
-Types on the managed heap require overhead both when they're allocated and when they're
reclaimed.
-Garbage collection is the automatic memory management functionality of the CLR, which
performs the reclamation.
-All arrays are reference types, even if their elements are value types.
-Reference types fully support inheritance. */
internal class ReferenceTypes
{
    // C# built-in and custom reference types
    Object obj = new object(); // .NET type: System.Object
    // "string" is an alias for the String class
    String str = ""; // .NET type: System.String
    /* The delegate keyword declares a type derived from System.Delegate.
    System.Delegate is an abstract type. */
    Delegate? Delegate { get; set; } // .NET type: System.Delegate
    /* The dynamic type is similar to object. The main differences are:
    -Operations on a dynamic expression are bound at runtime, not compile time.
    -You can't use "new dynamic()".
    -You can't derive a type from the dynamic type. */
    dynamic? dynamic { get; set; } // .NET type: System.Object
    int[] intArr = new int[1]; // .NET type: System.Array
    /* An interface can't be directly instantiated using the new operator. Instead,
    create and assign an instance of a class that implements the interface. Consider
    the following example: */
    RefClass rc = new RefClass();
    record Person(string FirstName, string LastName);
}

public class RefClass : IRefClass
{

}
interface IRefClass
{

}
