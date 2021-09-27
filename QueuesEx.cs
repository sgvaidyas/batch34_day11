using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class QueuesEx
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            names.Enqueue("Amit");
            names.Enqueue("Sushma");
            names.Enqueue("Abhishek");
            names.Enqueue("Samanatha");

            foreach(var n in names)
                Console.WriteLine(n);

            Console.WriteLine("Peek = "+names.Peek());
            Console.WriteLine("deleting = "+   names.Dequeue());

            Console.WriteLine("\n\n");
            foreach (var n in names)
                Console.WriteLine(n);

        }
    }
}
