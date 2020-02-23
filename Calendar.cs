using System;

namespace QuickDate
{
	internal class Calendar
	{
        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"今天的日期是 {now}");
            Console.ReadLine();
        }

        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
	}
}

