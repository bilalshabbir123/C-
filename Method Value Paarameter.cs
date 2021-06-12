using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        public static void Simplemethod(ref int j)
        {
            j = 101;
        }
        static void Main(string[] args)
        {
            int i = 0;
            Simplemethod(ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
