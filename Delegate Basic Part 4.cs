using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
      * A delegate is a function pointer.
      * Delegate is type safe function pointer.
      * A deleate is a reference type variable that holds the reference to a method.
      * Delegate points to a function when you invoke this delegate function is invoked.
      * The Signature of the delegate should be match of the fucntion, the delegates points to,
      * otherwise you get a compiler error.
      * *This is the reason delegates are called as type safe function pointers.
      * 
      * * A delegate is similar to a class. You can create an instance of it, and when you do so,
      * you pass in the function names as a parametr to the delegate constructor , and it is to this function
      * the delegate will point to.
      * 
      * Tip to remember delegate syntax: Delegates syantx look very much similar to a method with a delegate keyword.

    *Multicast delegate make implemetation of observe design pattern very simple. 
    *Observer Pattern ia also called as publish/subsrive pattern.
    ****************
    *This is simple example without the using of delegate-----------------
    *
    ****************************Multicasting of a Delegate******************
    *Delegate objects can be composed using the "+" operator.
    *A composed delegate calls two delegate it was composed from.
    *Only delegates of the same type can be composed.
    *
    *The "-" operator can be used to remove a component delegate from a composed delegate.
    */


    public delegate int Numbercharge(int n);
    class Program
    {
        static int num = 10;
        public static int Addnum(int p)
        {
            num += p;
            
            return num;
        }
        public static int MultiNum(int q)
        {
            num *= q;
           
            return num;
        }
        public static int getnum()
        {
            return num;
        }
      
        static void Main(string[] args)
            {
            Numbercharge nc;
            Numbercharge nc1 = new Numbercharge(Addnum);
            Numbercharge nc2 = new Numbercharge(MultiNum);
            nc = nc1;
            nc+=nc2;
            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}",getnum());
            Console.ReadLine();
        }
        }
    }
