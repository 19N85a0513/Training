using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Box
    {
        public void add2objects(int length, int breadth)
        {
            int c = length + breadth;
            Console.WriteLine(c);
            Console.Read();
        }
    }
    class Test : Box
    {
        public static void Main()
        {
            Test t = new Test();
            t.add2objects(4, 6);
            Console.Read();

        }
    }
}
  
     
