using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Character
    {
        public static void Main()
        {
            string str;
            char ch;
            Console.WriteLine("Enter the string :");
            str = Console.ReadLine();
            Console.WriteLine(" Enter the character:");
            ch = Convert.ToChar(Console.ReadLine());
            int freq = 0;
            foreach(char c in str)
            {
                if(c==ch)
                {
                    freq++;
                }
            }
            Console.WriteLine("character is repeated in the string is:"+freq);
            Console.ReadLine();

        }
        

    }
}
