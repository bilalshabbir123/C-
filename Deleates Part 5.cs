using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
    In c# a user can invoke multiple delegates within a single program.
    Depending on the delegate name or the type of parameters passes
    to the delegate, the appropriate delegate is invoked.

    Single cast delegate point to a single method at a time.
    In this the delegae is assigned to a single method at a time.
    They are derived from System.Delegate class.
    ******************
    *Multicast Delegate
    When a delegate is wrapped with more than one method that is known as a multicast delegate.
    *In C#, delegates are multicast, which means that they can point to more than one 
    function at atime. They are derived from System.MukticastDelegate class.

    We can use+= and -=assigment operators to implement multi cast delegate

*/
    public delegate void Calculation(int num1, int num2);
    class Program
    {
       public static void Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition is :{0} ",result);
        }public static void Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Suntraction is :{0} ", result);
        }
        public static void Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication is :{0} ", result);
        }
      
        static void Main(string[] args)
        {
            Calculation Cal = new Calculation(Addition);
           
            Cal += Subtraction;
            Cal -= Multiplication;
            Cal(50, 20);
            Console.ReadLine();
        }
        }
    }
