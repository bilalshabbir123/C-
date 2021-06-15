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
         * DElegate Meaning From Google
         * A Person sent or authorize to repreasent to others, in particular an elected 
         repreasentative sent to a conefrence.
         *Delegate is a type which holds a method's reference in an object.
         *It is aslo called function pointer.
         *Delegate is reference type.
         *Delegate signature should be as asame as the method signature referencing by a Delegate.
         *Delegate can point to a parameterized method or non-parameterized method.
         *Delegates has no implementation means no body with{}.
         *We can use invoke() method with delegates.
         *Delegates are used to encapsulate methods.
         *In the .NET framework, a delegate points to one or more methods.
         *Once you instantiate the delegate, the corressponding methods invoke.
         *Delegates are objects that contain references to methods that need to be invoked instead of containing
         the actual method names.
        *Using delegate, you can call any method, which is defined only at RUN-TIME.
        *A delegate is like having a general method name that points to various methods 
        at different times and invokes the required method at run time.
        In c#invoking a delegate will execute the reference method at run-time.
        *By using the Delegates the performance of application is increases.

     */
        public delegate void Calculation(int a, int b);
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is: {0}", result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is: {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is: {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is: {0}", result);
        }

        static void Main(string[] args)
            {
            Calculation obj = new Calculation(Myprogram.Addition);
            obj.Invoke(20, 10);
            Myprogram.Addition(30, 20);
            Calculation obj1 = new Calculation(Myprogram.Subtraction);
            obj1.Invoke(40, 20);
            obj = Multiplication;
            obj(20, 30);
           // obj = Subtraction;
            Console.ReadLine();
            }
        }
    }
