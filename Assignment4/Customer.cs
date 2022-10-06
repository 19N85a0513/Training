using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Customer
    {
        int custid, age, phone;
        string custname, city;
        public Customer()
        {
            custid = 12;
            custname = "kavitha";
            age = 24;
            phone = 987654321;
            city = "Hyderabad";

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"customerid: { custid}\n" + $"customername: {custname}\n" + $"Age : {age}\n " + $"phoneno :{phone}\n" + $"customercity : {city}\n");
            Console.ReadLine();
        }
        ~Customer()
        {
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
    class Details
    {
        static void Main()
        {
            Customer ct = new Customer();
            ct.DisplayDetails();
            Console.ReadLine();
        }
    }
}
