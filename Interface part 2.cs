using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
    Interface can inherit from other interfaces.
    A class inherits this interface must provide implementation for all interface 
    members in the entire interface chain.

    Interface reference variable can have the reaference of their child class.

    Cannot create an instance of an abstract class and interface...

    It is compile time error to provide implementation for any interface member.

    We cannot create an instance of aan interface, but an interface reference 
    variable can point to derived class object.
    Interface naming convention interface names are preferred with capital
*/

    class Program
    {
        interface I1
        {
            void Show();
        }
        interface I2
        {
            void Show1();
        }
        interface I3:I1,I2
        {
            void Show2();
        }
        class IE : I1,I2,I3
        {
            public void Show()
            {
                Console.WriteLine("This is a Method of IEmployee Interface !!");
            }
            public void Show1()
            {
                Console.WriteLine("This is a Method of IEmployee Interface !!");
            }
            public void Show2()
            {
                Console.WriteLine("This is a Method of IEmployee Interface !!");
            }
        }

        static void Main(string[] args)
            {
            IE Ie = new IE();
            Ie.Show();
            Ie.Show1();
            Ie.Show2();
            I2 myinterface = new IE();
            myinterface.Show1();

                Console.ReadLine();
            }
        }
    }
