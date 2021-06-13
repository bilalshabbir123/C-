using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        /*
         *The concept of overloading a function can also be applied on operators.
         *Operator Overloading gives the ability to use
         the same operator to do various operations
         *For operator overloading we use a keyword known as operator
         *It provides additional capbilities to c# operator 
         *when they are applied to user-defined data types.
         *it enable to make user-defined implementations of various operations
         *where one or both of the operands are of a user-defined class.
         *Only the predefined set of c# operators can be overloaded.
         *An operator can be overloaded by defining a function to it.
         *The function of the operator is declared by using the operator keyword.
         */

        class Newclass
        {
            public string name;
            public int num;

            public static Newclass operator +(Newclass obj1, Newclass obj2)
            {
                Newclass obj3 = new Newclass();
                obj3.name = obj1.name + obj2.name;
                obj3.num = obj1.num + obj2.num;
                return obj3;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------Operator Overoading---------");
            Newclass Obj1 = new Newclass();
            Obj1.name = "Bilal Shabbir";
            Obj1.num = 10;

            Newclass Obj2 = new Newclass();
            Obj2.name = "  Salman Shabbir";
            Obj2.num = 20;

            Newclass Obj3 = new Newclass();
            Obj3 = Obj1 + Obj2;
            Console.WriteLine(Obj3.name);
            Console.WriteLine(Obj3.num);
            Console.ReadLine();
        }

    }
}


