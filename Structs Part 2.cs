using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprograms
{
    /*
    Structure is a user defined data dtype.
    class is also a user defined data type.
    structure are introduced first before the classes.
    Structures are first introduced in procedural language called C progrmming language
    Classes are introduced after structure in OOP language
    Structure belongs to procedural language.
    Classes belong to OOP language.
    Structure in C programming language can contain only fields/members.
    Structures in c# programming language can contain most of the members
    that a class can contain like Methods, Fields, Constructors,Properties, Indexers etc.
    In c#, classes and structs are blueprints that are used to create instance of a class.
    Structure is a value type.
    Structures are stored in stack memory.
    Class is a reference type and it is stored in Heap memory.
    Stack memory is small in size. 
    While heap memory is big in size.
    Class and structures both are used to repreasent entities like
    student, employee, customer etc.
    We can use class for repreasenting large amount of data.
    On the other hand we can use structures for repreasenting samll amount of data.
    Struct are used for lightweight objects such as Color,Rectangle,Point etc
    String is a class , reference type it is pre-defined
    int is a struct , value type
    Pre-defined reference types are big in size.
    Pre-defined value types are small in size.
    
     ********
    *In case of a class "new " keyword is compulsory while creating the object/instance,
    *on the other hand "new " is not compulsory while working with structure.
    *In case of structure, if you donot specify new keyword and constructor
    then you have to explicitly initialize the field.
    *In case of classes, if you don't specify new keyword and constructor then you
    *cannot the explicitly initialize the field.
    *Because "new "keyword is compulsary while creating instance of a class.

    In case of classes, if we donot create a constructor then a default constructor comes into place.

    In case of classes, we can explicitly create default constructor/ Parameterless constructor
    constructor.

    But if we create any constructor in class then default constructor will be gone.

    In case of strructure, if we don't create a constructor then a default constructor comes into place.

    In case of structure, we cannot explicitly create default constructor/Paramerterless
    constructor because it is always pre-defined, we can create only parametirized
    constructor in structure.

    Note:
    Class supports Inheritence whereas Structure don't support inheritence.
    Class can implement interfaces as well as structures can also implement interfaces.

    Structure are added by empty code file... becasue there is no any tempalte for adding struct.
    ************************
    Value types hold their value in memory where they are declared, 
    but reference types hold a reference to an object in memory.

    Value types are destroyed immediately after the scope is lost, where as for reference
    types only the referenc evariable is destroyed after the scope is lost. The object is later destroyed
    by the garbage collector.

    When you copy a struct into another struct, a new copy of that structs gets created
    and modifications on one struct will not affect the values contained by the other struct.

    When you copy a class into another class, we only get a copy of the reference variable.
    Both the reference variables points to the same object on the heap. So operations on one
will affect the values contained by the other reference varable. 

    A class or a struct cannot inherit from another struct. Struct are sealed tyoes.




*/

    class Program
    {
       struct  Structprogram
        {
            public void func1()
            {
                Console.WriteLine("This is my new Function..");
            }
        }
            static void Main(string[] args)
            {
            Structprogram P= new Structprogram();
          //  Structprogram P;//= new Structprogram();
            P.func1();
            
                Console.ReadLine();
            }
        }
    }
