using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IStudent 
    {
        void ShowDetails();
    }
    class Dayscholar : IStudent
    {
        public void ShowDetails( )
        {
            int StudentId;
            string Name;
            Console.WriteLine("enter the id");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("studentn id: {0}\n", StudentId);
            Console.WriteLine("enter the name");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("Student name : {0}\n", Name);
            Console.ReadLine();
        }
       
    }
    class Resident : IStudent
    {
        public void ShowDetails()
        {
            int StudentId;
            string Name;
            Console.WriteLine("enter the id");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("studentn id {0}\n", StudentId);
            Console.WriteLine("enter the name");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("Student name : {0}\n", Name);
            Console.ReadLine();
        }
        
        

    }
    class Program2
    {
        static void Main(string [] args)
        {
            IStudent s = new Dayscholar();
            s.ShowDetails();
            IStudent s1 = new Resident();
            s1.ShowDetails();
          


        }
    }
}