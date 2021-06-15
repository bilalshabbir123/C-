using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * *******************FORMAT Exception***************** *
    
     * 
    
    */




    class Program
    {
     
      
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number: ");
                string number = Console.ReadLine();
                int num = int.Parse(number);
                Console.WriteLine("Number is: " + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
              
            
            
            Console.ReadLine();
        }
        }
    }
