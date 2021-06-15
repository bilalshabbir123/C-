using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * *******************Index Out of Range Exception***************** *
     * 
     * Index was out of the bounds of the array
    
    */




    class Program
    {
     
      
        static void Main(string[] args)
        {
          
                int[] arr = new int[3];
            try
            {
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;

                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array's Range is Exceeded !!");
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }
        }
    }
