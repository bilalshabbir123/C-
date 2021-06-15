using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     *  **************** ENUM ****************** *
     *  Enum in C# is also known as enumeration.
     *  It is used to store a set of named constants suach as season,days,month
     *  size etc.
     *  The enum constants are also known as enumerators.
     *  Enum in C# can be declared within or outside class and structs.
     *  
     *  Enum contants has default values which starts from 0 and increamented by one ny one.
     *  But we can change the default values.
     *  
     *  Enums are strongly typed constants.
     *  
     *  If a program uses set of itegral numbers, consider replasing tehm with enum.
     *  Otherwise the program becomes less
     *  readable
     *  Maintainable
     *  
     *  In 
     *  Points to remember
     *  *enum has fixed set of constants.
     *  *enum improves type safety.
     *  *enum can be traversed.
    */

    class Program
    {
        public enum Season
        {
            WINTER,SPRING,SUMMER,FALL
        }
        static void Main(string[] args)
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.FALL;
            Console.WriteLine("WINTER={0}",x);
            Console.WriteLine("FALL={0}",x);
 
            Console.ReadLine();
        }
        }
    }
