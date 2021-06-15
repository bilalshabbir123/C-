using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
     * We use get and set accessors to implement properties.
     * A property with both get and set accessors is a Read/write Property.
     * A property with only get accessor is a Read only property.
     * A Property with  only set accessor is a write only property.
     * Note:
     * The advantage of properties over traditional Get() and Set() methods
     * is that, you can access them as if they were public fields.
     * 
     * Auto Implemented Properties
     * 
     * If There is no additional logic in the peoperty accessors, then we can make use of 
     * auto implemented properties introduces in c# 3.0.
     * 
     * Auto implemented properties reduce the amount of code that we have to write.
     * 
     * When You use auot-implemented properties, the compiler creates a private,
     * anonymous field, that can only be accessed through the property's get and set accessors.
    
     */

    class Program
    {
        public class Student
        {
            private int _id;
            private string _name;
            

            public void  SetId(int id)
            {
                if (id<=0)
                {
                    throw new Exception("ID cannot be set Null or less than zero!");
                }
                this._id = id;
            }
            public int GetId()
            {
                return this._id;
            }

            public void Setname(string name)
            {
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be set Null or Empty!");
                }
                this._name = name;
            }
            public string Getname()
            {
                return this._name;
            }
            public int Passmark
            {
                get
                {
                    return this.Passmark;
                }
            }
            public string email
            {
                get;
                set;

            }
            public string City { get; set; }
        }
       

    static void Main(string[] args)
        {
            Student S = new Student();
            S.SetId(40);
            Console.WriteLine("Student Id: {0}",S.GetId());
            S.Setname("Bilal");
            Console.WriteLine("Student Name: {0}", S.Getname());
            Console.WriteLine("Pass Mark: {0}", S.Passmark);
            
            Console.ReadLine();
        }
    }
}
