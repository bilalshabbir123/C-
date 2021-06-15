using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
    
     */

    class Program
    {
        public struct Customer
        {
            private int _id;
            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                }
            }

            public int ID
            {
                get { return _id; }
                set
                {
                    _id = value;
                }
            }
            public Customer(int id, string name)
            {
                this._id = id;
                this._name = name;

            }
            public void PrintDetails()
            {
                Console.WriteLine("ID={0} && Name={1},",this._id,this._name);
            }

            static void Main(string[] args)
            {

                Customer C1 = new Customer(101,"Bilal");
                C1.PrintDetails();
                Customer C2 = new Customer();
                {
                    C2.ID = 13;
                    C2.Name = "Shabbir";
                    C2.PrintDetails();
                }
                
                Console.ReadLine();
            }
        }
    }
}