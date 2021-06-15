using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
      * A delegate is a function pointer.
      * Delegate is type safe function pointer.
      * Delegate points to a function when you invoke this delegate function is invoked.
      * The Signature of the delegate should be match of the fucntion, the delegates points to,
      * otherwise you get a compiler error.
      * *This is the reason delegates are called as type safe function pointers.
      * 
      * * A delegate is similar to a class. You can create an instance of it, and when you do so,
      * you pass in the function names as a parametr to the delegate constructor , and it is to this function
      * the delegate will point to.
      * 
      * Tip to remember delegate syntax: Delegates syantx look very much similar to a method with a delegate keyword.

    *Multicast delegate make implemetation of observe design pattern very simple. 
    *Observer Pattern ia also called as publish/subsrive pattern.
    ****************
    *This is simple example without the using of delegate-----------------
    */
    public delegate bool Ispromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void Promoteemployee(List<Employee> employeeList,Ispromotable Iseligibletopromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (Iseligibletopromote(employee))
                {
                    Console.WriteLine(employee.Name+ " Promoted");
                }
            }
        }
    }
    class Program
    {
      
        static void Main(string[] args)
            {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Bilal", Salary = 5000, Experience = 2 });
            emplist.Add(new Employee() { ID = 102, Name = "Shabbir", Salary = 51000, Experience = 7 });
            emplist.Add(new Employee() { ID = 103, Name = "Ghulam", Salary = 500220, Experience = 4 });
            emplist.Add(new Employee() { ID = 104, Name = "Shabbir", Salary = 30, Experience = 7 });

            Ispromotable Ispromoteable = new Ispromotable(Promote);

            Employee.Promoteemployee(emplist,Ispromoteable);

            
            Console.ReadLine();
            }
        public static bool Promote(Employee emp)
        {
            if(emp.Experience>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        }
    }
