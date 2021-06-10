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
            // declaring string
            string a = "Bilal";

            //append in a
            a += " Shabbir";
            a = a + " Ghulam";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            Console.WriteLine(obj.GetType());
            Console.ReadLine();
        }
    }
}
