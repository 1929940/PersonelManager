using CommunicationAndCommonsLibrary.Core.Logic;
using System;
using Xunit;

namespace CommunicationLibrary.Test.Core {
    public class DateHelperTest {

        // THREE DATES PER TEST: PERIOD STARTING DATE, PERIOD MIDDLE, PERIOD ENDING.

        // TESTS FOR AVERAGE 1-31 MONTH

        [Theory]
        [InlineData(1, 31, "2021-1-1", "2021-1-1", "2021-1-31")]
        [InlineData(1, 31, "2021-1-10", "2021-1-1", "2021-1-31")]
        [InlineData(1, 31, "2021-1-31", "2021-1-1", "2021-1-31")]

        // TESTS FOR 1-31 BUT WHEN MONTH HAS ONLY 28 DAYS
        [InlineData(1, 31, "2021-2-1", "2021-2-1", "2021-2-28")]
        [InlineData(1, 31, "2021-2-10", "2021-2-1", "2021-2-28")]
        [InlineData(1, 31, "2021-2-28", "2021-2-1", "2021-2-28")]

        // TESTS FOR CHANGE OF THE YEAR

        [InlineData(31, 30, "2020-12-31", "2020-12-31", "2021-1-30")]
        [InlineData(31, 30, "2021-1-10", "2020-12-31", "2021-1-30")]  
        [InlineData(31, 30, "2021-1-30", "2020-12-31", "2021-1-30")]  

        // TESTS FOR AVERAGE 31 DAY MONTH, IN A CUSTOM PERIOD STARTING AT THE END OF ONE MONTH, AND ENDING AT THE END OF THE NEXT

        [InlineData(31, 30, "2021-1-31", "2021-1-31", "2021-2-28")]
        [InlineData(31, 30, "2021-2-10", "2021-1-31", "2021-2-28")]
        [InlineData(31, 30, "2021-2-28", "2021-1-31", "2021-2-28")]

        // TESTS FOR AVERAGE 28 DAY MONTH, IN A CUSTOM PERIOD STARTING AT THE END OF ONE MONTH, AND ENDING AT THE END OF THE NEXT

        [InlineData(31, 30, "2021-3-1", "2021-2-28", "2021-3-30")]
        [InlineData(31, 30, "2021-3-30", "2021-2-28", "2021-3-30")]

        // TESTS FOR A PERIOD IN THE MIDDLE OF A MONTH

        [InlineData(25, 24, "2021-1-25", "2021-1-25", "2021-2-24")]
        [InlineData(25, 24, "2021-1-26", "2021-1-25", "2021-2-24")]
        [InlineData(25, 24, "2021-2-24", "2021-1-25", "2021-2-24")]
        public void DateHelperOutputTest_ShouldPass(int from, int to, string date, string expectedFrom, string expectedTo) {

            var actual = DateHelper.GetBillingPeriod(from, to, DateTime.Parse(date));

            Assert.Equal(DateTime.Parse(expectedFrom), actual.From);
            Assert.Equal(DateTime.Parse(expectedTo), actual.To);
        }
    }
}
