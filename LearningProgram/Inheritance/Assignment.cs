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
    class B : A    {
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

    class C:B
    {
        
    }
}