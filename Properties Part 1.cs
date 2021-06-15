using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
     *Properties alllows you to control theaccessibility of a class avriable,
     *and the recommended way to accees variables from the outside in c#
     *
     *A property is much like a combination of a variable and a method.
     *It cannot take any parameters,but you are able to peocess the value
     *nefore it's assigend to out returned
     *
     *Properties are like data fields variables but have logic behind them
     *
     *From the outside, they look like any other member variable.
     *But they act like a member function.
     *
     *Defined like a field, with "GET" and "SET" accessors code Added.
     *Properties are used for Encapsulation.
     */

    class Program
    {
        class Student
        {
            private int _id;
            private string _name;

            public int Stdid
            {
             
                get
                {
                    return this._id;
                }
            
              
                 set
                {
                    if(value<=0)
                    {
                        Console.WriteLine("Value is less Than or Equal To Zero Please ENter the value Greater Than Zero!");
                    }
                    else
                    {
                        this._id = value;
                    }
                    
                }
            }
            public string Name
            {

                get
                {
                    return this._name;
                }


                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Please Enter Your Name!");
                    }
                    else 
                    {
                        this._name = value;
                    }

                }
            }


        }
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Stdid = 23;
            Console.WriteLine(S.Stdid);
            S.Name = "Bilal";
            Console.WriteLine(S.Name);
            Console.ReadLine();
        }
    }
}
