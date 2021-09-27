using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class LinkedListEx
    {
        static void Main(string[] args)
        {
            var sub = new LinkedList<string>();

            sub.AddLast("Shilpa");
            sub.AddLast("Keerthi");
            sub.AddLast("Shilpa");
            sub.AddFirst("Prabhu");

            LinkedListNode<string> nd = sub.Find("Shilpa");
            sub.AddBefore(nd, "Pallavi");
            sub.AddAfter(nd, "Vivek");
            foreach (var s in sub)
                Console.WriteLine(s);
        }
    }
}
