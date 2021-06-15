using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     *  **************** Difference B/W Types and Type Memebers ****************** *
    In this example Customer is the type and fields, properties and method are type members

    So, In general classes, structs, interfaces, delegatesare called as types and fields
    properties, constructors, methods etc..
    That nomally reside in a type are called as type members.

    In C# there are 5 different access modifiers:
    1.Private
    2.Protected
    3.Internal
    4.Protected Internal
    5.Public

    Type members can have all the access modifiers, where as types
    can have only 2 (Internal,public) of the 5 access modifiers.

    Note:
    Using regions you can expand and collapse sections of your code either manually,
    or using visual studio Edit->Outlining->Toggle All Outlining

    */

    class Program
    {
        public class Customer
        {
            #region Fields
            private int _id;
            private string _firstname;
            private string _lastname;
            #endregion
            #region Properties
            public int ID
            {
                get { return _id; }
                set { _id = value; }
                
            }
            public string Firstname
            {
                get { return _firstname; }
                set { _firstname=value; }
            }

            public string Lastname
            {
                get { return _lastname; }
                set { _lastname = value; }
            }
            #endregion
            #region Methods
            public string Fullname()
            {
                return this._firstname + "  " + this._lastname;
        }
            #endregion
        }

static void Main(string[] args)
        {

        }
        }
    }

