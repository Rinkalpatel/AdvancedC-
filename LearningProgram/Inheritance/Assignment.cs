using System;

namespace LearningProgram.Inheritance
{
    class A
    {
        //base class 
        int a;
        public A()
        {

        }
        public void F()
        {

        }
    }
    class B : A
    {
        //subclass(inherits from A, extends A) 
        //B inherits aand F(), it adds band G() 

        //-----constructors are not inherited -----/ /

        //class can only inherit from a class, not from a struct
        int b;

        public B()
        {

        }

        public void G()
        {

        }
    }

    class C : B
    {

    }

    class TypeCheck
    {
        public TypeCheck()
        {

            //check assignment

            // static typeof a: the type specified in the declaration (here A) 
            // dynamic typeof a: the type of the object in a(here also A) 
            A a = new A();
            // dynamic type of ais B 
            a = new B();
            // dynamic type of ais C
            a = new C();

            // forbidden; compilation error 
            // B b = a;

            //runtime check 
            a = new C();

             
            if (a is C) // true, if dynamic type of ais C or a subclass; otherwise false
            { 
                Console.WriteLine("a is c");
            }
            if (a is B) // true 
            {
                Console.WriteLine("a is b");
            }
            if (a is A) // true, but warning because it makes no sense
            {
                Console.WriteLine("a is A");
            }
                a = null;
            if (a is C) // false: if a== null, a is always returns false
            {
                Console.WriteLine("a is c");
            }
        }
    }
}