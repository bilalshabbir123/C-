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

    We cannot create an instance of an interface, but an interface reference 
    variable can point to derived class object.
    Interface naming convention interface names are preferred with capital

    There are 2 types of implementation of interfaces.
    1.Implicit Interface Implementation
    2.Explicit Interface Implementation

    A class has to explicitly implement multiple interfaces if these interfaces
    have methods with identical names.

    If an interface has a method name identical to the name of method declared int the 
    inheriting class this interface has to be explicitly implemented.

    Note:
    Access modifiers are not allowed on explicit implemented interface members.
    If you want to make one of the interface method, the default, then implement
    that method normally and the other interface method explicitly.
    This makes the default method to be accessible through class instance.
*/

    class Program
    {
       interface I1
        {
            void SHow();
        }
        interface I2
        {
            void SHow();
        }
        //class Myclass : I1, I2
        //{
        //    //there is no need to put public with method in explicit implementation

        //    void I1.SHow() //explicit implementation of Interface
        //    {
        //        Console.WriteLine("This is a method of I1 Interface !!");
        //    }
        //    void I2.SHow()
        //    {
        //        Console.WriteLine("This is a method of I2 Interface !!");
        //    }
        //}
        class Myclass : I1, I2
        {
            public void SHow()
            {
                Console.WriteLine("abc");
            }

            //void I1.SHow()
            //{
            //    Console.WriteLine("This is a method of I1");
            //}

            void I2.SHow()
            {
                Console.WriteLine("This is a method of I1");
            }
        }

        static void Main(string[] args)
            {
            Myclass Obj = new Myclass();
            ((I1)Obj).SHow();
            //class 1 reference variable is converted in I1 reference variable
            //we can store the child obj in the parent reference variable
            I1 obj1 = new Myclass();
            obj1.SHow();
            I2 obj2 = new Myclass();
            obj2.SHow();

            Myclass obj3 = new Myclass();
            obj3.SHow();

            I1 obj4 = new Myclass();
            obj4.SHow();
            Console.ReadLine();
            }
        }
    }
