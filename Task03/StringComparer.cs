using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public delegate IComparer ComparerDelegate();
    class StringComparer
    {
        public static int CompareByLength(string x, string y)
        {
            int i = x.Length;
            int j = y.Length;
            return i > j ? 1 : i == j ? 0 : -1;
        }

        public static int CompareByAlphabet(string x, string y)
        {
            char[] charX = x.ToCharArray();
            char[] charY = y.ToCharArray();
            int length = x.Length >= y.Length ? y.Length : x.Length;
            for (int i = 0; i < length; i++)
            {
                if (charX[i] < charY[i])
                {
                    return -1;
                }
                else if (charX[i] > charY[i])
                {
                    return 1;
                }
            }
            return 0;
        }

        public static IComparer SortByLentgh()
        {
            return (IComparer)new ComparerByLentgh();
        }

        public static IComparer SortByAlphabet()
        {
            return (IComparer)new ComparerByAlphabet();
        }

        public static IComparer Sort()
        {
            return (IComparer)new Comparer();
        }

        private class ComparerByLentgh : Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                return CompareByLength(x.ToLower(), y.ToLower());
            }
        }

        private class ComparerByAlphabet : Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                return CompareByAlphabet(x.ToLower(), y.ToLower());
            }
        }

        private class Comparer : Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                int i = CompareByLength(x.ToLower(), y.ToLower());
                if (i == 0) i = CompareByAlphabet(x.ToLower(), y.ToLower());
                return i;
            }
        }
    }
}
