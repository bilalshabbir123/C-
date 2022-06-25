using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
   An Interface is a contract b/w itself and any class that implements it.
    This contract states that any class that implements the interface will implement the 
    interface's properties, methods and or events.
    An interface contains no implementation, only the signature of methods, properties,
    Indexers and events.

    The Interface defines the 'what' part of the syntactical contract and the deriving classes define the 
    'how' part of the syntatical contract.

    Interfaces define properties,methods and events, which are the members of the interface.
    Interfaces contain only the declaration of the members.
    It is the responsibility of the deriving class to define the members.
    All the members in the interface are public by default.

    *An interface contains only abstract members, just like abstarct classes interface also
    contain properties, methods, delegates or events, but only declarations, no implementations.

    An interface cannot be instantiated but can only be inherited by classes or other interfaces.

    Interface cannot have fields.
    An Interface is declared using the keyword interface.

    In C#, bydefault, all members declared in an interface have public as the access modifier.

    They don't allow explicit access modifiers.

    ***************
    Implementing an interface
    An interface is implemented by a class in a way similar to inheriting a class.
    When implementing an interface in a class, implement all the abstract methods declared
    in the interface.
    If all the methods are not implemented, the class cannot be compiled.
    The methods implemented in the class should be declared with the same name signature as defined in the interface
*/

    class Program
    {
        interface IEmployee
        {
            void Show();
        }
        class Parttimeemployee : IEmployee
        {
            public void Show()
            {
                Console.WriteLine("This is a Method of IEmployee Interface !!");
            }
        }

        static void Main(string[] args)
            {
            Parttimeemployee PTE = new Parttimeemployee();
            PTE.Show();
                Console.ReadLine();
            }
        }
    }
