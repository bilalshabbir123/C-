using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
    
*/
    class Program
    {
       
      
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Please Enter The First Number: ");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Enter The Second Number: ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                }
                catch (Exception ex)
                {
                    string Filepath = @"F:\Complete Journey\log.txt";
                    if (File.Exists(Filepath))
                    {
                        StreamWriter sw = new StreamWriter(Filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, Please Try Later");
                    }
                    else
                    {
                        throw new FileNotFoundException(Filepath + "Is not Present ", ex);
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception- ",exception.GetType().Name);
                Console.WriteLine("Current Exception- ",exception.InnerException.GetType().Name);
            }
            Console.ReadLine();
        }
        }
    }
