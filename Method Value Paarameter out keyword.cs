using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        public static void Methods(int i,int j,out int add,out int subtract,out int multiply,out int division,out int remainder)
            {
            add = i + j;
            subtract = i + j;
            multiply = i - j;
            division = i * j;
            remainder = i / j;
            }
        static void Main(string[] args)
        {
            int ad, sub, mul, div, rem = 0;
            Methods(20,10,out ad,out sub,out mul,out div,out rem);
            Console.WriteLine("Addition={0}\nSubtraction={1}\nMultiplication={2}\nDivision={3}\nRemainder={4}",ad,sub,mul,div,rem);
            Console.WriteLine("Addition={0}"+", "+"Subtraction={1}"+", "+"Multiplication={2}"+", "+"Division={3}"+"and "+"Remainder={4}",ad,sub,mul,div,rem);
            Console.ReadLine();
        }
    }
}
