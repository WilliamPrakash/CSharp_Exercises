using System;

namespace CSharp_Exercises.Concepts;

/* Source: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
You use the struct, class, interface, enum, and record constructs
to create your own custom types. The .NET class library itself is a
collection of custom types that you can use in your own applications.
By default, the most frequently used types in the class library are
available in any C# program. Others become available only when you
explicitly add a project reference to the assembly that defines them.
After the compiler has a reference to the assembly, you can declare
variables (and constants) of the types declared in taht assembly in
source code.
One of the first decisions you make when defining a type is deciding
which construct to use for your type. The following list helps make
that initial decision. There's overlap in the choices. In most
scenarios, more than one option is a reasonable choice:
    If the data storage size is small, no more than 64 bytes, choose a struct or record struct.
    If the type is immutable, or you want nondestructive mutation, choose a struct or record struct.
    If your type should have value semantics for equality, choose a record class or record struct.
    If the type is primarily used for storing data, not behavior, choose a record class or record struct.
    If the type is part of an inheritance hierarchy, choose a record class or a class.
    If the type uses polymorphism, choose a class.
    If the primary purpose is behavior, choose a class. */

// Value types
/* Struct
Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct
-A structure type (struct) is a value type that can encapsulate data and
related functionality.
-Typically, you use structure types to design small data-centric types
that provide little or no behavior.
-Modifiers that can be used with a struct: readonly, ref, record. */
public struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}
/* Enum
Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
-An enumeration type (or enum type) is a value type defined by a set of
named constants of the underlying integral numeric type.
-By default, the associated constant values of enum members are of type
int. They start with zero and increase following the definition text
order. You can explicitly specify any other integral numeric type as an
underlying type of an enumeration type. You can also explicitly specify
the associated constant values.
-You cannot define a method inside the definition of an enumeration type.
To add functionality, create an extension method.
-System.Enum type is the abstract base class of all enumeration types. */
enum RomanToInt
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000
}

// Reference types
