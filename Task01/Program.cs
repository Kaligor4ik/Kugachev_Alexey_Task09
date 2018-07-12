using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Kolobok", "Kol", "lobok", "lob", "Kolob", "bok", };
            Print(arr);

            ComparerDelegate del;

            Console.WriteLine("Тип сортировки:\n 1) По алфавиту\n 2) По длине строки\n 3) Смешанная(по умолчанию)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    del = StringComparer.SortByAlphabet;
                    break;
                case "2":
                    del = StringComparer.SortByLentgh;
                    break;
                default:
                    del = StringComparer.Sort;
                    break;
            }

            Array.Sort(arr, del.Invoke());
            Print(arr);

            Console.ReadKey();
        }

        public static void Print(string[] arr)
        {
            Console.WriteLine(new string('-', 20));
            foreach (string s in arr) Console.WriteLine(s);            
            Console.WriteLine(new string('-', 20));
        }
    }
}
