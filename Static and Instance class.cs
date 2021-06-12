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
     *when we put static the field is known as static fielad. 
     *if we donot put static with method then evary copy is created with 
     *the creating the object of class.
     *if anything is going to be change then mark as static.
     *float pi=3.14 is an instance member
     *static float pi=3.14 that is an static member
     *this keyword is not used to refer the static member
     *we use the name of the class
     *Note: with help of class name we can the the static member s and static methods
     *static member s are invoked by the name of the class
     *instance member s are invoked using the instance or object of the class
     *static member s have only one copy in the memory no matter how many objects or instances are created
     *to inialize an instance field we use an instance constructor
     *to initialize an static field we use an static constructor
     *when any thing is define privete in the class you can access only on that class
     *outside the class is not access
     *static constructor need not to be called
     *static consrtuctor is automatically called even before that
     *you do have to called static constructor explicitly
     *static construtor is called before the instance constructor even before you refer to static field
     *When a class member includes a static modifier, the member is called as static member.
     *When no static modifer is present the member is called as non member
     *or instance member
     *An instance members belongs to specific instance(object) of a class. 
     *If I create 3 objects of a class.
     *I will have 3 sets of Instance member in the memory,where as there will ever be only
     *one copy of a static member, no matter how many instances of a class are created
     *static constructor is called only once, no matter how many instances you created
     *static constructors are called before instance constructors
     */
       
        class Circle
        {
            public static float _pi;
            int _radius;
            static Circle()
            {
                Console.WriteLine("Static Constructor Called!");
                Circle._pi = 3.14f;
            }
            public Circle (int Radius)
            {
                Console.WriteLine("Instance Constructor Called!");
                this._radius = Radius;
            }
            public float CalculateArea()
            {
                return Circle._pi * this._radius * this._radius;
            }
        }
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area={0}",Area1);

            Circle C2 = new Circle(5);
            float Area2 = C1.CalculateArea();
            Console.WriteLine("Area={0}",Area2);


            Console.ReadLine();
        }

    }
}
