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
         * Polymorphism is one of the four pillars of object oriented programming.
         * Polymorphism in c# is a concept by which we can perform
         * a single action by different ways.
         * Polymorphism is derived from 2 Greek words:
         * POLY and MORPHS.
         * The word "poly" means many and "morphs" mean forms.
         * so polymorphism means many forms.
         * There are two types of polymorphism
         * 1. Static polymorphism (compile time polymorphism)
         * 2. Dynamic polymorphism (Run time polymorphism)
         * 
         * Static polymorphism
         * The mechanism of linking a function with an object during compile
         * time is called static polymorphism or early binding
         * It is also called static binding. Function is bind to object.
         * 
         * c# Provides two techniques to implement static polymorphism
         * 1.METHODS OR FUNCTION OVERLOADING
         * 2.OPERATOR OVERLOADING
         *
         *Method or function overloading
         *You can have multiple definations for the same function name in the same scope
         *The defination of the function must differ from each by the types and/or the number of arguments in the argument list.
         *You cannot overload function declarations that differ only by return type.
         *
         *
         *Base class reference varible can points to a child class object
         */

        
        class Program
        {
            public int a = 20;
            public int b = 40;
            public void Add()
            {
                int c = a + b;
                Console.WriteLine("Addition of "+this.a+ " + "+this.b+" is: {0}",c);
            }
            public void Add(int a1,int a2,int a3)
            {
                int x=a1+a2+a3;
                Console.WriteLine("Addition of  "+a1+" "+a2+" "+a3+" "+" is: {0}", x);
            }
            public void Add(string x,string y)
            {
                Console.WriteLine(x+" "+y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------Methods Overoading---------");
            Program P= new Program();
            P.Add();
            P.Add(10,20,30);
            P.Add("Bilal", "Shabbir");
            Console.ReadLine();
        }

    }
}
