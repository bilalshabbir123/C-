using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * *********************Exception******************* *
     * An exception is an event, which occurs during the execution of a program that disrupts
       the normal floaw of the program's intructions.
    * In general, when a C# code encounters a situation that it cannot cope with, it raises an exception.
    * An exception is a C# object that repreasent an error.
    * When a C# code raises an exception, it must either handle the exception
      immediately otherwise it terminates and quits.

    When an exception occur 3 things happen..
    -Program terminates or program cashes.
    -Ugly kind of error message is displayed that used can never understand.
    -Stements after exception will not be executed

    -Exceptions are abnormal events that present a certain task fron being completed successfuly.
    -An exception is a problem that arises during the execution of a problem.
    - A C# exception is a  response to an exceptional circumstances that arises while a program is running,
    such as an attemp to divide by zero.

     * *********************Exception   Handling******************* *
     * The exception handling in C# is one of the powerful mechanism to handle the runtime errors
     * so that normal flow of the application can ne maintained.
    */




    class Program
    {
     
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division result is :{0}",+result);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("You cannot divide a number by zero...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
               
            }

            Console.ReadLine();
        }
        }
    }
