using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class SortedSet_ex
    {
        static void Main(string[] args)
        {
            var ob = new SortedSet<int>();

            ob.Add(55);
            ob.Add(11);
            ob.Add(2);
            ob.Add(34);
            ob.Add(55);
            ob.Add(11);

            foreach(int x in ob)
                Console.WriteLine(x);

        }
    }
}
