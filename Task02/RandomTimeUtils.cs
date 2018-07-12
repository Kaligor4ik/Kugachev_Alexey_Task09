using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class RandomTimeUtils
    {
       static Random r = new Random();
        public static string getAsString()
        {
            return "" + r.Next(0, 3) + r.Next(0, 4) + ":" + r.Next(0, 6) + r.Next(0, 10);
        }
    }
}
