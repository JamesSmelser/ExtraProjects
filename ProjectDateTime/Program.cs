﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1977, 5, 31);

            Console.WriteLine($"My birthday is {dateTime}");

            Console.WriteLine($"{DateTime.Today}");
            Console.WriteLine($"{DateTime.Now}");

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");
            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");
            Console.WriteLine($"First day of the Year {GetFirstDayOfYear(1999)}");

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in Feb 2000: {days}");
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine($"Days in Feb 2001: {days}");
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine($"Days in Feb 2004: {days}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute is {now.Minute}");
            Console.WriteLine($"Current time is {now.Hour}:{now.Minute}:{now.Second}");

            Console.WriteLine($"Write your birth date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"You are {daysPassed.Days} days old");
            }
            else
            {
                Console.WriteLine($"Incorrect input format!");
            }
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
