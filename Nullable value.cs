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
            //reference type can contain null value
            //for example
            // string name = null;
            //value type can be divided in tot two types
            //One Nullable value type
            //Non-nullable value type
            // int i=null; i is non nullable value
            // int? i = null; // i is nullable value
            //Console.WriteLine(i);

            /******************************************/
            //bool? Areyoumajor=true; //bool is non nullable
            //bool? a = null; //at this moment a is null

            //if (Areyoumajor==true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (Areyoumajor==false)
            //{
            //    Console.WriteLine("User is not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the question");
            //}

            // int? Ticketsonsale = null;

            /***********************************/
            //int Ticketsonsale = 100;
            //int Avaiableticket;
            //if (Ticketsonsale==null)
            //{
            //    Avaiableticket = 0;
            //}
            //else
            //{
            //Avaiableticket=(int)Ticketsonsale;

            //}
            //Console.WriteLine("Available Tickets={0}",Avaiableticket);
            /****************************************/

            //null Coalesing Operator
            int? Ticketonsale = 100;
            int AvailableTickets = Ticketonsale ?? 0;
            Console.WriteLine("Available Tickets={0}", AvailableTickets);

            Console.ReadLine();
        }
    }
}
