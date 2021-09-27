using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Hashset
    {
        static void Main(string[] args)
        {
            var subjects = new HashSet<string>();
            int ch;
            do
            {
                Console.WriteLine("Enter sub name = ");
                string name = Console.ReadLine();
                subjects.Add(name);

                Console.WriteLine("Press 1 to continue");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);

            Console.WriteLine("\n\nThe subjects = ");
            foreach(string ob in subjects)
                Console.WriteLine(ob);
        }
    }
}
