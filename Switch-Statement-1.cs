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
            
            int TotalCoffeecost = 0;
            Start:
            Console.WriteLine("Please Select Your Coffee Size 1- Small, 2 -Medium, 3 -Large");
            int Userchoice = int.Parse(Console.ReadLine());
            switch (Userchoice)
            {
                case 1:
                    TotalCoffeecost += 1;
                    break;
                case 2:
                    TotalCoffeecost += 2;
                    break;
                case 3:
                    TotalCoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is Invalid",Userchoice);
                    goto Start;
            }
            Decide:
            Console.WriteLine("Do You Want to buy another Coffee - Yes or No");
            string Userdecision =Console.ReadLine();
            switch (Userdecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice is Invalid Select yes or no");
                    goto Decide;
               
            }
            Console.WriteLine("Total Coffee Cost:{0}",TotalCoffeecost);
            Console.WriteLine("Thank You For Shopping With us");
            Console.WriteLine("Bill Amount is:{0}",120*TotalCoffeecost);
            Console.ReadLine();
        }
    }
}
