using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Passanger
    {
        public void ticketbooking()
        {
            string name;
            int age,tickets;
            Console.WriteLine("enter a name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("no of ticket booked:");
            tickets = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<tickets;i++)
            {
                if(tickets>2)
                {
                    Console.WriteLine("cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("tickets booked successfully");
                }
                Console.ReadLine();
            }
            
        }
        class Test
        {
            static void Main()
            {
                Passanger p = new Passanger();
                p.ticketbooking();
            }
        }
    }
}
