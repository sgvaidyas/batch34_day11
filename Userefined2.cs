using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Myexception:Exception
    {
        public Myexception(string mess):base(mess)
        {

        }
    }
    class Userefined2
    {
        static void eligible(int per)
        {
            if (per < 65)
                throw new Myexception("this candidate is not eligible");
        }
        static void Main(string[] args)
        {
            int per;

            try
            {
                Console.WriteLine("Enter the per");
                per = int.Parse(Console.ReadLine());
                eligible(per);
            }
            catch (Myexception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
