using System;

namespace CSharp_Exercises.Concepts.Value_Types;

/* Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
-A nullable value type T? represents all values of its underlying value type T and an
additional null value. I.E. bool? can be true, false, or null.
-Any nullable value type is an instance of the generic System.Nullable<T> structure.
You can refer to a nullable value type with an underlying type T by either
Nullable<T> or T?.
-You typically use a nullable value type when you need to represent the undefined
value of an underlying value type.
-As a value type is implicitly convertible to the corresponding nullable value type,
you can assign a value to a variable of a nullable value type as you would do that for
its underlying value type. You can also assign the null value.
-Nullable<T>.HasValue returns either true or false
-Nullable<T>.Value gets the value of an underlying type if HasValue is true. Otherwise
it throws an InvalidOperationException.
-You can use the is operator with a type pattern to both examine an instance of a 
nullable value type for null and retrieve a value of an underlying type
-If you want to assign a value of a nullable value type to a non-nullable value type
variable, you might need to specify the value to be assigned in place of null. Use the
null-coalescing operator ?? to do that. You can also use 
Nullable<T>.GetValueOrDefault(T) to do the same thing.
-The null-coalescing assignment operator ??= assigns the value of its right-hand
operand to its left-hand operand only if the left-hand operand evaluates to null.

*/
internal class NullableValueTypes
{
    double? pi = 3.14;
    public NullableValueTypes()
    {
        if (pi.HasValue == true)
        {
            Console.WriteLine("pi has a value");
        }

        int? a = 1;
        if (a is int valueOfA)
        {
            Console.WriteLine($"a is {valueOfA}");
        }

        a = null;
        Console.WriteLine(a ?? 3);
        int b = 2;
        b = a ?? 4;
        Console.WriteLine(b);
        Console.WriteLine(a);

        //a = 8;
        int? c = 9;
        a ??= c;
        Console.WriteLine(a);
    }
}
