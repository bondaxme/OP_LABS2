using System;
using System.Collections.Generic;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<TDate> dates = Funcs.DatesGenerate();
            List<TTime> times = Funcs.TimesGenerate();
            
            Console.WriteLine("\nInitial dates:");
            Funcs.ListOutput(dates);
            Console.WriteLine("\nInitial times:");
            Funcs.ListOutput(times);

            List<TDate> dates_like_time = Funcs.DatesLikeTime(dates);
            Console.WriteLine("\nDates that can be interpreted like time:");
            Funcs.ListOutput(dates_like_time);
            
            Funcs.ChangeDates(dates);
            Funcs.ChangeTimes(times);
            
            Console.WriteLine("\nChanged dates:");
            Funcs.ListOutput(dates);
            Console.WriteLine("\nChanged times:");
            Funcs.ListOutput(times);
        }
    }
}