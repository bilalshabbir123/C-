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
            //array is a collection of variable of same type
            //arrays is strongle typed
            //disadvantage of array is the size of array
            //onece you fix the size of array it can not be change
            /*Arrays cannot grow in size onece initilized
            have to rely on integral indices to store or retrieve intems from the array 
            In C# the allocation of memory for the arrays is done dynamically.*/

            //declares an Array of Intergers;
            int[] intArray;
            //allocating memory for 5 integers
            intArray = new int[5];
            //initialize the first element of the array
            intArray[0] = 10;
            //initialize the second element of the array
            intArray[1] = 20;
            //so on
            intArray[2]= 30;
            intArray[3] = 40;
            intArray[4] = 50;
            

            //accessing the elements using for loop

            Console.WriteLine("For Loop:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(" "+intArray[i]);
            }

            Console.WriteLine("Out put with foreach loop");
            //Foreach loop
            foreach (var i in intArray)
            {
                Console.WriteLine(" "+i);
            }

            Console.WriteLine("Out put with while loop");
            //using while loop
            int j = 0;
            while (j<intArray.Length)
            {
                Console.WriteLine(" "+intArray[j]);
                j++;
            }
            Console.WriteLine("Out put with do-while loop");
            int k = 0;
            do
            {
                Console.WriteLine(" "+intArray[k]);
                k++;
            }
            while (k<intArray.Length);
              


            Console.ReadLine();
        }
    }
}
