using System;

namespace LearningProgram.Inheritance
{
    public class TypeCasts
    {
        public TypeCasts()
        {
            Console.WriteLine("Check type cast");
            A a = new C();
            B b = (B)a; // if (a is B) stat.type(a) is B in this expression; else exception 
            if (a is B)
            {
                Console.WriteLine("a is B: stat.type(a) is B in this expression; else will give exeption");
            }
            C c = (C)a;
            a = null;
            c = (C)a; // ok Înull can be casted to any reference type
        }

    }
}
