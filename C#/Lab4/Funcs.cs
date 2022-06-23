using System;
using System.Collections.Generic;

namespace lab4
{
    public class Funcs
    {
        public static List<TDate> DatesGenerate()
        {
            List<TDate> dates = new List<TDate>();
            Random random = new Random();
            Console.Write("Enter the amount of dates: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int day = random.Next(1, 31);
                int month = random.Next(1, 12);
                int year = random.Next(0, 100);
                TDate date = new TDate(day, month, year);
                dates.Add(date);
            }

            return dates;
        }
        
        public static List<TTime> TimesGenerate()
        {
            List<TTime> times = new List<TTime>();
            Random random = new Random();
            Console.Write("Enter the amount of times: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int hours = random.Next(0, 24);
                int minutes = random.Next(0, 60);
                int seconds = random.Next(0, 60);
                TTime time = new TTime(hours, minutes, seconds);
                times.Add(time);
            }

            return times;
        }

        public static void ListOutput(List<TDate> list)
        {
            foreach (var date in list)
            {
                date.Output();
            }
        }

        public static void ListOutput(List<TTime> list)
        {
            foreach (var time in list)
            {
                time.Output();
            }
        }

        public static bool IsLikeTime(TDate date)
        {
            if (date.Number1 < 24 && date.Number3 < 60)
            {
                return true;
            }

            return false;
        }
        
        
        public static void ChangeDates(List<TDate> dates)
        {
            foreach (var date in dates)
            {
                if (!IsLikeTime(date))
                {
                    date.DecreaseNumber1(5);
                }
            }
        }
        
        public static void ChangeTimes(List<TTime> times)
        {
            foreach (var time in times)
            {
                time.IncreaseNumber2(15);
            }
        }
        
        public static string ChangeFormat(int n)
        {
            string n_str = Convert.ToString(n);
            if (n < 10)
            {
                n_str = "0" + n_str;
            }

            return n_str;
        }

        public static List<TDate> DatesLikeTime(List<TDate> dates)
        {
            List<TDate> dates_like_time = new List<TDate>();
            foreach (var date in dates)
            {
                if (IsLikeTime(date)) dates_like_time.Add(date);
            }

            return dates_like_time;
        }
    }
}