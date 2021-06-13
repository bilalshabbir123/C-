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
         * Why Inheritence
         * A lot of code between two classes is dublicated.
         * Move all the common code into base class.
         * code reuse and easily we can test or check the code 
         * and less time is required to test the code.
         * Probabbility of error is reduced.
         * Inheritence promotes reuseability with that we get saving of time.
         * Common code is abstracted away from the base class.
         * and it is reuse in derived class.
         * object of derived class can access the code of base classs
         * an dthe code present in the derived class from which the object is created.
         * Pilars of OOP
         * Inheritence
         * Encapsulation
         * Abstraction
         * Polymorphism
         * Inheritence is one of the primary pillars of object oriented programming
         * It allows code reuse.
         * Code reuse can reduce time and error.
         * Note:
         * You will specify all the common fields,properties methods in the base class,
         * which allows reusablity. In the derived class you will only have fields,
         * prpperties and methods, that are specific to them.
         * c# supports only single class inheritence.
         * c# supports multiple interface inheritence.
         * child class is a specilized of a base class.
         * Base classes are automatically intantiated before derived classes.
         * Parent class constructor executes before child class constructor.
         * multiple inheritence is not available rather than multilevel inheritence is available
         *mean class a is inherited from class b and class c is inherited from class b.
         *
         */
        public class Employee
        {
            public string Firstname;
            public string lastname;
            public string Email;
            public void FullName()
            {
                Console.WriteLine("Fisrt Name:{0}" + "  \nLast Name: {1}" , this.Firstname, this.lastname);
            }
        }
        public class Fulltimeemployee : Employee
        {
            public float yearlysalary;
            public void printsalary()
            {
                Console.WriteLine("Full Time Employee Salary:{0}",this.yearlysalary);
            }
        }
        public class Parttimeemployee : Employee
        {
            public float Hourlysalary;
            public void printsalary()
            {
                Console.WriteLine("Part Time Employee Salary:{0}", this.Hourlysalary);
            }
        }

        static void Main(string[] args)
        {
            Fulltimeemployee Fu = new Fulltimeemployee();
            Fu.Firstname = "Bilal";
            Fu.lastname = "Shabbir";
            Fu.yearlysalary = 50000;
            Fu.FullName();
            Fu.printsalary();
            Console.WriteLine("-------------------------------");
            Parttimeemployee Pa = new Parttimeemployee();
            Pa.Firstname = "Salman";
            Pa.lastname = "Shabbir";
            Pa.Hourlysalary= 10000;
            Pa.FullName();
            Pa.printsalary();
            Console.ReadLine();
        }

    }
}
