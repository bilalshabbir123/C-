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
            bool result;
            int x = 5, y = 10;

            // Equal to Operator
            result = (x == y);
            Console.WriteLine("Equal to Operator: " + result);

            // Greater than Operator
            result = (x > y);
            Console.WriteLine("Greater than Operator: " + result);

            // Less than Operator
            result = (x < y);
            Console.WriteLine("Less than Operator: " + result);

            // Greater than Equal to Operator
            result = (x >= y);
            Console.WriteLine("Greater than or Equal to: " + result);

            // Less than Equal to Operator
            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result);

            // Not Equal To Operator
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
            Console.ReadLine();
        }
    }
}
