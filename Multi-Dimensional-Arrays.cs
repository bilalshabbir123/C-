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
            /*c# Program to illustrate craeting
             an Multi-dimensional array and some values in the array
            and print them*/
            int[,] Intarray = new int[,] 
            { 
                { 1, 2 }, 
                { 3, 4 },
                { 5, 6 }, 
                { 7, 8 } 
            };
            //The Same arrays with dimensions
            //specified 4 rows and 2 columns
            int[,] Intarray_d = new int[4, 2]
            {
                {1,2 },
                {3,4 },
                {5,6 },
                {7,8 },
            };
            //A similar array with string elements
            string[,] str = new string[4, 2]
            {
                {"One","Two" },
                {"Three","Four" },
                {"Five","Six" },
                {"Seven", "Eight"},
             };
            //Three Dimensional Arrays
            int[,,] intarray3D = new int[,,] {
            {
                { 1,2,3},
                { 4,5,6}
            },
            {
                { 7,8,9},
                { 10,11,12}
            }
                };
            //Asseccing Array Elements
            Console.WriteLine("************************");
            Console.WriteLine("2DArray[0][0] :"+Intarray_d[0,0]);
            Console.WriteLine("2DArray[0][1] :"+Intarray_d[0,1]);
            Console.WriteLine("2DArray[1][0] :"+Intarray_d[1,0]);
            Console.WriteLine("2DArray[1][1] :"+Intarray_d[1,1]);
            Console.WriteLine("2DArray[2][0] :"+Intarray_d[2,0]);
            Console.WriteLine("2DArray[2][1] :"+Intarray_d[2,1]);
            Console.WriteLine("2DArray[3][0] :"+Intarray_d[3,0]);
            Console.WriteLine("2DArray[3][1] :"+Intarray_d[3,1]);

            //print the elements of Intarray_d
            Console.WriteLine("2DArray[0][0] :" + Intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] :" + Intarray[0, 1]);
            Console.WriteLine("2DArray[1][0] :" + Intarray[1, 0]);
            Console.WriteLine("2DArray[1][1] :" + Intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] :" + Intarray[2, 0]);
            Console.WriteLine("2DArray[2][1] :" + Intarray[2, 1]);
            Console.WriteLine("2DArray[3][0] :" + Intarray[3, 0]);
            Console.WriteLine("2DArray[3][1] :" + Intarray[3, 1]);

            //Print the elements of 3D Array
            Console.WriteLine("3DArray[0][0][0] : "
                           + intarray3D[0, 0, 0]);

            Console.WriteLine("3DArray[0][0][1] : "
                              + intarray3D[0, 0, 1]);

            Console.WriteLine("3DArray[0][0][2] : "
                                 + intarray3D[0, 0, 2]);

            Console.WriteLine("3DArray[0][1][0] : "
                           + intarray3D[0, 1, 0]);

            Console.WriteLine("3DArray[0][1][1] : "
                              + intarray3D[0, 1, 1]);

            Console.WriteLine("3DArray[0][1][2] : "
                                 + intarray3D[0, 1, 2]);

            Console.WriteLine("3DArray[1][0][0] : "
                          + intarray3D[1, 0, 0]);

            Console.WriteLine("3DArray[1][0][1] : "
                              + intarray3D[1, 0, 1]);

            Console.WriteLine("3DArray[1][0][2] : "
                                 + intarray3D[1, 0, 2]);

            Console.WriteLine("3DArray[1][1][0] : "
                           + intarray3D[1, 1, 0]);

            Console.WriteLine("3DArray[1][1][1] : "
                              + intarray3D[1, 1, 1]);

            Console.WriteLine("3DArray[1][1][2] : "
                                 + intarray3D[1, 1, 2]);

            //print the elements of string array
            for (int i = 0; i < 4; i++)
            {
                for (int j= 0; j < 2; j++)
                {
                    Console.WriteLine(str[i,j]+ " ");
                }
            }


            Console.ReadLine();
        }
    }
}
