using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    public delegate void Hellofunctiondelegate(string message);
    class Program
    {
        /*
       * A delegate is a function pointer.
       * Delegate is type safe function pointer.
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

     */
     
        public static void Hello(string strmessage)
        {
            Console.WriteLine(strmessage);
        }
        static void Main(string[] args)
            {
            Hellofunctiondelegate obj = new Hellofunctiondelegate(Hello);
            obj("Hello From Delegate");
            Console.ReadLine();
            }
        }
    }
