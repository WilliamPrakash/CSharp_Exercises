using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Exercises.Concepts
{
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
    }

    public class AbstractChildClass : AbstractClass
    {
        public override int Prop2 { get; set; }
        /* Override modifier
        -Required to extend or modify the abstract or virtual implementation
        of an inherited method, property, indexer, or event.
        -An override method provides a new  implementation of the method inherited from a base class.
        -You can't override a non-virtual or static method. The override base method must be virtual,
        abstract, or override. 
        -An override declatation can't change the accessibility of the virtual method. You can't use 
        the new, static, or virtual modifiers to modify an override method. */
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
            //int x = abstractChild.Prop1;
            // CS0176: ...cannot be accessed with an instance reference
            int x = AbstractChildClass.Prop1;
            x = abstractChild.Prop2;
        }
    }


}
