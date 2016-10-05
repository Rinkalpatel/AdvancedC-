using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProgram.Inheritance
{
    class OA
    {
        
        public void F()
        {
            // cannot be overridden 
            Console.WriteLine("F of OA");
        }


        public virtual void G()
        {
            // can be overridden in a subclass    
            Console.WriteLine("G of OA");
        }
        public virtual void H()
        {
            // can be overridden in a subclass    
            Console.WriteLine("H of OA");
        }

    }

    class OB : OA
    {
        public void F()
        {
            // warning: hides inherited F() usenew 
            Console.WriteLine("F of OB");

        }

        public void G()
        {
            // warning: hides inherited G() usenew   
            Console.WriteLine("G of OB");
        }
        public override void H()
        {
            // ok: overrides inherited G ... 
            //base.G();// calls inherited G() 
            Console.WriteLine("H of Ob is over riding OA");
        }
    }

    public class OverRideClass
    {
        public OverRideClass()
        {
            var f = new OB();
            f.F();
            f.G();
            f.H();
        }
    }
}