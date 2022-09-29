using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
       public  static void Main()
        {
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
