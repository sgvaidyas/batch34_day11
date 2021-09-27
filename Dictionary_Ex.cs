using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Dictionary_Ex
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> rec = new Dictionary<int, string>();

            rec.Add(111,"Alex");
            rec.Add(112, "Graham");
            rec.Add(113, "Devi");
            rec.Add(114, "Apeksha");
            rec.Add(115, "Rudr");
            foreach (KeyValuePair<int,string> pair in rec)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }
            
            //print only keys
            foreach(var ob in rec.Keys)
                Console.WriteLine(ob);

            //get the value of a key
            Console.WriteLine("the value = "+ rec[111]);

        }
    }
}
