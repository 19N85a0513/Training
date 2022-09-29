using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("\n\n");
            Console.Write("check whether a number is positive or negative:\n");
            Console.Write("----------------");
            Console.Write("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0} is a positive number \n", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number \n", num);
            }
            Console.ReadKey();
        }
    }
}
