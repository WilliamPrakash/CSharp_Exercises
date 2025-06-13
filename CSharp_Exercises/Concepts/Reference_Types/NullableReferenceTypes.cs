using System;

namespace CSharp_Exercises.Concepts.Reference_Types;

/* Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types
Source:https://www.youtube.com/watch?v=bXsOOpWavp4
-Nullable reference types are available in code that's in a nullable aware context.
Nullable reference types, the null static analysis warnings, and the null-forgiving
operator are optional language features. All are turned off by default. A nullable
context is controlled at the project level using build settings, or in code using
pragmas.
<PropertyGroup>
    <Nullable>enable</Nullable>
</PropertyGroup>
-In a nullable aware context:
    1. A variable of a reference type T must be initialized with non-null, and can
    never be assigned a value that might be null.
    2. A variable of a reference type T? can be initialized with null or assigned
    null, but is required to be checked against null before dereferencing.
    3. A variable m of type T? is considered to be non-null when you apply the null-
    forgiving operator, as in m!.
-The compiler enforces the distinctions between a non-nullable reference type T and
a nullable reference type T? using the preceding rules.
-A variable of type T and a variable of type T? are the same .NET type.

*/
public class NullableReferenceTypes
{

    public NullableReferenceTypes()
    {
        string notNull = "String";
        string? nullable = default;
        notNull = nullable!;
        Console.WriteLine(notNull);
    }
}

public class SurveyQuestion
{
    public string QuestionText { get; }
    public string? QuestionHint { get; set; }
    public int QuestionNumber { get; }

    /* Without this constructor, the QuestionText field gives us a CS8618 warning:
    NonNullable property QuestionText must contain a non-null value when exiting
    constructor */
    public SurveyQuestion(int number, string text) =>
        (QuestionNumber, QuestionText) = (number, text);
}
