using System;
enum MonthName
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
namespace WhatDay
{
    internal class WhatDay
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a year");
                string year = Console.ReadLine();
                int yearNum = int.Parse(year);
                int maxDayNum;
                bool isLeapYear;
                if (yearNum%4==0)
                {
                    isLeapYear = true;
                }
                else
                {
                    isLeapYear = false;
                }
                if (isLeapYear == true)
                {
                    maxDayNum = 366;
                }
                else
                {
                    maxDayNum = 365;
                }
                Console.WriteLine("Please enter a day number between 1 and " +  maxDayNum + ":"); 
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);
                int monthNum = 0;
                if (isLeapYear == false)
                {
                    if (dayNum < 1 || dayNum > 365)
                    {
                        throw new ArgumentOutOfRangeException(dayNum + "Day out of Range");
                    }
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    if (dayNum < 1 || dayNum > 366)
                    {
                        throw new ArgumentOutOfRangeException(dayNum + "Day out of Range");
                    }
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }

            End:
                string MonthName;
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                switch (monthNum)
                {
                    case 0:
                        monthName = "January"; break;
                    case 1:
                        monthName = "February"; break;
                    case 2:
                        monthName = "March"; break;
                    case 3:
                        monthName = "April"; break;
                    case 4:
                        monthName = "May"; break;
                    case 5:
                        monthName = "June"; break;
                    case 6:
                        monthName = "July"; break;
                    case 7:
                        monthName = "August"; break;
                    case 8:
                        monthName = "September"; break;
                    case 9:
                        monthName = "October"; break;
                    case 10:
                        monthName = "November"; break;
                    case 11:
                        monthName = "December"; break;
                    default:
                        monthName = "not done yet"; break;
                }
                Console.WriteLine("{0},{1}", dayNum, monthName);
            }
            catch(System.Exception caught)
            {
            Console.WriteLine(caught);
            }
        }
        static System.Collections.ICollection DaysInMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static System.Collections.ICollection DaysInLeapMonths
        = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
