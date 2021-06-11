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
            //declares a 1D Array of string
            string[] Weekdays;
            //allocating memory for days
            Weekdays=new string[]{ "Monday","Thuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
            //displaying the Elements of Array
            foreach (string day in Weekdays)
            {
                Console.WriteLine(day);
            }


            Console.ReadLine();
        }
    }
}
