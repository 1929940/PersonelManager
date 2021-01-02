using CommunicationLibrary.Business.Requests;
using System;

namespace Desktop.UI.Core.Helpers {
    public class DateHelper {
        public static DateTime CreateDate(int year, int month, int day) {
            string date = string.Format($"{year}/{month}/{day}");
            while (!DateTime.TryParse(date, out _))
                date = string.Format($"{year}/{month}/{--day}");

            return DateTime.Parse(date);
        }

        public static BillingPeriod GetBillingPeriod() {
            var configuration = new ConfigurationPageRequestHandler().Get();
            return GetBillingPeriod(configuration.BillingMonthStart, configuration.BillingMonthEnd, DateTime.Today);
        }

        public static BillingPeriod GetBillingPeriod(int fromDay, int toDay, DateTime date) {
            DateTime from = CreateDate(date.Year, date.Month, fromDay);
            DateTime to = CreateDate(date.Year, date.Month, toDay);

            if (fromDay > toDay) {
                if (date.Day >= fromDay) {
                    int month = to.AddMonths(1).Month;
                    to = CreateDate(date.Year, month, toDay);
                } else {
                    int month = to.AddMonths(-1).Month;
                    from = CreateDate(date.Year, month, fromDay);
                }
            }
            return new BillingPeriod() { From = from, To = to };
        }
    }

    public class BillingPeriod {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
