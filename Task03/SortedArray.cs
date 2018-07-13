using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class SortedArray<T>
    {
        public delegate void MessageDelegate(string n);
        public event MessageDelegate FinishSort;
        public event MessageDelegate FinishPrint;

        private readonly IComparer comparer;
        private readonly T[] arr;
        private static int count = 0;
        private int num;

        public SortedArray(ComparerDelegate comparer, T[] arr)
        {
            num = count;
            count++;
            this.comparer = comparer.Invoke();
            this.arr = arr;
            FinishSort += PrintMessage;
            FinishPrint += PrintMessage;
        }

        public SortedArray<T> Sort()
        {
            Array.Sort(arr, comparer);
            FinishSort(string.Format("Сортировка {0} завершена ", num));
            return this;
        }

        public void Print()
        {
            foreach (T t in arr) Console.WriteLine(t + " из сортировки " + num + "\t");
            Console.WriteLine();
            FinishPrint(string.Format("Печать {0} завершена ", num));
        }

        public void PrintSeparate()
        {
            Console.WriteLine(new string('-', 20));
            foreach(T t in arr) Console.WriteLine(t + " из сортировки " + num + "\t");
            Console.WriteLine("\n" + new string('-', 20));
            FinishPrint(string.Format("Печать {0} завершена ", num));
        }

        public void PrintMessage(string m)
        {
            Console.WriteLine(m);
        }
    }
}
