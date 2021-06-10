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
            int a=10, b;
            //post Increamnet example
            //b is assigned only 10
            //a is not updated yet
            b = a++;
            //a becomes 11
            Console.WriteLine("a is :{0} and b is :{1}",a,b);
            //post decreament example
            //b is assigned 11 only a is not updated yet
            b = a--;
            //a becomes 10
            Console.WriteLine("a is {0} and b is {1}", a, b);
            // pre-increment example:
            // b is assigned 11 now since a
            // is updated here itself
            b= ++a;

            // a and b have same values = 11
            Console.WriteLine("a is {0} and res is {1}", a, b);


            // pre-decrement example:
            // res is assigned 10 only since
            // a is updated here itself
            b = --a;

            // a and res have same values = 10
            Console.WriteLine("a is {0} and res is {1}", a, b);
            Console.ReadLine();
        }
    }
}
