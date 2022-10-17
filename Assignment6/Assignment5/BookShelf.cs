using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
   

        class BookShelf
        {
            Books b;
            public static void SetIndexer(Books b)
            {
                b[0] = "java";
                b[1] = "php";
                b[2] = "c";
                b[3] = "Csharp";
                b[4] = "python";

                b[0L] = "james gosling";
                b[1L] = "Rasmus Lerdorf";
                b[2L] = "Dennis ritchie";
                b[3L] = "Anders hejlsberg";
                b[4L] = " Guido van Rossum";
                b.Display();
            }
            public BookShelf()
            {
                b = new Books();
                SetIndexer(b);
            }
        }
        class Books
        {
            string[] BookName = new string[5];
            string[] AuthorName = new string[5];
            public string this[int Bname]
            {
                get { return BookName[Bname]; }
                set { BookName[Bname] = value; }
            }
            public string this[long Aname]
            {
                get { return AuthorName[Aname]; }
                set { AuthorName[Aname] = value; }
            }
            public void Display()
            {
                Console.WriteLine("---BookS_Details---");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("The author of {0} is {1} ", BookName[i], AuthorName[i]);
                }
            }
        }
        class Driven_Bookshelf
        {
            public static void Main(string[] args)
            {
                BookShelf i = new BookShelf();
                Console.Read();
            }
        }
    }


