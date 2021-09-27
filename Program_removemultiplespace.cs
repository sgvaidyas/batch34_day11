using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day11
{
    class Program_removemultiplespace
    {
        static string removespace(string s)
        {
            int i = 0,n,j;
            StringBuilder a = new StringBuilder(s);
            n = a.Length;
            while(i<n-1)
            {
                if (a[i] == ' ' && a[i + 1] == ' ')
                {
                    for (j = i + 1; j < n-1; j++)
                        a[j] = a[j + 1];
                    n--;
                }
                else
                {
                    i++;
                    //Console.WriteLine(i +" "+a[i]);
                }                    
            }
            s = a.ToString().Substring(0, n);
            if (s[0] == ' ')
            {
                s = s.Substring(1, n - 1);
                n--;
            }
            if (s[n-1] == ' ')
                s = s.Substring(0, n-1);

            return s;
        }
        static void Main(string[] args)
        {
            string s = "        hi       hello     whatsup        ?      ";
            s = removespace(s);
            Console.WriteLine(s+": is the string without redundant spaces");


            string[] words = s.Split(' ');
            Console.WriteLine(words.Length);
            int count = 0;
            string punc = "`~!@?#$%^&*() ";
            foreach (string x in words)
            {
                if (!punc.Contains(x))
                    count++;
            }
            Console.WriteLine("the number of words = "+count);
        }
    }
}
