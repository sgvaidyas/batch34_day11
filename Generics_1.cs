using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Addition<T,V>
    {
        
        public Addition(T data1,V data2)
        {            
            Console.WriteLine(data1 + "   " +data2 );
        }


        public void sum<T>(T num1,T num2)
        {
            dynamic d1 = num1;
            dynamic d2 = num2;
            Console.WriteLine("sum = " +(d1+d2));
        }
    }

    class Generics_1
    {
        static void Main(string[] args)
        {
            Addition<string,string> ob = new Addition<string,string>("Mydaya string type","second string");
            Addition<int,string> ob1 = new Addition<int,string>(888,"suresh");
            Addition<float,string> ob2 = new Addition<float,string>(99.9f,"Ramesh");

            ob1.sum(88, 99);
            ob1.sum("apple ", " mango ");
            ob1.sum(88.4f, 9.5f);
        }
    }
}
