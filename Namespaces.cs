using System;
using PATA = ProjectA.TeamA;
namespace ProjectA.TeamA
{
    class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("This is a Team A Print Method");
        }
    }
}
namespace ProjectA.TeamA
{
    class ClassB
    {
        public static void Print()
        {
            Console.WriteLine("This is a Team B Print Method");
        }
    }
}


namespace IntroductiontoCsharp
{
    class DataTypes
    {
        //Namespaces are used to organize your program
        //They also provide assisstence in avoiding name clashes
        //console class is coming from system namespace which presentn system assesbly
        //curly brackets indicates namespace
        

        static void Main(string[] args)
        {
            //we use alias * using PATA = ProjectA.TeamA;
            //ProjectA.TeamA.ClassA.Print();
            PATA.ClassA.Print();
            Console.ReadLine();
        }

    }
}
