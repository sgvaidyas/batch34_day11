using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class SortedDict
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> rec = new SortedDictionary<int, string>();

            rec.Add(113, "Devi");
            rec.Add(114, "Apeksha");
            rec.Add(111, "Alex");
            rec.Add(115, "Rudr");
            rec.Add(112, "Graham");
            foreach (KeyValuePair<int, string> pair in rec)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }

            Console.WriteLine("sort by value");
            foreach(KeyValuePair<int, string> pair in rec.OrderBy(key=>key.Value))
            {
                Console.WriteLine("Key = {0}  & value = {1}",pair.Key,pair.Value);
            }
        }
    }
}
