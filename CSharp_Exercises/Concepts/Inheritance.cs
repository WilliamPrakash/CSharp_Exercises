using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Exercises.Concepts;


/* Abstract modifier
-Indicates that the thing being modified has a missing or incomplete implementation.
-Can be used w/ classes, methods, properties, indexers, and events.
-Members marked as abstract must be implemented by non-abstract classes that derive from
the abstract class.
-Can't be instantiated.
-Doesn't support multiple inheritance. */
public abstract class AbstractClass
{
    //public static abstract int Prop1 { get; set; }
    // CS0112: An static member cannot be marked as 'abstract'
    public static int Prop1 { get; set; }

    public abstract int Prop2 { get; set; }

    //public void Function1();
    /* CS0501: 'AbstractClass.Function1() must declare a body because it is not marked abstract,
    extern, or partial */
    public void Function1()
    {
        Console.WriteLine("Concrete method in an abstract class");
    }

    //public abstract void Function2() { }
    // CS0500 Concepts.AbstractClass.Function2() cannot declare a body because it is marked abstract
    public abstract void Function2();

    //private abstract void Function3();
    // CS0621 Concepts.AbstractClass.Function3() virtual or abstract members cannot be private
    public abstract void Function3();

    //public virtual void Function4();
    /* CS0501: 'AbstractClass.Function4() must declare a body because it is not marked abstract,
    extern, or partial */
    public virtual void Function4()
    {
        Console.WriteLine("Virtual method with default implementation (required).");
    }
}

/* Virtual modifier
-The virtual keyword is used to modify a method, property, indexer, or event declaration and allow
for it to be overridden in a derived class.
-Virtual methods have an implementation and provide derived classes with the option of overriding it. */

/* Override modifier
-The override modifier is required to extend or modify the abstract or virtual implementation of an
inherited method, property, indexer, or event.
-An override method provides a new implementation of the method inherited from a base class.
-An override method must have the same signature as the overridden base method.
-You can't override a non-virtual or static method. The overridden base method must be virtual,
abstract, or override.
-An override declaration cannot change the accessibility of the virtual method. Both the virtual and 
override method must have the same access level modifier.
-You cannot use the new, static, or virtual modifiers to modify an override method. */

public class AbstractChildClass : AbstractClass
{
    public override int Prop2 { get; set; }

    public override void Function2()
    {
        Console.WriteLine("Hello from overridden Function2");
    }

    public override void Function3()
    {
        Console.WriteLine("Hello from overridden Function3");
    }
}

public class DemonstrateAbstractClasses
{
    DemonstrateAbstractClasses()
    {
        // Abstract classes
        AbstractChildClass abstractChild = new AbstractChildClass();
        abstractChild.Function1();
        abstractChild.Function2();
        abstractChild.Function3();
        abstractChild.Function4();
        //int x = abstractChild.Prop1;
        // CS0176: ...cannot be accessed with an instance reference
        int x = AbstractChildClass.Prop1;
        x = abstractChild.Prop2;
    }
}

/* Interface
-An interface defines a contract. Any class, record, or struct that implements that contract
must provide an implementation of the members defined in the interface that don't have default
implementation.
-An interface may define a default implementation for members.
-It may also define static members in order to provide a single implementation for a common
functionality.
-Beginning with C# 11, an interface may define "static abstract" or "static virtual" members to
declare that an implementation type must provide the declared members.
-Typically, static virtual methods declare that an implementation must define a set of overloaded
operators.
-A top-level interface, one declared in a namespace, but not nested inside another type, can be
declared public or internal.
-Default is internal.
Nester interface declatation, those declared inside another time, can be declared using any access
modifier.
-An interface can be a member of a namespace or a class. An interface declaration can contain
declarations (signatures without implementations) of the following members: methods, properties,
indexers, events.
-These preceding member declarations typically don't contain a body. An interface member may declare
a body. Member bodies in an interface are the default implementation. Members with bodies permit the
interface to provide a "default" implementation for classes and structs that don't provide an
overriding implementation.
-Adding default interfaces members forces any ref struct that implements the interface to add an
explicit declaration of that member.
-Interfaces may not contain instance state.
-An interface can inherit from one or more interfaces.
-When an interface inherits from another interface, a type implementing, the derived interface must
implement all the members in the base interfaces as well as those declared in the derived interface.
-When an interface overrides a method implemented in a base interface, it must use the explicit
interface implementation syntax.
-When a base type list contains a base class and interfaces, the base class must come first in the
list.
-A class that implements an interface can explicitly implement members of that interface. An
explicitly implemented member can't be accessed through a class instance, but only through an instance
of the interface. In addition, default interface members can only be accessed through an instance of
the interface.
*/

public interface Interface1
{
    int Prop1 { get; set; }
    // Don't need to be implemented cause they have default implementation?
    // Violates the Liskov Substitution Principle (SOLID)
    public static void Function1()
    {
        Console.WriteLine("Hello from Function1");

    }
    public void Function2()
    {
        Console.WriteLine("Hello from function2");
    }

    public abstract void Function3();
}

public class DemonstrateInterfaces : Interface1
{
    //int Prop1 { get; set; }
    /* CS0737: DemonstrateInterfaces does not implement interface member 
    Interface1.Prop1 . 'DemonstrateInterfaces.Prop1 cannot implement an
    interface member because it is not marked public */
    public int Prop1 { get; set; }

    // why is the "override" modifier not necessary here?
    public void Function3()
    {
        Console.WriteLine("Hello from Function3");
    }
}