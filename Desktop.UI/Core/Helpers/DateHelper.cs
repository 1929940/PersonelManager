using System;

namespace Desktop.UI.Core.Helpers {
    public class DateHelper {
        public static DateTime CreateDate(int year, int month, int day) {
            string date = string.Format($"{year}/{month}/{day}");
            while (!DateTime.TryParse(date, out _))
                date = string.Format($"{year}/{month}/{--day}");

            return DateTime.Parse(date);
        }
    }
}
