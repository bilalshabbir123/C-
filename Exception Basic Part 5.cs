using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * *******************Exception Class***************** *
    
     * At a time only one exception is occurred and at a time only one catch block is executed.
     * 
     * All catch blocks must be ordered from most specific to most general.
     
    *C# finally block is always executed whether exception is occurs ot not.
    *C# finally block is always executed whether exception is handled or not.
    *C# finally block is a block that is used to execute important code such as closing connection,stream etc.
    *C# finally block follows try or catch block.
    Note.
    If you donnit handle exception, before terminating the program, 
    C# executes finally block.
    Finally block of C# can be used to put "Cleanup" code such as as closing a file,
    closing connections etc.
    Rule: 
    For each try block tehre can be zero or more catch blocks, 
    but only one finally block.

    For creating exception we use a keyword known as throw...
    */

    class Program
    {
 
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a Number: ");
                string number = Console.ReadLine();
                int num = int.Parse(number);
                Console.WriteLine("Number is: " + num);

                //int a = 10;
                //int b = 0;
                //int c = a / b;

                //string a = null;
                //Console.WriteLine(a.Length);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally Block is Executed !!");
            }




            Console.ReadLine();
        }
        }
    }
