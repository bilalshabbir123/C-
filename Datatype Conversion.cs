using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCsharp
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //Implicit Conversions
            int a = 100;
            float b = a;   //convert int to float
            Console.WriteLine(b);

            float c = 123.5f; //suffix f is add in float
                              //int i = f;  //cannot convert float value in int
                              // float can have fractional part
            int i = (int)c;
            Console.WriteLine(i);
            float d = 56.6f;
            int e = (int)d; //use expliicit conversion using cast() operator
            Console.WriteLine(e);
            float j = 78.66f;
            int k = Convert.ToInt32(j); //explicit conversion using convert class
            Console.WriteLine(k);

            // float f=23232323232.45f;
            //int h=Convert.ToInt32(f); //cannot convert it throws an exception
            //int k=(int)f; and it also did no gave true value

            //int.Parse is used to convert string to int
            string strnumber = "100";
            int l = int.Parse(strnumber);
            Console.WriteLine(l);


            //int.Parse is used to convert string to int
           // string str = "10000abc"; //int.parse cannot convert this type of string value like 100abc
            string str = "10000";
            int m=0 ;

            //Int.tryparse is used to convert 100abc type string to int
            //the return type of try parse method is boolen type true
            bool IsconvertSuccessful=int.TryParse(str,out m);
            if (IsconvertSuccessful)
            {
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("please Enter a Valid Number");
            }
          
            Console.ReadLine();
        }
    }
}
