using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            String rev = "";
            Console.WriteLine(" Enter the word:");
            str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--)
            {
                rev += str[i].ToString();
            }
            if(rev== str)
            {
                Console.WriteLine("word is palindrome");
            }
            else
            {
                Console.WriteLine("string is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
