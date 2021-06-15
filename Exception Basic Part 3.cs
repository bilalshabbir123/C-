using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     * *******************NULL REAFERENCE Exception***************** *
    
     * 
    
    */




    class Program
    {
     
      
        static void Main(string[] args)
        {

           
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("String is NULL");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
        }
    }
