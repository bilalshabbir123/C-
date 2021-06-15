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
    Abstract class did not have any object
    Members of abstract class is used by inheritence
    *Abstract methods which do not have body and Implementation.
    *Concreate methods which have an body
    
        if my class have at least one abstract method then 
        it is necassary to make the class abstract

       hieracrical inheritence is implemented in this program one parent
    and two child are derived. 

    1. C# abstract classes are used to declare common characteristice of subclass.
    2. A class which contains the abstract keyword in its declaration is known as abctract class.
    3. It can only be used as a BASE class for other classes that extend the abstract class.
    4. Abstract classes may or may not contain abstract methods
    i,e.. methods without body(public void get();)
    5.Like any other class, an abstract class can contain fields that describe the characteristics and
    methods that describe the actions that a class can perform.
    6. But if a class has at least one abstract method then the class must be declared abstract.
    7. If a class is declared abstract it cannot be instantiated.
    8. To use an abstract class, you have to inherit it from another class, provide implementations to the abstract methods in it.
    9. If you inherit an abstract class, you have to provide implementations to all the abstract methods in it.
    10. An abstract class can implement code with non-Abstract methods.
    11. An abstract class can have modifiers for methods, properties etc..
    12.An abstract class can have constants and fields.
    13. An abstract class can implement a property.
    14. An abstrat class can have constructors or destructors.


        ********Key Difference B/w Abstract classes VS Interfaces*********
        *Abstract classes can have implementations for some fo its members(methods),
        *but the interface can't have implementation for any of its members.
        *
        *Interface cannot have fields where as an abstract class have fields.
        *
        *An interface can inherit from another interface only and cannot inherit from 
        *an abstract class, where as an abstract class are inherit from another class or 
        *another interface.
        *
        *A class can inherit from multiple interfaces at the same time, where as a class cannot
        *inherit from multiple classes at the same time.
        *
        *Abstract class members can have access modifiers where as interface member cannot have access modifier.
*/
    abstract class Person
        {
            public string Fname;
            public string lname;
            public int age;
            public long Phonenumber;

            public abstract void Printdetail();
           
        }
        class Student:Person
        {
            public int Rollno;
            public int Fees;

            public override void Printdetail()
            {

            }
        }
        class Teacher:Person
        {
            public string Qualification;
            public int Salary;

            public override void Printdetail()
            {
                string Name = this.Fname + " " + this.lname;
                Console.WriteLine("Teacher Name is {0}",Name);
                Console.WriteLine("Teacher Age  is {0}",this.age);
                Console.WriteLine("Teacher Phone No  is {0}",this.Phonenumber);
                Console.WriteLine("Teacher Qualification  is {0}",this.Qualification);
                Console.WriteLine("Teacher Salary  is {0}",this.Salary);

            }
        }
   

        static void Main(string[] args)
            {
            Teacher Tech = new Teacher();
            Tech.Fname = "Bilal";
            Tech.lname = "Shabbir";
            Tech.age= 50;
            Tech.Phonenumber = 03084414816;
            Tech.Qualification = "BS IT";
            Tech.Salary = 50000;
            Tech.Printdetail();

            Console.ReadLine();
            }
        }
    }
