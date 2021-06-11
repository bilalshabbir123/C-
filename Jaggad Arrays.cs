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
            /*An array whose elements are arrays is known as 
             Jagged arrays it means “array of arrays“. 
              The jagged array elements may be 
              of different dimensions and sizes. */

            //c# Program to single-dimensional jaggad array
            //that contains teo single-dimensional array
            //elements of different sizes

            /*---------------2D Array-------------*/
            //Declare the array of two elements:
            int[][] Array= new int[2][];
            //inialize the elements:
            Array[0] = new int[5] { 1, 2, 3, 4, 5 };
            Array[1] = new int[5] { 6, 7, 8, 9, 10 };
            //Display the array elements:
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Elements [" + i + "] Array: ");
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.WriteLine(Array[i][j]);
                }

            }

            Console.ReadLine();
        }
    }
}
