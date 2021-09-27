using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Userdefined
    {
        static void eligible(int per)
        {
            if (per < 65)
                throw new ArithmeticException("this candidate is not eligible");
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
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("hi this is me i execute in every case");
            }
        }
    }
}
