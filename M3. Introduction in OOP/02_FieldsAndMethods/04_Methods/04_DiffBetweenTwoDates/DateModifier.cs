using System;
using System.Linq;

namespace _04_DiffBetweenTwoDates
{
    static class DateModifier
    {
        public static double CalculateDifference(string date1, string date2)
        {
            //date1 = 1992 05 31
            DateTime d1 = Converter(date1);
            DateTime d2 = Converter(date2);

            return Math.Abs((d1 - d2).TotalDays);
        }

        private static DateTime Converter(string date)
        {
            int[] d = date.Split().Select(int.Parse).ToArray();
            return new DateTime(d[0], d[1], d[2]);
        }
    }
}
