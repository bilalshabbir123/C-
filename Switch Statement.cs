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
            switch (Usernumber)
            {
                //case 10:
                //    Console.WriteLine("Your Number is 10");
                //    break;
                //case 20:
                //    Console.WriteLine("Your Number is 20");
                //    break;
                //case 30:
                //    Console.WriteLine("Your Number is 30");
                //    break;

                //Output is the same
                case 10:
                    
                case 20:
                    
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                case 40:
                    Console.WriteLine("Your Number is 40");
                    break;

                default:
                    Console.WriteLine("Your Number is not 10 20 30 & 40");
                    break;
            }
            Console.ReadLine();
        }
    }
}
