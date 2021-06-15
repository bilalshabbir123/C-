using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * An exception is an unforeseen error occurs when a program is running.
     * 
     * Examples:
     * Trying to read from a file that does not exist, throws File notFoundException.
     * Trying to read froma database table that does not exist, throws a sqlException.
     * 
     * Showing actual unhandled exceptions to the end user is bad for two reasons.
     * 
     * 1. Users will be annoyed as they are cryptic and does not make much sence to the end users.
     * 2. Exceptions contain information, that can be used for hacking into your application.
     * 
     * An exceptionis actuallly a class that drives from system.Exception class.
     * The System.Exception class has several useful properties. that provide valueable information about the exception.
     * 
     * Message: Gets a message that describes the current 
     * Stack Trace: Provides the call stack to the line number in the method where the exception occured.
     * 
*/
    class Program
    {
       
      
        static void Main(string[] args)
            {
            try
            {
                StreamReader strread = new StreamReader(@"F:\Complete path.txt");
                Console.WriteLine(strread.ReadToEnd());
                strread.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please Check If the file {0} exists ",ex.FileName);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
            }
           
            Console.ReadLine();
        }
        }
    }
