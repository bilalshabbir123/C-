using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpprograms
{
    /*
     There are 5 different modifiers in C#.
    1. Private
    2. Protected
    3.Internal
    4. Protected Internal
    5. Public

    private members are available only with in the containing type,
    where as public members are available any where, There is no restriction.

    A member with internal access modifier is available any where with in the containing
    assembly. It is a compile time error to access, an internal members from outside the containing assembly.

    Protected internal members can be accessed by any code in the assembly
    in which it is declared, or from within aderived class in another assembly.
    It is a combination of protected and internal.
    if you have understood protected and internal, this should be very easy to follow.

    *Access modifier 
    1.Private
    Only with in the containing class
    2.Public
    Any where, No restrictions
    3.Protected
    With in the containing types and the types derived from the containing type.
    4.Internal
    Anywhere with in the containing assembly
    5.Protected Internal
    Anywhere with in the containing assembly, and from within a derived class in any another assembly.
    */

    class Program
    {
       


            static void Main(string[] args)
            {
                
            }
        }
    }

