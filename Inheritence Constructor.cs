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
         Constructor of parent class is invoked before the derived
         class constuctor
        Parameter less construcotr is called automatically bby creating 
        the instance of class
        base keyword is refers to parent class
         */
        public class Parentclass
        {
            public Parentclass()
            {
                Console.WriteLine("Parent Class Constructor Called!");
            }
            public Parentclass(string message)
            {
                Console.WriteLine(message);
            }

        }
        public class Childclass:Parentclass
        {
            public Childclass():base ("Derived Class Controlled The Base Class Constructor!")
            {
                Console.WriteLine("Child Class Constructor Called!");
            }
        }
       

        static void Main(string[] args)
        {
            Childclass Cc = new Childclass();
            Console.ReadLine();
        }

    }
}
