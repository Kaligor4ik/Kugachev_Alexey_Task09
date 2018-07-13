using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            string[] arr = new string[50];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = "" + (char)r.Next('a', 'z') + (char)r.Next('a', 'z');
            }
   
            SortedArray<string> sa0 = new SortedArray<string>(StringComparer.SortByAlphabet, arr);
            SortedArray<string> sa1 = new SortedArray<string>(StringComparer.SortByLentgh, arr);
            SortedArray<string> sa2 = new SortedArray<string>(StringComparer.Sort, arr);

            ThreadBuider tb = new ThreadBuider();
            tb.ThreadStrts.Add(new ThreadStart(sa0.Sort().Print));
            tb.ThreadStrts.Add(new ThreadStart(sa1.Sort().Print));
            tb.Build();

            tb.StartAll();

            sa0.Sort().Print();
            sa2.Sort().Print();

            Console.ReadKey();
        }
    }
}
