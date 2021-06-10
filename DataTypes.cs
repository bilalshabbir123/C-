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
            // declaring character
            char a = 'G';

            // Integer data type is generally
            // used for numeric values
            int i = 89; //4 byte

            short s = 56; //2 byte -32768 to +32767

            // this will give error as number
            // is larger than short range
            // short s1 = 87878787878;

            // long uses Integer values which 
            // may signed or unsigned
            long l = 4564; //8byte

            // UInt data type is generally
            // used for unsigned integer values
            uint ui = 95; //4 byte

            ushort us = 76;
            // this will give error as number is
            // larger than short range

            // ulong data type is generally
            // used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value
            // is double in C#
            double d = 8.358674532;

            // for float use 'f' as suffix
            float f = 3.7330645f;

            // for float use 'm' as suffix in decimal
            decimal dec = 389.5m; //16 byte

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
    }
}
