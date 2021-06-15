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
    * If a program uses set of integral numbers, consider replacing them with enaums,
    -which makes the program more readable
    -maintainable

    1.Enums are enumerations
    
    2. Enums are strongle typed constants. Hence, an explicit cast is needed to 
    convert from enum type to an integral type and vice versa.
    Also, an enum of one type cannot be implicitly assigned to an enum of another type
    even though the underlying value of their members are the same.

    3. The default underlying type of an enum is int.
    
    4.The default value for first element is ZERO and gets increamented by 1.

    5.It is possible to customize the underlying type and values.

    6.Enums are value types.

    7. Enum keyword (all small Letters) is used to create enumerations,
    where as Enum class, contains static GetValues() and GetNames() which can be used
    to list Enum underlying type values and names.
    */

    class Program
    {
        public enum Gender:short
        {
            unknown=10,Male=44,Female=99
        }
          
        
        static void Main(string[] args)
        {
            short[] Values=(short[])Enum.GetValues(typeof(Gender));
            foreach  (short values in Values)
            {
                Console.WriteLine(values);
            }
            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (string names in Names)
            {
                Console.WriteLine(names);
            }

            Console.ReadLine();
        }
        }
    }

