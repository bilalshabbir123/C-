using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        //In method declaration values are called method parameters are parameters
        //but when we invoke the method values are called arguments or method arguments arguments for the parameters
        //params keyword is used to specify a method parameter that takes a variable number of arguments. separated by comma
        //params keyword should be the last one in a method declaration only one params keyword is permitted in a method declaration
        //when we use params it use array argument as an option other whise gave an error like methoed overloading
        //if we donnot pass array as ana argument then it gives output like 0 elemts mena output is 0
        public static void Array(params int[]Numbers)
            {
            Console.WriteLine("Total Elemnts in Array are {0}",Numbers.Length);
            Console.WriteLine("Elements in Array");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        

        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 10;
            Numbers[1] = 20;
            Numbers[2] = 30;

            // WeakReference can pass alos like this 
            // Array(1, 2, 3, 4, 5);
            Array(Numbers);
            Console.ReadLine();
        }
    }
}
