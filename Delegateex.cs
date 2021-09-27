using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    delegate int MyFunction(int a);

    class Myclass
    {
        public static int myfun1_double(int n)
        {
            return n + n;
        }
        public static int square(int n)
        {
            return n * n;
        }
        public static int cube(int n)
        {
            return n * n*n;
        }
        public int myfun(int x)
        {
            return x + 100;
        }
    }
    class Delegateex
    {
        static void Main(string[] args)
        {
            MyFunction ob = new MyFunction(Myclass.myfun1_double);
            Console.WriteLine(ob(88));
            MyFunction ob1 = new MyFunction(Myclass.square);
            Console.WriteLine(ob1(8));
            MyFunction ob2 = new MyFunction(Myclass.cube);
            Console.WriteLine(ob2(3));

            Myclass x = new Myclass();
            MyFunction ob3 = new MyFunction(x.myfun);
            Console.WriteLine(ob3(44));

        }
    }
}
