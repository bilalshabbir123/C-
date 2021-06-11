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
            int[] Numbers = new int[5] { 11, 22, 33, 44, 55 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("Array Value at position Numbers["+i+"] :"+Numbers[i]);
            }
            //Foreach Statement
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
