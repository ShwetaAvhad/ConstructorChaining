using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum WeekDays
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //WeekDays weekdays=WeekDays.Friday;
            //Console.WriteLine((int)weekdays);
            foreach (var days in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(days +" ==> "+(int)days);
            }

        }
    }
}
