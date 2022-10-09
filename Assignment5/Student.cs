using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class Student
    {

        //abstract  public int IsPassed();
        abstract public int grade();
        public void display()
        {
            int grade;
            Console.WriteLine("enter a grade");
            grade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < grade; i++)
            {
                if (grade > 30)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("fail");
                }
                Console.ReadLine();
            }
        }
    }
    class undergraduate : Student
    {
        public undergraduate()
        {


            String Name;
            int id;
            Console.WriteLine(" student name: ");
            Name = Console.ReadLine();
            Console.WriteLine(" student rollno:");
            id = Convert.ToInt32(Console.ReadLine());
        }
        public override int grade()
        {
            int number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            string value = (number > 70) ? "True" : "False";
            Console.WriteLine($"{number} is {value}");
            return number;
        }
   }
    class graduate : Student
    {
        public graduate()
        {
            string Name;
            int id;
            Console.WriteLine("student Name:");
            Name = Console.ReadLine();
            Console.WriteLine("student id ");
            id = Convert.ToInt32(Console.ReadLine());
        }
        public override int grade()
        {
            int number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            string value = (number > 80) ? "True" : "False";
            Console.WriteLine($"{number} is {value}");
            return number;
        }
            
        
    }
    class Program
    {
         static void Main()
        {
            Student s = new undergraduate();
            Console.WriteLine(s.grade());
            Student s1 = new graduate();
            Console.WriteLine(s.grade());
            s.display();
        }
    }
}

