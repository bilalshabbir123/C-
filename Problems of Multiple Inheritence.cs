using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    class Program
    { 
    /*
     Class B and Class C inherits from Class A.
    Class D inherits from Both B and C.
    If a method in D call a method defined in A( and does not override the method)
    and B and C have overridden that method differently, then from which class does it inherit: B,C?
     When we create the Instance of class D it does not know which methid is called of class B or Class C
        This ambiguity is called as Diamond Problem.
*/
   class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A Implementation");
            }
        }
        class B: A
        {
            public override void Print()
            {
                Console.WriteLine("B Implementation");
            }
           
        }
        class C:A
        {
            public override void Print()
            {
                Console.WriteLine("C Implementation");
            }

        }
        class D : B, C
        {

        }

        static void Main(string[] args)
            {
            
            Console.ReadLine();
            }
        }
    }
