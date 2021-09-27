using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Stackex
    {
        static void Main(string[] args)
        {
            Stack<Int32> num = new Stack<int>();
            num.Push(77);
            num.Push(55);
            num.Push(33);

            foreach(int x in num)
                Console.WriteLine(x);

            Console.WriteLine("Peek = "+num.Peek());
            Console.WriteLine(" deleting "+   num.Pop());
            Console.WriteLine("\n\n");
            foreach (int x in num)
                Console.WriteLine(x);

        }
    }
}
