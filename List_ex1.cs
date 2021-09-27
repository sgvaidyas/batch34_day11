using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class List_ex1
    {
        static void Main(string[] args)
        {
            var marks = new List<Int32>();
            marks.Add(66);
            marks.Add(55);
            marks.Add(63);
            marks.Add(69);

            foreach(var x in marks)
                Console.WriteLine(x);


            var names = new List<string> { "Alex", "James", "Mary" ,"Alex"};

            foreach(var x in names)
                Console.WriteLine(x);
        }
    }
}
