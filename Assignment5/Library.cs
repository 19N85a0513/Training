using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Libraryproject 
    {
        public void CalculateConcession()
        {
            string Name;
            int Age;
            double TotalFare = 500;
            Console.WriteLine("enter the name");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the age");
            Age = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < Age; i++)
            {
                if (Age <= 5)
                {
                    Console.WriteLine("Little champs-free ticket");
                }
                else if(Age>60)
                {
                    TotalFare = 500 / 100 * 30;
                    Console.WriteLine("TotalFare = {0}\n", TotalFare);
                    Console.WriteLine("senior citizen");
                }
                else
                {
                    Console.WriteLine("TotalFare : 500");
                    Console.WriteLine("Ticket booked");
                }
                Console.ReadLine();
            }

        }
    }
    class  LibraryEg
    {
        static void Main()
        {
            Libraryproject l = new Libraryproject();
            l.CalculateConcession();
        }
    }
}
