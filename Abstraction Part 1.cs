using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    class Program
    { 
    /*
    *******************
    *Abstraction In C#
    Abstraction is one of the principle of object oriented programming.
    It is used to display only necessary and essential features of an object to outside the world.
    Mean displaying what is necessary and encapsulate the unnecessary things to outside the world.
    Hiding can be achieved by using "private" access modifier.

        Abstraction is a process of hiding the implementation details from the user,
    only the functionality will be provided to the user.

        In other words, the user wil have the information on what the object does
    instead of how it does it.

        Note:
    Outside the world means when we use reference of object then it will
    show only necesssary methods an dproperties(ABSTRACTION) and hide methods
    which are not necessary(ENCAPSULATION)


        Abstraction
    1. Abstraction is "To repreasent the essential feature without repreasenting the background details"
    2. Abstraction lets you focus on what the object does instead of how it does it.
    3. Abstraction privides you a generalized view of your clases or objects
     by providing relevant information.
        Encapulation is not only hiding the methods.
    we can say hiding of methods is a type of encapsulation
*/
    class Employee
        {
            public int Empid;
            public string Name;
            public double Grosspay;
            double Taxdeduction = 0.1d;
            double Netsalary;
            public Employee(int a,string na,double gross)
            {
                this.Empid = a;
                this.Name = na;
                this.Grosspay = gross;

            }
            void CalculateSalary()
            {
                if (Grosspay>=30000)
                {
                    Netsalary = Grosspay - (Taxdeduction * Grosspay);
                    Console.WriteLine("Your Netsalary: {0}",Netsalary);
                }
                else
                {
                    Console.WriteLine("Your Salary is: {0}",Grosspay);
                }
            }
            public void Employeedetail()
            {
                Console.WriteLine("Employee ID: {0}",this.Empid);
                Console.WriteLine("Employee Name: {0}",this.Name);
                this.CalculateSalary();
                


            }


        }
   

        static void Main(string[] args)
            {
            Employee E = new Employee(12,"Bilal Shabbir",45000);
            E.Employeedetail();
            
            Console.ReadLine();
            }
        }
    }
