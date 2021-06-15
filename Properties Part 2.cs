using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
     *Properties alllows you to control the accessibility of a class  vriable,
     *and the recommended way to accees variables from the outside in c#
     *
     *A property is much like a combination of a variable and a method.
     *It cannot take any parameters,but you are able to process the value
     *before it's assigend to out returned
     *
     *Properties are like data fields variables but have logic behind them
     *
     *From the outside, they look like any other member variable.
     *But they act like a member function.
     *
     *Defined like a field, with "GET" and "SET" accessors code Added.
     *Properties are used for Encapsulation.
     *
     *Why Properties
     *Making the class fields public and exposing to the external world
     *is bad, as you will not have control over what gets assigned and returned.
     *
     *Problems with Public Fields
     *
     *1. ID should always be non negative number
     *2. Name cannot be set to null
     *3. If student Name is missing "No Name" should be returned
     *4.PassMark should be read only
     *
     *Programming languages that does not have properties use getter and setter
     *methods to encapsulate and protect fields.
     */

    class Program
    {
        
            public class Student
        {
            private int _id;
            private string _name;
            private int _passmark = 35;

            public int Getpassmark()
            {
                return this._passmark;
            }
            public void Setid(int id)
            {
                if (id<=0)
                {
                    throw new Exception("Student ID is cannot be Negative!");
                }
                this._id = id;
            }
            public int Getid()
            {
                return this._id;
            }


            public void Setname(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name Cannot be null !");
                }
                else
                {
                    this._name = name;
                }

            }
            public string Getname()
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
                //if (string.IsNullOrEmpty(this._name))
                //{
                //    return "No Name";
                //}
                //else
                //{
                //    return this._name;
                //}
            }
        }

    static void Main(string[] args)
        {
            Student S = new Student();
            S.Setid(45);
           
            Console.WriteLine("Student ID is :{0}", S.Getid());

            S.Setname("Bilal");
            Console.WriteLine("Student Name: {0}", S.Getname());

            Console.WriteLine("Student Passmark: {0}", S.Getpassmark());
               
            Console.ReadLine();
        }
    }
}
