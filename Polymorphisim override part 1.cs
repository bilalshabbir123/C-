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
         * polymorphism is one of the primary pillar of object-oriented programming
         * polymorphism allows you to invoke derived class method through a base class reference during runtime.
         * In the base class the method is declared virtual,
         * and in the derived class we override the same method.
         * The virtual keyword indicated, The method can be overriden in any derived class.
        if any derived class did not have overiden method then the base class virtual methoed is used
        */
        class Employee
        {
           public string Firstname = "FN";
           public  string Lastname = "LN";
            public virtual void PrintFullname()
            {
                Console.WriteLine(Firstname+ " "+Lastname);
            }
        }
        class Fulltimeemployee : Employee
        {
            public override void PrintFullname()
            {
                Console.WriteLine(Firstname + " " + Lastname+" -Full Time");
            }
        } 
        class Parttimeemployee : Employee
        {
            public override void PrintFullname()
            {
                Console.WriteLine(Firstname + " " + Lastname + " -Part Time");
            }

        } 
        class Temporarytimeemployee : Employee
        {
            public override void PrintFullname()
            {
                Console.WriteLine(Firstname + " " + Lastname + " -Temporary Time");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("------Run Time polymorphism--by--Method Overriding---------");
            Employee[] employees= new Employee[4];
            employees[0] = new Employee();
            employees[2] = new Parttimeemployee();
            employees[1] = new Fulltimeemployee();
            employees[3] = new Temporarytimeemployee();
            foreach (Employee e in employees)
            {
                e.PrintFullname();
            }



            Console.ReadLine();
        }

    }
}


