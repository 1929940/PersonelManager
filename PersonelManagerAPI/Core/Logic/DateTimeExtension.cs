using System;
using System.Globalization;

namespace API.Core.Logic {
    public static class DateTimeExtension {
        public static DateTime FirstDayOfTheMonth(this DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, 1);
        public static DateTime LastDayOfTheMonth(this DateTime dateTime) => dateTime.AddMonths(1).AddDays(-1);

        public static string GetMonthNamePL(this DateTime dateTime) => dateTime.ToString("MMMM", CultureInfo.CurrentCulture);
    }
}
