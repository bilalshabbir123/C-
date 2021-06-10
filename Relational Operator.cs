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
            bool a = true, b = false, result;

            // AND operator //both condition True then conditon true
            result = a && b;
            Console.WriteLine("AND Operator: " + result);

            // OR operator //any one condition is true output is true
            result = a || b;
            Console.WriteLine("OR Operator: " + result);

            // NOT operator change the input
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
            Console.ReadLine();
        }
    }
}
