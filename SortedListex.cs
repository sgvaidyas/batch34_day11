using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class SortedListex
    {
        static void Main(string[] args)
        {
            SortedList<int, string> ob = new SortedList<int, string>();
            ob.Add(11, "Apple");
            ob.Add(44, "Mango");
            ob.Add(66, "Orange");
            ob.Add(33, "Pineapple");
           
            foreach (KeyValuePair<int,string> pair in ob)
                Console.WriteLine("{0} = {1}" ,pair.Key,pair.Value);

        }
    }
}
