using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class String
    {
        string FirstName;
        string LastName;
        string str1, str2;
        public void Display()
        {
            Console.WriteLine("enter the firstname:");
            FirstName = Console.ReadLine();
            Console.WriteLine("enter the last name");
            LastName = Console.ReadLine();
            str1 = FirstName.ToUpper();
            str2 = LastName.ToUpper();
            Console.WriteLine("FirstName:"+str1);
            Console.WriteLine("LastName:" + str2);
            Console.ReadLine();
        }
    }
    class Name
    {
        public static void Main()

        {
            String s = new String();
            s.Display();
            
        }
    }
}

            
        

    


