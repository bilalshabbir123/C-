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
            Console.WriteLine("Please Enter a Number:");
            int Usernumber = int.Parse(Console.ReadLine());
            if (Usernumber==10)
            {
                Console.WriteLine("Your Number is 10");
            }
            else if (Usernumber==20)
            {
                Console.WriteLine("Your Number is 20");
            }
            else if (Usernumber==30)
            {
                Console.WriteLine("Your Number is 30");
            }
            else
            {
                Console.WriteLine("Your Number is Not 10 20 and 30");
            }
            Console.ReadLine();
        }
    }
}
