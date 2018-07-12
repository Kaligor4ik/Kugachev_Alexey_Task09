using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class WelcomeFormUtils
    {
        private static readonly DateTime morningTime = DateTime.Parse("12:00");
        private static readonly DateTime eveningTime = DateTime.Parse("17:00");

        public static string GetFormByTime(string timeString)
        {
            DateTime time = DateTime.Parse(timeString);
            if (DateTime.Compare(time, morningTime) < 0)
            {
                return "Доброе утро";
            }
            else if (DateTime.Compare(time, eveningTime) >= 0)
            {
                return "Добрый вечер";
            }
            else
            {
                return "Добрый день";
            }
        }
    }
}
