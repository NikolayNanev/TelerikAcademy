using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TodaysDayOfTheWeek
{
    //Write a program that prints to the console which day of the week is today. Use System.DateTime.

    static void Main()
    {
        DateTime timeNow = DateTime.Now;

        var todayDayOfTheWeek = timeNow.DayOfWeek;

        Console.WriteLine("Today's day of the week is \'{0}\'.", todayDayOfTheWeek);
    }
}