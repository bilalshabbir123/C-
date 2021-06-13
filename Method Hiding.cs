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
         Method Hiding
        base keyword is refers to the base method or class
        Parent class reference variable points to a child class object
        Child class reference variablr cannot points to a parent class object
        Use the new keyword to hide a base class member.
        You will get a compiler warning
        if you miss the new keyword
        *Different ways to invoke a hidden base class members from derived class
        *Use base keyword
        *cast child type to parent type and invoke the hidden member
        *ParentClass PC=new ChildClass()
        *PC.HiddenMethod()
        *Method Hiding occurs in inheritence relationship
        *when base and derived class have a mathod with name and signature.
        *
        *When we create the object of derived  class it will hide the base class method
        *and will call its own method and this is called method hiding or name hiding in c # inherithnce
        *
        *we use new keyword in derived function name to show that
        *implementation of the function in derived class is intensional and derived class
        *no longer want to use base class nethod
        *
        *but if do not use "new keyword then compiler will rause only warning, but program will work fine."
         when we create the object of child class, parent class object is also created
         */
        public class Employee
        {
            public string FirstName;
            public string Lastname;

            public void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + Lastname);
            }
        }
        public class Parentclass : Employee
        {
            public new void PrintFullName()
            {
                //base.PrintFullName();
                Console.WriteLine(FirstName + " " + Lastname + "--constracotr");
            }
        }


        static void Main(string[] args)
        {
            Parentclass PTE = new Parentclass();
            PTE.FirstName = "Bilal";
            PTE.Lastname = "Shabbir";
            PTE.PrintFullName();
            ((Employee)PTE).PrintFullName();


            Console.ReadLine();
        }

    }
}
