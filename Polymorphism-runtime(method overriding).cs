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
         * Run time polymorphism is achieved by method overriding.
         * Method overriding allows us to have virtual and 
         * anstract methods in the Base using derived classes with the same name and the same parameter
         * If derived class define same method as defined in its base
         * class,it is known as method overriding in c#.
         * It enables you to provide specific implementation
         * of the method in child class which is already provided by its base class
         * to perform method overriding in c# you need to use virtual keyword with
         * base class method and override keyword with derived class method.
         * A method declared using the virtual keuword is referred to as a virtual method.
         * In the derived class, you need to to declare the inherited virtual method 
         * using the override keyword which is mandatory for any virtual method
         * that is inherited in the derived class.
         * The override keyword overrides the base class method in the derived class.
         * 
         * Key difference b/w Method hiding and method overloading
         * In Method Hiding a base class reference variable pointing to a child
         * class object, will invoke the hidden method of the base class.
         * 
         * in Method Overriding a base classreference variable poiting
         * to a child class object, will invoke the overridden method of the child class.
        */
        class Parent
        {
            public virtual void Print()
            {
                Console.WriteLine("This is a method of Parent class");
            }
        }
        class Child:Parent
        {
            public override void Print()
            {
                Console.WriteLine("This is a method of Child class");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------Run Time polymorphism--by--Method Overriding---------");
            
            
            Console.ReadLine();
        }

    }
}


