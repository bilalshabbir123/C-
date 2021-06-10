using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, result;

            // To find which value is greater
            // Using Conditional Operator
            result = x > y ? x : y;

            // To display the result 
            Console.WriteLine("Result: " + result);

            // To find which value is greater
            // Using Conditional Operator
            result = x < y ? x : y;

            // To display the result
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
