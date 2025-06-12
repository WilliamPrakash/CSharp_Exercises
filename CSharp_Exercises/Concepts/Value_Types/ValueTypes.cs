using System;
using System.Net.Cache;

namespace CSharp_Exercises.Concepts.Value_Types;

/* Source: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
-C# is a strongly typed language, meaning every variable, constant, and expression that
evaluates to a value has a type. The compiler uses type information to make sure
all operations performed in your code are type safe. The compiler embeds the type
information into the executable file as metadata. The common language runtime (CLR)
uses that metadata to further guarantee type safety when it allocates and reclaims
memory.
-The .NET class library defines built-in numeric types and complex types.
-When you declare a variable or constant in a program, you must specify its type or use
the "var" keyword to let the compiler infer the type.
-C# provides a standard set of built-in types, which for the most part, are just
aliases for the corresponding .NET type. They're interchangeable. I.E.:
int a = 123;
System.Int32 b = 123;
are the same thing.

-Value types derive from System.ValueType, which derives from System.Object.
-Value type variables directly contain their values.
-The memory for a struct is allocated inline in whatever context the variable is
declared.
-There's no separate heap allocation or garbage collection overhead for value-type
variables.
-A value type can be one of the two following kinds:
    1. A structure type, which encapsulates data and related functionality.
    2. An enumeration type, which is defined by a set of named constants and represents
       a choice or a combination of choices.
-Value types are sealed.
-A struct can implement one or more interfaces. You can cast a struct type to any
interface type that it implements, which causes a boxing operation.
-You can use the "struct" keyword to create your own custom value types.
-The other category, enum, is a set of named integral constants. All enums inherit from
System.Enum, which inherits from System.ValueType. */
internal class ValueTypes
{
    // C# built-in value types
    bool trueOrFalse = true; // .NET type: System.Boolean
    byte eightBits = byte.MaxValue; // .NET type: System.Byte
    sbyte signedEightBits = sbyte.MinValue; // .NET type: System.SByte
    char character = 'c'; // .NET type: System.Char
    decimal dec = 1.0m; // .NET type: System.Decimal
    double doub = 2.0d; // .NET type: System.Double
    float fl = 1.23f; // .NET type: System.Single
    int i = -1; // .NET type: System.Int32
    uint ui = 0; // .NET type: System.UInt32
    nint ni = 1; // .NET type: System.IntPtr
    nuint nui = 2; // .NET type: System.UIntPtr
    long lg = -12345; // .NET type: System.Int64
    ulong ulg = 12345; // .NET type: System.UInt64
    short sh = 523; // .NET type: System.Int16
    ushort ush = 205; // .NET type: System.UInt16
    public struct St
    {
        // Fields
        int y;
        int x;
        // Constructor
        public St(int yVal, int xVal)
        {
            y = yVal;
            x = xVal;
        }
        // Methods
        public void DisplayVals()
        {
            Console.WriteLine("x: " + x + " y: " + y);
        }
    }
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
    // Tuples
    (double, int) tup1 = (4.5, 3);
    (decimal, char) tup2 = (80.8m, 'b');
    (string Name, int Age) tup3 = (Name: "Will", Age: 26);
}
