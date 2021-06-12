using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{

    /*
     * A class consists of data and behaviour. Class data is trpreasented by it's 
     * fields and behaviour is repreasented by the methods.
     * Methods mean what is doing the capable of class
     * To create class use keyword class
     * Constructor has the same name as that of class
     * public is access specifier
     * Constructor is used to inialize the class fields
     * Consrusctor does not return any value
     * Rather Methods or functions returns the value
     * this keyword refers to the object of the class, instance of the class
     * For better readablity we use this keyword
     * void does not return any value
     * class can have also destrutor
     * Dectructor have the same name as that of calss
     * But destructor donot taje any parameter
     * They cannot have return type
     * we use ~ symbol
     * we donot require destructor in c#
     * It used for the clean up resources of class during his lifetime
     * we donot call the destructor
     * It is automaticallay called bygarbage collector 
     * when it tries to cleanup the object from the memory
     * for using the class in main method we create an instance of the class
     * with the help of new keyword we create an instance of the class
     * Constructor is called autmatically when we creating an instance or object of the class
     *Constructors do not mandatory. If we do not provide a construcot, 
     *a default parameter less constructor is automatically provided.
     *When you do not provide a constructor then .net provide an parameter less default constructor
     */
    class DataTypes
    {
        class Customer
        {
            string Firstname;
            string lastname;
            public Customer(string fn, string ln)
            {
                this.Firstname = fn;
                this.lastname = ln;
            }
            public void Printfullname() 
            { 
                Console.WriteLine("Customer Full Name :{0}",this.Firstname+" "+this.lastname);
            }

            //Parameterless default constructor
            //public Customer()
            //    :this("No First Name","No Last Name")
            //{

            //}
            ~Customer()
            {
                //cleaning up code
            }
        }
       
        static void Main(string[] args)
        {
            //Customer C1 = new Customer();

            Customer C1 = new Customer("Bilal","Shabbir");
            C1.Printfullname();
            Console.ReadLine();
        }

    }
}
